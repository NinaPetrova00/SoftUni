import { clearUserData, setUserData } from '../util.js';
import * as api from './api.js';

const endopoints = {
    login: '/users/login',
    register: '/users/register',
    logout: '/users/logout'
}

export async function login(email, password) {
    const result = await api.post(endopoints.login, { email, password });
    setUserData(result);

    return result;
}

export async function register(email, password) {
    const result = await api.post(endopoints.register, { email, password });
    setUserData(result);

    return result;
}

export async function logout() {
    api.get(endopoints.logout);
    clearUserData();
}