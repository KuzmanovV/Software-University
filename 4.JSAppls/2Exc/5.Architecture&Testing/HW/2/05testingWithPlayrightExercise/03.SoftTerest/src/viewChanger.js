import homePage from "./pages/homePage.js";
import loginPage from "./pages/loginPage.js";
import authentication from "./services/authService.js";
import dashboardPage from "./pages/dashboardPage.js";
import createIdeaPage from './pages/createIdeaPage.js';
import registerPage from "./pages/registerPage.js";

let allViews = {
    'home': homePage.getPageHtmlElement,
    'login': loginPage.getPageHtmlElement,
    'register': () => registerPage.getPageHtmlElement(),
    'logout': () => {
        if (authentication.isAuthenticated()) {
            authentication.clearStorage(); 
        } else {
            alert('You are not logged in yet!');
        }
        return loginPage.getPageHtmlElement();
    },
    'dashboard': dashboardPage.getPageHtmlElement,
    'create-idea': createIdeaPage.getPageHtmlElement,
}

function clearPage() {
    let mainElement = document.querySelector('main');
    let allDivElements = mainElement.querySelectorAll('div');
    allDivElements.forEach(el => {
        if (el.classList.contains('view')) {
            el.remove();
        }
    });
}

async function redirectToPage(route) {
    clearPage();
    let view = await allViews[route]();
    if (route == 'logout') {
        route = 'login';
    }
    navManipulator(route);
    document.querySelector('main').appendChild(view);
}

function navManipulator(clickedRoute) {
    let navElement = document.getElementById('nav');
    let allLinkElements = navElement.querySelectorAll('a.link');
    Array.from(allLinkElements).forEach(el => el.classList.remove('hidden'));

    if (authentication.isAuthenticated()) {
        hideElements(allLinkElements, 'guest');
        // let elementsToHide = Array.from(allLinkElements).filter(el => el.classList.contains('guest'));
        // elementsToHide.forEach(el => el.classList.add('hidden'));
    } else if (!authentication.isAuthenticated() || clickedRoute === 'logout') {
        hideElements(allLinkElements, 'authorized')
    }

    if (clickedRoute === 'home') {
        return;
    }

    let clickedLinkElement = Array.from(allLinkElements).filter(el => el.getAttribute('data-route') == clickedRoute)[0];
    clickedLinkElement.classList.add('hidden');
}

function hideElements(elements, classToHide) {
    let elementsToHide = Array.from(elements).filter(el => el.classList.contains(classToHide));
    elementsToHide.forEach(el => el.classList.add('hidden'));
}

export {
    redirectToPage,
    clearPage,
}