import { jsonRequest } from "./httpService.js";

function getDashboards() {
    return jsonRequest('GET', 'http://localhost:3030/data/ideas?select=_id%2Ctitle%2Cimg&sortBy=_createdOn%20desc');
}

function createDashboard(body) {
    return jsonRequest('POST', 'http://localhost:3030/data/ideas', body, true);
}


let dashboardService = {
    getDashboards,
    createDashboard,
}

export default dashboardService;