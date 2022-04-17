export function getUserData() {
    return JSON.parse(localStorage.getItem('user'));
}

export function getAccessToken() {
    const user = getUserData();

    if (user) {
        return user.accessToken;
    } else {
        return null;
    }
}

export function clearUserData() {
    localStorage.removeItem('user');
}

export function setUserData(data) {
    localStorage.setItem('user', JSON.stringify(data));
}

export function createSubmitHandler(context, handler) {
    return function(ev) {
        ev.preventDefault();

        const formData = Object.fromEntries(new FormData(ev.target));

        handler(context, formData, ev);
    };
}

export function parseQuerystring(query = '') {
    return Object.fromEntries(query
        .split('&')
        .map(kvp => kvp.split('=')));
}