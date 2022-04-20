// This file will be initializing pages saved by reference from separated modules for every page
import registerPage from "./src/pages/registerPage.js";
import homePage from "./src/pages/homePage.js";
import loginPage from "./src/pages/loginPage.js";
import { redirectToPage } from "./src/viewChanger.js";
import dashboardPage from "./src/pages/dashboardPage.js";
import createIdeaPage from "./src/pages/createIdeaPage.js";
import nav from "./src/nav.js";

setup();

function setup() {
    registerPage.initialize('#page-register');
    homePage.initialize('#home-page');
    loginPage.initialize('#page-login');
    dashboardPage.initialize('#dashboard-holder');
    createIdeaPage.initialize('#create-idea-page');
    nav.initialize('#nav');
    redirectToPage('home');
}

