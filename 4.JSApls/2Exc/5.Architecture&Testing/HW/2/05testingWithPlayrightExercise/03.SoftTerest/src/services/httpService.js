import authentication from "./authService.js";

function jsonRequest(requestMethod, url, element, authRequest) {
    let fetchBody = {
        method: requestMethod.toUpperCase(),
        headers: {
            'Content-Type': 'application/json',
        },
        body: undefined,
    }

    if (authRequest === true) {
        fetchBody['headers']['X-Authorization'] = authentication.getToken()
    } 

    if (element !== undefined) {
        fetchBody['body'] = JSON.stringify(element);
    }

    return fetch(url, fetchBody)
    .then(body => body.json());
}

export { jsonRequest };