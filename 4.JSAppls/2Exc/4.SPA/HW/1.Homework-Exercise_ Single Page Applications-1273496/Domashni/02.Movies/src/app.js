import { showHome } from './homme.js';
import { showLogin } from './loggin.js';
import { showRegister } from './registter.js';

// create placeholder modules for every view
// configure and test navigation 
// implement modules:
// -- create async function for requests
// -- implement DOM logic

const views = {
    homeLink: showHome,
    loginLink: showLogin,
    registerLink: showRegister  
};

document.getElementById('logoutBtn').addEventListener('click', onLogout);

const nav = document.querySelector('nav');
nav.addEventListener('click', (e) => {
    if(e.target.tagName == 'A') {
        const view = views[e.target.id];
        if (typeof view == 'function') {
            e.preventDefault();
            view();
        }
    }
});

export function updateNav() {
    const userData = JSON.parse(sessionStorage.getItem('userData'));
    if (userData != null) {
        nav.querySelector('#welcomeMsg').textContent = `Welcome, ${userData.email}`;
        [...nav.querySelectorAll('.user')].forEach(e => e.style.display = 'block');
        [...nav.querySelectorAll('.guest')].forEach(e => e.style.display = 'none');
    } else {
        [...nav.querySelectorAll('.user')].forEach(e => e.style.display = 'none');
        [...nav.querySelectorAll('.guest')].forEach(e => e.style.display = 'block');
    }
}

async function onLogout(e) {
    e.preventDefault();
    e.stopImmediatePropagation();

    const {token} = JSON.parse(sessionStorage.getItem('userData'));

    await fetch('http://localhost:3030/users/logout', {
        headers: {
            'X-Authorization': token
        }
    });

    sessionStorage.removeItem('userData');
    updateNav();
    showLogin();
}

updateNav();
showHome();

// order of views:
// -- catalog (home view)
// -- login/register
// -- create
// -- details
// -- likes
// -- edit
// -- delete

// start app in home view catalog
