import authentication from '../services/authService.js';

let sectionElement = undefined;

function initialize(domSelector) {
    sectionElement = document.querySelector(domSelector);
    let loginFormElement = document.querySelector('#login-form');
    loginFormElement.addEventListener('submit', loginFormHandler);
}

function loginFormHandler(e) {
    e.preventDefault();
    let formData = new FormData(e.target);
    let email = formData.get('email');
    let password = formData.get('password');
    let newUser = {
        email,
        password,
    }
    authentication.loginUser(newUser);
    e.target.reset();
}

function getPageHtmlElement() {
    return sectionElement;
}

let loginPage = {
    initialize,
    getPageHtmlElement,
}

export default loginPage;