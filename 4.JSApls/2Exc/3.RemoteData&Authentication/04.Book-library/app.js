const tbody = document.querySelector('tbody');
const createForm = document.getElementById('createForm');
const editForm = document.getElementById('editForm');
document.getElementById('loadBooks').addEventListener('click', loadBooks);
createForm.addEventListener('submit', onCreate);
editForm.addEventListener('submit', onEditSubmit);
tbody.addEventListener('click', onTableClick);

loadBooks();

async function onEditSubmit(event) {
    event.preventDefault();
    const formData = new FormData(event.target);

    const id = formData.get('id');
    const author = formData.get('author');
    const title = formData.get('title');

    await updateBook(id, { author, title });

    event.target.reset();
    createForm.style.display = 'block';
    editForm.style.display = 'none';

    loadBooks();
}

function onTableClick(event) {
    if (event.target.className == 'delete') {
        onDelete(event.target);
    } else if (event.target.className == 'edit') {
        onEdit(event.target);
    }
}

async function onDelete(button) {
    const id = button.parentElement.dataset.id;
    await deleteBook(id);
    button.parentElement.parentElement.remove();
}

async function onEdit(button) {
    const id = button.parentElement.dataset.id;
    const book = await loadBookById(id);

    createForm.style.display = 'none';
    editForm.style.display = 'block';

    editForm.querySelector('[name="id"]').value = id;
    editForm.querySelector('[name="author"]').value = book.author;
    editForm.querySelector('[name="title"]').value = book.title;
}

async function onCreate(event) {
    event.preventDefault();
    const formData = new FormData(event.target);

    const author = formData.get('author');
    const title = formData.get('title');

    const result = await createBook({ author, title });
    tbody.appendChild(createRow(result._id, result));
    event.target.reset();
}

async function request(url, options) {
    if (options && options.body != undefined) {
        Object.assign(options, {
            headers: {
                'Content-type': 'aplication/json'
            },
        });
    }
    const response = await fetch(url, options);
    if (!response.ok) {
        const error = await response.json();
        alert(error.message);
        throw new Error(error.message);
    }
    return await response.json();
}

async function loadBooks() {
    const books = await request(`http://localhost:3030/jsonstore/collections/books`);

    const result = Object.entries(books).map(([id, book]) => createRow(id, book));
    tbody.replaceChildren(...result);
}

async function loadBookById(id) {
    return await request(`http://localhost:3030/jsonstore/collections/books/${id}`);
}

function createRow(id, book) {

    const editBtn = document.createElement('button');
    editBtn.textContent = 'Edit';
    editBtn.classList.add('edit');

    const delBtn = document.createElement('button');
    delBtn.textContent = 'Delete';
    delBtn.classList.add('delete');

    const td1 = document.createElement('td');
    td1.textContent = book.title;

    const td2 = document.createElement('td');
    td2.textContent = book.author;

    const td3 = document.createElement('td');
    td3.appendChild(editBtn);
    td3.appendChild(delBtn);
    td3.setAttribute('data-id', id);

    const tr = document.createElement('tr');
    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);

    return tr;
}

async function createBook(book) {
    return await request('http://localhost:3030/jsonstore/collections/books', {
        method: 'post',
        body: JSON.stringify(book)
    });
}

async function updateBook(id, book) {
    return await request('http://localhost:3030/jsonstore/collections/books/' + id, {
        method: 'put',
        body: JSON.stringify(book)
    });
}

async function deleteBook(id) {
    return await request('http://localhost:3030/jsonstore/collections/books/' + id, {
        method: 'delete',
    });
}