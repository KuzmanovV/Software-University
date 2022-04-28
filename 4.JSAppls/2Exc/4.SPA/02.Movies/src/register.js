import { showView } from './dom.js';
import { updateNav } from './app.js';
import { showHome } from './home.js';

const section = document.getElementById('form-sign-up');
section.remove();

export function showRegister() {
    showView(section);
}

const form = section.querySelector('form');
form.addEventListener('submit', onRegister)

async function onRegister(event) {
    event.preventDefault();
    const formData = new FormData(form);

    const email = formData.get('email').trim();
    const password = formData.get('password').trim();
    const repPassword = formData.get('repeatPassword').trim();

    if (!email) {
        alert('Email should be filled!');
    } else if (email.length<6) {
        alert('Email should be at least 6 characters long.');
    } else if (password != repPassword) {
        alert('Difference in password! Please try again.');
    } else {

        const res = await fetch('http://localhost:3030/users/register', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ email, password }),
        });

        const data = await res.json();
        sessionStorage.setItem('userData', JSON.stringify({
            email: data.email,
            id: data._id,
            token: data.accessToken
        }));
        form.reset();
        updateNav();
        showHome();
    };
};