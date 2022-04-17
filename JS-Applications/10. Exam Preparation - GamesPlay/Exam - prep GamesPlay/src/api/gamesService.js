import * as api from './api.js';

const endopoints = {
    recent: '/data/games?sortBy=_createdOn%20desc&distinct=category', //home
    games: '/data/games?sortBy=_createdOn%20desc', //catalog
    create: '/data/games',
    byId: '/data/games/',
    deleteById: '/data/games/',
    update: '/data/games/'
};

export async function getRecent() {
    return api.get(endopoints.recent);
}

export async function getAll() {
    return api.get(endopoints.games);
}

export async function getById(id) {
    return api.get(endopoints.byId + id);
}

export async function create(data) {
    return api.post(endopoints.create, data);
}

export async function update(id, data) {
    return api.put(endopoints.update, data);
}

export async function deleteById(id) {
    return api.del(endopoints.deleteById + id);
}