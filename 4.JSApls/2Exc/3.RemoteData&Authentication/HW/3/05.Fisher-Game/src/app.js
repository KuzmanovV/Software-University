const userData = JSON.parse(localStorage.getItem('userData'));
const catchesDiv = document.getElementById('catches');
const addFormBtn = document.querySelector('#addForm .add');
const addForm = document.getElementById('addForm');
const logOutBtn = document.getElementById('logout');
addForm.addEventListener('submit', addCatch);

window.addEventListener('load', () => {
    catchesDiv.style.display = 'none';
    document.querySelector('#home-view .load').addEventListener('click', loadCatches)
    if (userData !== null) {
        addFormBtn.disabled = false;
        document.getElementById('guest').style.display = 'none';
        document.querySelector('.email span').textContent = userData.email;
        logOutBtn.addEventListener('click', userLogout);
        document.getElementById('catches').addEventListener('click', btnsFunctionality);
    } else {

        Array.from(addForm.children).forEach((el) => el.disabled = false);

        document.getElementById('user').style.display = 'none';
    }
})

async function btnsFunctionality(event) {
    const id = event.target.dataset.id;

    if (event.target.className === 'update') {
        if (window.confirm('Are these your final changes?')) {
            event.target.disabled = true;
            const parentEl = event.target.parentElement;
            try {

                // on every click resets the css styles of the input fields
                Array.from(parentEl.children).forEach((el) => {
                    if (el.tagName === 'INPUT' && el.value !== '') {
                        el.style.borderColor = '';
                        el.style.borderWidth = ''
                    }
                })

                // higlights the empty input fields
                Array.from(parentEl.children).forEach((el) => {
                    if (el.tagName === 'INPUT' && el.value === '') {
                        el.style.borderColor = 'red';
                        el.style.borderWidth = '3px'
                    }
                })

                Array.from(parentEl.children).forEach((el) => {

                    if (el.tagName === 'INPUT' && el.value === '') {
                        throw new Error('Please fill all fields');
                    }

                    if (el.className === 'weight' && Number.isNaN(parseFloat(el.value.trim()))) {
                        el.style.borderColor = 'red';
                        el.style.borderWidth = '3px';
                        throw new Error('Weight must be floating-point number');
                    }

                    if (el.className === 'captureTime' && Number(el.value.trim()) % 1 !== 0) {
                        el.style.borderColor = 'red';
                        el.style.borderWidth = '3px';
                        throw new Error('Capture Time must be whole number!');
                    }
                })

                // object that will be send as body when the put request is send
                const updatedCatch = {};
                Array.from(parentEl.children).forEach((el) => {
                    if (el.tagName === 'INPUT') {
                        updatedCatch[el.className] = el.value.trim();
                    }
                })

                const res = await fetch(`http://localhost:3030/data/catches/${id}`, {
                    method: 'put',
                    headers: {
                        'Content-Type': 'application/json',
                        'X-Authorization': userData.token
                    },
                    body: JSON.stringify(updatedCatch)
                })
                if (res.ok !== true) {
                    const err = await res.json();
                    throw new Error(err.message);
                }

                const data = await res.json();
                console.log(data);
            } catch (error) {
                alert(error.message);
                event.target.disabled = false;
                return;
            }
            loadCatches(event);
            event.target.disabled = false;
        }
    } else if (event.target.className === 'delete') {
        console.log('delete');
        if (window.confirm('Are you sure you want to delete this post?')) {
            // first remove items from DOM for user-friendly experience
            event.target.parentElement.remove();

            // send the request to delete the catch
            await fetch(`http://localhost:3030/data/catches/${id}`, {
                method: 'delete',
                headers: {
                    'X-Authorization': userData.token
                }
            });
        }
    }
}

async function userLogout(event) {
    event.target.disabled = true;

    const res = await fetch('http://localhost:3030/users/logout', {
        method: 'get',
        headers: {
            'X-Authorization': userData.token
        }
    });

    localStorage.removeItem('userData');
    window.location = './index.html'
}

async function addCatch(event) {
    event.preventDefault();

    try {
        const formData = new FormData(event.target);
        const data = Array.from(formData.entries()).reduce((acc, [k, v]) => Object.assign(acc, { [k]: v }), {});

        Array.from(addForm.querySelector('fieldset').children).forEach((child) => {
            if (child.tagName === 'INPUT' && child.value.trim() !== '') {
                child.style.borderColor = '';
                child.style.borderWidth = '';
            }
        });

        Array.from(addForm.querySelector('fieldset').children).forEach((child) => {
            if (child.tagName === 'INPUT' && child.value.trim() === '') {
                child.style.borderColor = 'red';
                child.style.borderWidth = '3px';
            }
        });

        Object.values(data).forEach((el) => {
            if (el === '') {
                throw new Error('Please fill all input fields.')
            }
        });

        addForm.reset();

        Array.from(addForm.children).forEach((el) => el.disabled = true);

        const res = await fetch('http://localhost:3030/data/catches', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json',
                'X-Authorization': userData.token
            },
            body: JSON.stringify(data)
        })

        const result = await res.json();
        console.log(result);
        await loadCatches(event);
        Array.from(addForm.children).forEach((el) => el.disabled = false);
    } catch (error) {
        alert(error.message);
    }

}

async function loadCatches(event) {
    event.target.disabled = true;
    document.querySelector('#main legend').textContent = 'Loading catches...'
    catchesDiv.replaceChildren();

    const res = await fetch('http://localhost:3030/data/catches');
    const data = await res.json();

    Object.values(data).forEach((el) => createCatchDiv(el));

    event.target.disabled = false;

    document.querySelector('#main legend').textContent = 'Catches';
    catchesDiv.style.display = 'block';

}


function createCatchDiv(catchObj) {
    const currCatchDiv = createEl('div', { class: 'catch' },

        createEl('label', null, 'Angler'),
        createEl('input', { type: 'text', class: 'angler', value: `${catchObj.angler}` }),
        createEl('label', null, 'Weight'),
        createEl('input', { type: 'text', class: 'weight', value: `${catchObj.weight}` }),
        createEl('label', null, 'Species'),
        createEl('input', { type: 'text', class: 'species', value: `${catchObj.species}` }),
        createEl('label', null, 'Location'),
        createEl('input', { type: 'text', class: 'location', value: `${catchObj.location}` }),
        createEl('label', null, 'Bait'),
        createEl('input', { type: 'text', class: 'bait', value: `${catchObj.bait}` }),
        createEl('label', null, 'Capture Time'),
        createEl('input', { type: 'number', class: 'captureTime', value: `${catchObj.captureTime}` }),
        createEl('button', { class: 'update', 'data-id': `${catchObj._id}` }, 'Update'),
        createEl('button', { class: 'delete', 'data-id': `${catchObj._id}` }, 'Delete')
    )
    if ((userData === null || catchObj._ownerId !== userData.id) === true) {
        Array.from(currCatchDiv.children).forEach((el) => el.disabled = true)
    }
    catchesDiv.appendChild(currCatchDiv);
}

function createEl(type, attributes, ...content) {
    const element = document.createElement(type);

    for (let attribute in attributes) {
        element.setAttribute(attribute, attributes[attribute])
    }

    for (let item of content) {
        if (typeof item === 'string' || typeof item === 'number') {
            item = document.createTextNode(item);
        }

        element.appendChild(item);
    }

    return element;
}