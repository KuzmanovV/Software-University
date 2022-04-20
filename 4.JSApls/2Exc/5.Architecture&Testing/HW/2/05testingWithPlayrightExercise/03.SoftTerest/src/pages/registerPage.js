import authentication from '../services/authService.js';

let sectionElement = undefined;

function initialize(domSelector) {
    sectionElement = document.querySelector(domSelector);
    let registerFormElement = document.querySelector('#register-form');
    registerFormElement.addEventListener('submit', registerFormHandler);
}

function registerFormHandler(e) {
    e.preventDefault();
    let formData = new FormData(e.target);
    let email = formData.get('email');
    let password = formData.get('password');
    let repeatedPassword = formData.get('repeatPassword');
    
    if (!authentication.checkIfPasswordsAreMatching(password, repeatedPassword)) {
        alert('Passwords must match!');
        return;
    }

    let newUser = {
        email,
        password,
    }
    authentication.registerUser(newUser);
    e.target.reset();
}

function getPageHtmlElement() {
    return sectionElement;
}

let registerPage = {
    initialize,
    getPageHtmlElement,
}

export default registerPage;