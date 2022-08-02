// import { get  } from "./requester";
import * as request from './requester';

const baseUrl = 'http://localhost:3030/data/games';

export const getAll = () => {
    // return fetch(baseUrl)
    //     .then(res => res.json());

    // using import {get}
    // return get(baseUrl);


    return request.get(baseUrl);
};

export const create = (gameData) => request.post(baseUrl, gameData);

export const getOne = (gameId) =>
    request.get(`${baseUrl}/${gameId}`);

export const edit = (gameId, gameData) =>
    request.put(`${baseUrl}/${gameId}`, gameData);