import dashboardService from '../services/dashboardService.js';
import { createDashboard } from '../createHtmlElements/createDashboard.js';

let sectionElement = undefined;

function initialize(domSelector) {
    sectionElement = document.querySelector(domSelector);
    uploadPage();
}

function uploadPage() {
    let dashboardExample = sectionElement.querySelector('div.card.overflow-hidden.current-card.details');
    Array.from(sectionElement.children).forEach(el => el.remove());
    dashboardService.getDashboards().then(dashboardsData => {
        Object.values(dashboardsData).forEach(dashboardData => {
            let dashboard = createDashboard(dashboardExample, dashboardData);
            sectionElement.appendChild(dashboard);
        })
    })
}

function getPageHtmlElement() {
    uploadPage();
    return sectionElement;
}

let dashboardPage = {
    initialize,
    getPageHtmlElement,
}

export default dashboardPage;