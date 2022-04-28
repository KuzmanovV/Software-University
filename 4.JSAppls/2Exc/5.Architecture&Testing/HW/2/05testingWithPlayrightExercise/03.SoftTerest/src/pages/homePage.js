let sectionElement = undefined;

function initialize(domSelector) {
    sectionElement = document.querySelector(domSelector);
}

function getPageHtmlElement() {
    return sectionElement;
}

let homePage = {
    initialize,
    getPageHtmlElement,
}

export default homePage;