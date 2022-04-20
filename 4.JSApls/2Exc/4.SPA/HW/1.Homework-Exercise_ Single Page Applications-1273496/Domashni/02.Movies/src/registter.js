// initialization
// -- find relevant section

import { updateNav } from './app.js';
import { showView } from './domm.js';
import { showHome } from './homme.js';

// -- detach section from DOM

const section = document.getElementById('form-sign-up');
const form = section.querySelector('form');
form.addEventListener('submit', onRegister);
section.remove();

// display logic

export function showRegister() {
    showView(section);
}

async function onRegister(e) {
    e.preventDefault();
    
    const formData = new FormData(form);
    const email = formData.get('email').trim();
    const password = formData.get('password').trim();
    const repassword = formData.get('repeatPassword').trim();

    try {
        if (password != repassword) {
            alert('Passwords don\'t match!');
            return;
        }
        if (email == '' && password == '') {
            throw new Error('All field must be filled!');
        }

        const res = await fetch('http://localhost:3030/users/register', { 
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({email, password})
        });

        if (res.ok != true) {
            const error = await res.json();
            return alert(error.message);
        }

        const data = await res.json();
        const userData = {
            email: data.email,
            id: data._id,
            token: data.accessToken
        };
        sessionStorage.setItem('userData', JSON.stringify(userData));

        e.target.reset();
        alert('Registered successfully!');
        showHome();
        updateNav();

    } catch (err) {
        alert(err.message);
    }
}