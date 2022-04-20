import { showView } from './dom.js';
import { showHome } from './home.js';

const section = document.getElementById('add-movie');
const form = section.querySelector('form');
form.addEventListener('submit', onAdd)
section.remove();

export function showCreate() {
    showView(section);
}

async function onAdd(event) {
    event.preventDefault();
    const formData = new FormData(form);

    const title = formData.get('title').trim();
    const description = formData.get('description').trim();
    const imageUrl = formData.get('imageUrl').trim();

    // if (!title || !description || !imageUrl) {
    //     alert('All fields should be filled!');
    // } else {

        const userData = JSON.parse(sessionStorage.getItem('userData'));
        const res = await fetch('http://localhost:3030/data/movies', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json',
                'X-Authorization': userData.token,
            },
            body: JSON.stringify({ title, description, imageUrl }),
        });

        form.reset();
        showHome();
    //};
};
