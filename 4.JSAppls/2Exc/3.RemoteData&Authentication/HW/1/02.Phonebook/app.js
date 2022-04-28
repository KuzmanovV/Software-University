function attachEvents() {
    document.getElementById('btnLoad').addEventListener('click', loadContacts);
    document.getElementById('btnCreate').addEventListener('click', onCreate);
    document.getElementById('phonebook').addEventListener('click', onDelete);
    loadContacts();
}

attachEvents();

const url = `http://localhost:3030/jsonstore/phonebook`;
const list = document.getElementById('phonebook');
const personInput = document.getElementById('person');
const phoneInput = document.getElementById('phone');

async function onDelete(event) {
    const id = event.target.dataset.id;
    if (id) {
        await deleteContact(id);
        event.target.parentElement.remove();
    }
}

async function onCreate() {
    const person = personInput.value;
    const phone = phoneInput.value;
    const contact = {person, phone};
    const result = await createContact(contact);
    list.appendChild(createItem(result));
}

async function loadContacts() {
        const res = await fetch(`http://localhost:3030/jsonstore/phonebook`);
        const data = await res.json();
        list.replaceChildren(...Object.values(data).map(createItem));
}

function createItem(contact) {
    
    const btn = document.createElement('button');
    btn.textContent = 'Delete';
    btn.setAttribute('data-id', contact._id);
    
    const li = document.createElement('li');
    li.textContent = `${contact.person}: ${contact.phone}`;
    li.appendChild(btn);

    //li.innerHTML = `${contact.person}: ${contact.phone} <button data-id = ${contact._id}>Delete</button>`;
    return li;
}

async function createContact(contact) {
        const res = await fetch(url, {
            method: 'post',
            headers: {
                'Content-type': 'aplication/json'
            },
            body: JSON.stringify(contact)
        });
        return await res.json();
}

async function deleteContact(id) {
        const res = await fetch(url+'/'+id, {
            method: 'delete'
        });
        return await res.json();
}