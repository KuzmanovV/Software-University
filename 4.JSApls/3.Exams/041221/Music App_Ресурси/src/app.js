import { page, render } from './lib.js';
import { getUserData } from './util.js';
import { homePage } from './views/home.js';
import {loginPage} from './views/login.js';
import {registerPage} from './views/register.js';
import {catalogPage} from './views/catalog.js';
import {createPage} from './views/create.js';
import {detailsPage} from './views/details.js';
import {editPage} from './views/edit.js';
import {searchPage} from './views/search.js';

const root = document.querySelector('main');

page(decorateContext);
page('/', homePage);
page('/login', loginPage);
page('/register', registerPage);
page('/catalog', catalogPage);
page('/create', createPage);
page('/details/:id', detailsPage);
page('/edit/:id', editPage);
page('/search', searchPage);

/*For DEBUGing*/
import * as api from './api/data.js';
window.api = api;
page.start();
updateUserNav();

function decorateContext(ctx, next) {
     ctx.render = (content) => render(content, root);
         ctx.updateUserNav = updateUserNav;
     
     next();
}

document.getElementById('logoutBtn').addEventListener('click', onLogout);
function onLogout() {
    api.logout();
    updateUserNav();
    page.redirect('/');
}

function updateUserNav() {
    const userData = getUserData();

    if (userData) {
        document.querySelector('#user').style.display = 'inline';
        document.querySelector('#guest').style.display = 'none';
    } else{
        document.querySelector('#user').style.display = 'none';
        document.querySelector('#guest').style.display = 'inline';
    }
}