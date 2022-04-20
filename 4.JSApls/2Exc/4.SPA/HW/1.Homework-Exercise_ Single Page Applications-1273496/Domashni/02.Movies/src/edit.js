// initialization
// -- find relevant section

import { showView } from './domm.js';
import { showDetails } from './details.js';

// -- detach section from DOM

const section = document.getElementById('edit-movie');
const form = section.querySelector('form');
form.addEventListener('submit', onSubmit);

section.remove();

// display logic

export async function showEdit(id) {
    showView(section);

    const response = await fetch('http://localhost:3030/data/movies/' + id);
    const movie = await response.json();

    section.querySelector('[name="id"]').value = id;
    section.querySelector('[name="title"]').value = movie.title;
    section.querySelector('[name="description"]').value = movie.description;
    section.querySelector('[name="imageUrl"]').value = movie.img;
}

async function onSubmit(e) {
    e.preventDefault();
    const formData = new FormData(e.target);
    const id = formData.get('id');
    const title = formData.get('title').trim();
    const description = formData.get('description').trim();
    const img = formData.get('imageUrl');

    const userData = JSON.parse(sessionStorage.getItem('userData'));
    try {
        const res = await fetch('http://localhost:3030/data/movies/' + id, { 
            method: 'put',
            headers: {
                'Content-Type': 'application/json',
                'X-Authorization': userData.token
            },
            body: JSON.stringify({id, title, description, img })
        });

        if (res.ok != true) {
            const error = await res.json();
            alert(error.message);
        }

        showDetails(id);

    } catch (err) {
        alert(err.message);
    }
}
