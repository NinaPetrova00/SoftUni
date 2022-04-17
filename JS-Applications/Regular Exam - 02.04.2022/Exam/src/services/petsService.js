import * as request from './requester.js';

const baseUrl = 'http://localhost:3030/data/pets';

///data/pets?sortBy=_createdOn%20desc&distinct=name

export const getAll = () => request.get(`${baseUrl}?sortBy=_createdOn%20desc&distinct=name`);

export const getOne = (petId) => request.get(`${baseUrl}/${petId}`);

export const edit = (petId, petData) => request.put(`${baseUrl}/${petId}`, petData);

export const delPet = (petId) => request.del(`${baseUrl}/${petId}`);

export const create = (petData) => request.post(baseUrl, petData);