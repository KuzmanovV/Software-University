import { redirectToPage } from './viewChanger.js';
import authentication from './services/authService.js';

let navElement = undefined;

function initialize(domSelector) {
    navElement = document.querySelector(domSelector);
    let allLinkElements = navElement.querySelectorAll('a.link');
    editNav(allLinkElements);
    navElement.addEventListener('click', navHandler);
}

function editNav(elements) {
    if (authentication.isAuthenticated()) {
        elements.forEach(el => {
            if (el.classList.contains('guest')) {
                el.classList.add('hidden');
            }
        })
    } else {
        elements.forEach(el => {
            if (el.classList.contains('authorized')) {
                el.classList.remove('hidden');
            }
        })
    }
}

function navHandler(e) {
    let element = e.target;
    let clickedRoute = element.getAttribute('data-route');
    
    if (clickedRoute !== null) {
        redirectToPage(clickedRoute);
    }
    // if (clickedRoute == 'login' || clickedRoute == 'register') {
    //     let linkElementsToHide = allLinkElements.filter(
    //         el => el.hasAttribute('data-route') == 'login' || el.hasAttribute('data-route') == 'register'
    //     )
        
    // }
}

let nav = {
    initialize,
}

export default nav;