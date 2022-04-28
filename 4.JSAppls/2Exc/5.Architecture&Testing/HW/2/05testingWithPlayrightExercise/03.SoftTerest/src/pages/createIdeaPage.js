import dashboardService from '../services/dashboardService.js';
import { redirectToPage } from '../viewChanger.js';

let sectionElement = undefined;

function initialize(domSelector) {
    sectionElement = document.querySelector(domSelector);
    let formElement = sectionElement.querySelector('#create-idea-form');
    formElement.addEventListener('submit', createIdeaHandler);
}

function createIdeaHandler(e) {
    e.preventDefault();
    let formData = new FormData(e.target);
    let newDashboardInfo = {
        title: formData.get('title'),
        description: formData.get('description'),
        imageUrl: formData.get('imageURL'),
    }

    dashboardService.createDashboard(newDashboardInfo).then(info => {
        redirectToPage('dashboard');
    })
}

function getPageHtmlElement() {
    return sectionElement;
}

let createIdeaPage = {
    initialize,
    getPageHtmlElement,
}

export default createIdeaPage;