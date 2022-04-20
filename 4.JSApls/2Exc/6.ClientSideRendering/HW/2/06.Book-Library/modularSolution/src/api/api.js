const host = 'http://localhost:3030';

async function request(url, options) {
    try {
        const response = await fetch(host + url, options);

        if (response.ok !== true) {
            if (response.status === 403) {
                // err will be thrown even tho we got this block
                sessionStorage.removeItem('userData');
            }
            const error = await response.json();
            throw new Error(error.message);
        }

        if (response.status === 204) {
            return response;
        }

        return response.json(); // consumer needs to await it

    } catch (err) {
        alert(err.message);
        throw err;
    }
}

function createOptions(method = 'GET', data) {
    const options = {
        method,
        headers: {}
    };

    if (data !== undefined) {
        options['body'] = JSON.stringify(data);
        options.headers['Content-Type'] = 'application/json';
    }

    const userData = JSON.parse(sessionStorage.getItem('userData'));

    if (userData !== null) {
        options.headers['X-Authorization'] = userData.token;
    }

    return options;
}

export async function get(url) {
    return request(url, createOptions());
}

export async function post(url, data) {
    return request(url, createOptions('POST', data));
}

export async function put(url, data) {
    return request(url, createOptions('PUT', data));
}

export async function del(url) {
    return request(url, createOptions('DELETE'));
}

export async function login(email, password) {
    const response = await post('/users/login', { email, password });

    const userData = {
        email: response.email,
        id: response._id,
        token: response.accessToken,
    };

    sessionStorage.setItem('userData', JSON.stringify(userData));
}

export async function register(email, password) {
    const response = await post('/users/register', { email, password });

    const userData = {
        email: response.email,
        id: response._id,
        token: response.accessToken
    };

    sessionStorage.setItem('userData', JSON.stringify(userData));
}

export async function logout() {
    await get('/users/logout');
    sessionStorage.removeItem('userData');
}