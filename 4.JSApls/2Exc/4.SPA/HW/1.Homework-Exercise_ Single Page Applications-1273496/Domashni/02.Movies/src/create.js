// initialization
// -- find relevant section

import { showView } from './domm.js';
import { showDetails } from './details.js';

// -- detach section from DOM

const section = document.getElementById('add-movie');
const form = section.querySelector('form').addEventListener('submit', onSubmit);

section.remove();

// display logic

export function showCreate() {
    showView(section);
}

async function onSubmit(e) {
    e.preventDefault();
    const formData = new FormData(e.target);
    
    const title =  formData.get('title').trim();
    const description = formData.get('description').trim();
    const img = formData.get('imageUrl');

    const userData = JSON.parse(sessionStorage.getItem('userData'));

    if (title == '' || description == '' || img == '') {
        throw new Error('All field must be filled!');
    };

    const res = await fetch('http://localhost:3030/data/movies', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization': userData.token
        },
        body: JSON.stringify({title, description, img})
    });

    if (res.ok != true) {
        const error = await res.json();
        alert(error.message);
    }

    const movie = await res.json();
    showDetails(movie._id);

}