window.addEventListener('load', onLoad);

const tbody = document.querySelector('#results tbody');
const form = document.getElementById('form');
form.addEventListener('submit', submitStudent);

async function onLoad() {
    const response = await fetch('http://localhost:3030/jsonstore/collections/students');

    const data = await response.json();

    // console.log(Object.values(data));

    Object.values(data).forEach(student => populateTable(student));

    // return Object.values(data);
}

async function submitStudent(event) {

    event.preventDefault();
    const form = event.target;
    const formData = new FormData(form);

    const firstName = formData.get('firstName').trim();
    const lastName = formData.get('lastName').trim();
    const facultyNumber = formData.get('facultyNumber').trim();
    const grade = formData.get('grade').trim();

    ///    >>>>> OPTIONAL FUNCTIONALITY THAT CHECKS THE DATABASE WHETHER SOMEONE ELSE HAS SUBMITED STUDENT WITH SAME FACULTY NUMBER <<<<<
    
    /*async function checkDataBase() {
        const url = 'http://localhost:3030/jsonstore/collections/students';
        const response = await fetch (url);
    
        const data = await response.json();
    
        return Object.values(data).forEach(student => {
            if (student.facultyNumber === facultyNumber) {
                form.reset();
                throw new Error('The student has already been added to the list by someone else, refresh page.')
            }
        })
        // console.log(Object.values(data));
    }*/

    try {
        if (firstName === '' || lastName === '' || facultyNumber === '' || grade === '') {
            throw new Error('Please fill all fields.')
        }

        if (Number(grade) < 2 || Number(grade) > 6) {
            throw new Error('Grade must be in the interval between 2(included) and 6(included)!');
        }

        /*    >>>>> OPTIONAL FUNCTIONALITY <<<<< */

        // await checkDataBase();

        if (Number.isNaN(Number(facultyNumber))) {
            throw new Error ('Faculty number must be a number!')
        }

        // on second try with different facNum the highlighted cell background will be restored
        Array.from(tbody.children).forEach((row) => {
            row.children[2].style.backgroundColor = 'initial';
        })
        // check if there is already a student in our list with the same faculty number, higlights it and alerts us
        Array.from(tbody.children).forEach(row => {
            row.children[2].style.backgroundColor = 'initial'; 
            if (facultyNumber === row.children[2].textContent) {
                row.children[2].style.backgroundColor = 'orange'; // highlights the existing facNum's td tag
                throw new Error('Faculty Number is already present in the list!');
            }
        });

        
    } catch (error) {
        alert(error.message);
        return;
    }

    await onSubmit({
        firstName,
        lastName,
        facultyNumber,
        grade
    });
}

async function onSubmit(studentObj) {
    form.reset();
    const url = 'http://localhost:3030/jsonstore/collections/students';

    const response = await fetch(url, {
        method: 'post',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(studentObj)
    });

    const data = await response.json();
    populateTable(studentObj);
    return data;
}

function populateTable(studentObj) {
    const newRow = document.createElement('tr');

    const firstNameTd = document.createElement('td');
    firstNameTd.textContent = studentObj.firstName;

    const lastNameTd = document.createElement('td');
    lastNameTd.textContent = studentObj.lastName;

    const facultyNumTd = document.createElement('td');
    facultyNumTd.textContent = studentObj.facultyNumber;

    const gradeTd = document.createElement('td');
    gradeTd.textContent = studentObj.grade;

    newRow.appendChild(firstNameTd);
    newRow.appendChild(lastNameTd);
    newRow.appendChild(facultyNumTd);
    newRow.appendChild(gradeTd);

    tbody.appendChild(newRow)
}