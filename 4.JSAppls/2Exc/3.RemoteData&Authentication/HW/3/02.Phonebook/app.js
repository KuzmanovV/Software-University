function attachEvents() {
    loadBtn.addEventListener('click', displayPhonebook);
    createBtn.addEventListener('click', addNewPhoneContact);
    ulPhones.addEventListener('click', deleteContact)
    displayPhonebook();
}

const loadBtn = document.getElementById('btnLoad');
const createBtn = document.getElementById('btnCreate');
const personInput = document.getElementById('person');
const phoneInput = document.getElementById('phone');

const ulPhones = document.getElementById('phonebook');
attachEvents();

async function displayPhonebook() {
    const url = 'http://localhost:3030/jsonstore/phonebook';

    const res = await fetch(url);
    const data = await res.json();

    ulPhones.replaceChildren();

    Object.values(data).forEach((el) => {
        const newLi = document.createElement('li');
        const delBtn = document.createElement('button');
        delBtn.textContent = 'Delete';
        delBtn.setAttribute('data-id', `${el._id}`);
        newLi.textContent = `${el.person}: ${el.phone}`;
        newLi.appendChild(delBtn);

        ulPhones.appendChild(newLi);
    })
    return Object.values(data);
}

async function addNewPhoneContact(event) {
    event.target.disabled = true;
    const name = personInput.value;
    const phone = phoneInput.value;


    try {
        if (name.trim() === '' || phone.trim() === '') {
            throw new Error('Please fill all fields!')
        }

        Array.from(ulPhones.children).forEach((li) => {
            const [currName, currPhone] = li.textContent.slice(0, li.textContent.length - 6).split(': ');

            if (currName === name.trim() && currPhone === phone.trim()) {
                throw new Error('There is already a contact with the same name and phone number!')
            }
            if (currName === name.trim()) {
                throw new Error('Name is already present in the phonebook!')
            }

            if (currPhone === phone.trim()) {
                throw new Error('Phone number is already present in the phonebook!')
            }
        });

        personInput.value = '';
        phoneInput.value = '';

        const url = 'http://localhost:3030/jsonstore/phonebook';
        const response = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                person: name.trim(),
                phone: phone.trim()
            })
        });

        const data = await response.json();
        // console.log(data)

        const newLi = document.createElement('li');
        const delBtn = document.createElement('button');
        delBtn.textContent = 'Delete';
        delBtn.setAttribute('data-id', `${data._id}`);
        newLi.textContent = `${name}: ${phone}`;
        newLi.appendChild(delBtn);

        ulPhones.appendChild(newLi);
        event.target.disabled = false;

    } catch (error) {
        alert(error.message);
    }
}

async function deleteContact(event) {
    const id = event.target.dataset.id;
    const name = event.target.parentElement.textContent.split(': ')[0];
    if (id !== undefined) {
        if (window.confirm(`Are you sure you want to remove ${name} from your contacts?`)) {
            const url = `http://localhost:3030/jsonstore/phonebook/${id}`;

            const response = await fetch(url, {
                method: 'delete'
            });

            event.target.parentElement.remove();
            const result = await response.json();

            return result;
        }
    }
}