import * as request from './requester.js';
import * as authenticationService from './authenticationService.js';

const baseUrl = 'http://localhost:3030';

export const login = (email, password) =>
    request.post(`${baseUrl}/users/login`, { email, password })
    .then(user => {
        authenticationService.saveUser(user);

        return user;
    });

export const register = (email, password) =>
    request.post(`${baseUrl}/users/register`, { email, password })
    .then(user => {
        authenticationService.saveUser(user);

        return user;
    });

export const logout = () =>
    fetch(`${baseUrl}/users/logout`, {
        headers: { 'X-Authorization': authenticationService.getToken() }
    })
    .then(res => {
        authenticationService.removeUser();
    });