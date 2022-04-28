import { page, render } from './lib.js';
import { homePage } from './views/home.js';
// import {catalogPage} from './views/catalog.js';
import {loginPage} from './views/login.js';
import {registerPage} from './views/register.js';
import {createPage} from './views/create.js';
import {detailsPage} from './views/details.js';
import {profilePage} from './views/profile.js';
import {editPage} from './views/edit.js';
import { getUserData } from './util.js';

/*For DEBUGing*/
import * as api from './api/data.js';
window.api = api;

const root = document.querySelector('main');

page(decorateContext);
page('/', homePage);
// page('/memes', catalogPage);
page('/login', loginPage);
page('/register', registerPage);
page('/create', createPage);
page('/details/:id', detailsPage);
page('/edit/:id', editPage);
page('/my-books', profilePage);

page.start();
updateUserNav();
document.getElementById('logoutBtn').addEventListener('click', onLogout);
function onLogout() {
    api.logout();
    updateUserNav();
    page.redirect('/');
}

function decorateContext(ctx, next) {
     ctx.render = (content) => render(content, root);
         ctx.updateUserNav = updateUserNav;
     
     next();
}

function updateUserNav() {
    const userData = getUserData();

    if (userData) {
        document.getElementById('user').style.display = 'block';
        document.getElementById('guest').style.display = 'none';
        document.querySelector('#user span').textContent = `Welcome, ${userData.email}`;
    } else{
        document.getElementById('user').style.display = 'none';
        document.getElementById('guest').style.display = 'block';
    }
}