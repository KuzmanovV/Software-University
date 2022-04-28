document.getElementById('form').addEventListener('submit', onSubmit);

loadStudents();

async function onSubmit(event) {
    event.preventDefault();
    const formData = new FormData(event.target);

    const firstName = formData.get('firstName');
    const lastName = formData.get('lastName');
    const facultyNumber = formData.get('facultyNumber');
    const grade = formData.get('grade');

    if (typeof firstName === 'string' && firstName !== ''
        && typeof lastName === 'string' && lastName !== ''
        && typeof facultyNumber === 'string' && firstName !== '' && typeof Number(facultyNumber) === 'number'
        && typeof firstName === 'number' && firstName !== '') {
        const res = await fetch('http://localhost:3030/jsonstore/collections/students', {
            method: 'post',
            headers: {
                'Content-type': 'aplication/json'
            },
            body: JSON.stringify({ firstName, lastName, facultyNumber, grade })
        });

        event.target.reset();

        loadStudents();
    } else {
        alert('Pls enter valid data!')
    }
}

async function loadStudents() {
    const res = await fetch(`http://localhost:3030/jsonstore/collections/students`);
    const data = await res.json();

    document.querySelector('tbody').replaceChildren(...Object.values(data).map(createItem));
}

function createItem(student) {

    const td1 = document.createElement('td');
    td1.textContent = student.firstName;
    const td2 = document.createElement('td');
    td2.textContent = student.lastName;
    const td3 = document.createElement('td');
    td3.textContent = student.facultyNumber;
    const td4 = document.createElement('td');
    td4.textContent = student.grade;

    const tr = document.createElement('tr');
    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);
    tr.appendChild(td4);

    return tr;
}

