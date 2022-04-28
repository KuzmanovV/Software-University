import { redirectToPage } from '../viewChanger.js';
import { jsonRequest } from "./httpService.js";

let baseUrl = 'http://localhost:3030';

function setToken(token) {
    localStorage.setItem('auth-token', token);
}

function getToken() {
    return localStorage.getItem('auth-token');
}

function isAuthenticated() {
    return Boolean(getToken());
}

function clearStorage() {
    localStorage.clear();
}

function setUserId(id) {
    localStorage.setItem('user-id', id);
}

function getUserId() {
    return localStorage.getItem('user-id');
}

function checkIfPasswordsAreMatching(pass1, pass2) {
    if (pass1 !== pass2) {
        return false;
    }
    return true;
}

function registerUser(userInfo) {
    jsonRequest('POST', `${baseUrl}/users/register`, userInfo)
    .then(userData => {
        if (userData['code']) {
            alert(userData['message']);
            return;
        } 

        let token = userData['accessToken'];
        setToken(token);
        setUserId(userData['_id']);
        redirectToPage('home');
        return;
    })

}

function loginUser(userInfo) {
    jsonRequest('POST', `${baseUrl}/users/login`, userInfo)
    .then(userData => {
        if (userData['code']) {
            alert(userData['message']);
            return;
        } 

        let token = userData['accessToken'];
        setToken(token);
        setUserId(userData['_id']);
        redirectToPage('home');
        return;
    })

}

let authentication = {
    setToken,
    getToken,
    isAuthenticated,
    clearStorage,
    checkIfPasswordsAreMatching,
    setUserId,
    getUserId,
    registerUser,
    loginUser,
}

export default authentication;