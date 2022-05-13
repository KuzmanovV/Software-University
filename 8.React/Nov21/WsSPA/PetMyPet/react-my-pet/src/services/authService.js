export const login = (username) => {
    localStorage.setItem('username', username);
}

export const getUser = () => {
    let username = localStorage.getItem('usetrname');

    return username;
}

export const isAuthenticated = () => {
    return Boolean(getUser());
}