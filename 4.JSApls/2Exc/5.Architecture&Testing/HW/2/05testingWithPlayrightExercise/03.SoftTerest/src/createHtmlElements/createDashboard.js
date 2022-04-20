function createDashboard(dashboardExample, dashboardObj) {
    let dashboardDivElement = dashboardExample.cloneNode(true);
    let pElement = dashboardDivElement.querySelector('p');
    pElement.textContent = dashboardObj['title'];
    let imgElement = dashboardDivElement.querySelector('img');
    imgElement.removeAttribute('src');
    imgElement.setAttribute('src', dashboardObj['img']);
    return dashboardDivElement;
}

export {
    createDashboard,
}