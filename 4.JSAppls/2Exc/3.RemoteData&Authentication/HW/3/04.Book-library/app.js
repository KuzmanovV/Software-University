window.addEventListener('load', onLoad);
const loadBooksBtn = document.getElementById('loadBooks');
loadBooksBtn.addEventListener('click', onLoad);

const submitForm = document.getElementById('submitBookForm');
submitForm.addEventListener('submit', submitBook);

const editForm = document.getElementById('editBookForm');
editForm.addEventListener('submit', editBook)

const tableBody = document.querySelector('table tbody');
tableBody.addEventListener('click', onBtnsClick);

const tfoot = document.createElement('tfoot');

// object that will help us with the edit and delete functionality
const currBook = {
    id: '',
    title: '',
    author: ''
}

async function onLoad(event) {

    editForm.style.display = 'none';
    // in case we want to reload the table but dont't want to refresh the whole page, the btn will be disabled when clicked, and after the code execution will be enabled
    if (event.target.tagName === 'BUTTON') {
        loadBooksBtn.disabled = true;
    }

    // for user friendly experience this msg will be displayed while the books are beeing loaded
    tableBody.textContent = 'Loading books...';
    const result = await request('http://localhost:3030/jsonstore/collections/books');

    tableBody.replaceChildren();
    Object.entries(result).forEach(([id, infoObj]) => {
        const newTr = createRow(id, infoObj);
        tableBody.appendChild(newTr);
    });
    loadBooksBtn.disabled = false;
}

async function submitBook(event) {
    event.preventDefault();

    const form = event.target;

    const formData = new FormData(form);

    const title = formData.get('title').trim();
    const author = formData.get('author').trim();
    form.reset();

    try {
        if (title === '' || author === '') {
            throw new Error('Please fill all fields')
        }

        currBook.title = title.trim();
        currBook.author = author.trim();

        // look at the bottom of the file for more info about the function
        checkTableForTitle(currBook.title);

        form.querySelector('button').disabled = true;
        tableBody.textContent = 'Loading books...';

        // look at the bottom of the file for more info about the function
        await checkDataBase(currBook.title);

        const result = await request('http://localhost:3030/jsonstore/collections/books', {
            method: 'post',
            body: JSON.stringify({
                title: title.trim(),
                author: author.trim()
            })
        });

        // directly creates the new row and appends it to the table body
        tableBody.appendChild(createRow(result._id, { title, author }));

        // reloads the table directly from the data base
        onLoad(event);
        form.querySelector('button').disabled = false;
    } catch (error) {
        alert(error.message);
        return;
    }
}

// depending on which btn is clicked different functionality trigers
async function onBtnsClick(event) {
    
    // if the edit btn is clicked
    if (event.target.dataset.id.includes('Edit-')) {

        // the book's id, title and author will be stored in the helper object at the top
        currBook.id = event.target.dataset.id.slice(5); // here we extract the id without the 'Edit-' part
        currBook.title = event.target.parentElement.parentElement.children[0].textContent;
        currBook.author = event.target.parentElement.parentElement.children[1].textContent;

        // swap visibility of the forms
        submitForm.style.display = 'none';
        editForm.style.display = 'block';

        // for user friendly experience, when the edit btn is clicked, the edit form will be automatically filled with the title and author
        editForm.querySelector('[name="title"]').value = currBook.title;
        editForm.querySelector('[name="author"]').value = currBook.author;

        // if the delete btn is clicked
    } else if (event.target.dataset.id.includes('Edit-') === false) {

        // confirmation message (OK / Cancel) on the delete btn
        if (window.confirm('Are you sure you want to delete this book?')) {
            event.target.parentElement.parentElement.remove();
            await deleteBook(event.target.dataset.id);
        }
    }
}

async function deleteBook(id) {
    await request(`http://localhost:3030/jsonstore/collections/books/${id}`, {
        method: 'delete'
    })
}

async function editBook(event) {
    event.preventDefault();
    const formData = new FormData(event.target);

    const title = formData.get('title').trim();
    const author = formData.get('author').trim();

    try {
        event.target.reset();
        if (title === '' || author === '') {
            throw new Error('Please fill all fields');
        }

        editForm.style.display = 'none';
        submitForm.style.display = 'block';

        // look at the bottom of the file for more info about the function
        checkTableForTitle(title);

        tableBody.textContent = 'Loading books...';

        // I tried to put the next 2 requests in a promise.all (checkDataBase and the put request, but sometimes the additional functionality to check the database for the title didn't work properly e.g: if someone entered a new book with title 'Book1', and if we try to edit some other book from our sesion to have new title 'Book1' (we haven't refreshed the library yet), there would be 2 books with the same title in the library when the table reloads, copyright headache ©...

        // await Promise.all([

        // look at the bottom of the file again if you need to see what does this function do
        await checkDataBase(title);
        await request(`http://localhost:3030/jsonstore/collections/books/${currBook.id}`, {
            method: 'put',
            body: JSON.stringify({
                title: title,
                author: author,
                _id: currBook.id
            })
        }),
            // ])
        
        // load the table directly from the data base
        onLoad(event);

    } catch (error) {
        alert(error.message);
        return;
    }
}


// this function checks if there is already a book with the same title in OUR session of the library and if there is highlights it
function checkTableForTitle(title) {
    // this iteration resets the CSS to it's original state
    Array.from(tableBody.children).forEach((row) => {
        row.children[0].style.backgroundColor = 'initial';
    })
    // this iteration will highlight the cell if the title matches any of the titles and will alert us
    Array.from(tableBody.children).forEach((row) => {
        if (row.children[0].textContent === title) {
            row.children[0].style.backgroundColor = 'orange';
            throw new Error('This title is already present in your collection.');
        }
    })
}

// this function checks if there is already a book with the same title in the DB and if there is, alerts us
async function checkDataBase(title) {
    const result = await request('http://localhost:3030/jsonstore/collections/books');
    Object.values(result).forEach((book) => {
        if (book.title === title) {
            throw new Error('This book has been added by someone else in the library, reload the table.')
        }
    })
    return result;
}

function createEl(tag, attributes, ...content) {
    const el = document.createElement(tag);

    for (const attributeName in attributes) {
        el.setAttribute(attributeName, attributes[attributeName]);
    }

    for (let item of content) {
        if (typeof item === 'string' || typeof item === 'number') {
            item = document.createTextNode(item);
        }

        el.appendChild(item);
    }

    return el;

}

function createRow(id, infoObj) {
    const newTr = createEl('tr', null,
        createEl('td', null, `${infoObj.title}`),
        createEl('td', null, `${infoObj.author}`),
        createEl('td', null,
            createEl('button', { 'data-id': `Edit-${id}` }, 'Edit'), // custom made id's for the edit buttons
            createEl('button', { 'data-id': id }, 'Delete'), // custom made id's for the delete buttons
        )
    );
    return newTr;
}

async function request(url, options) {

    if (options && options.body !== undefined) {
        Object.assign(options, {
            headers: {
                'Content-Type': 'application/json'
            }
        })
    }

    const res = await fetch(url, options);
    if (res.ok !== true) {
        const error = await res.json();
        alert(error.message);
        throw new Error(`${error.message}`)
    }

    const data = await res.json();

    return data;
}