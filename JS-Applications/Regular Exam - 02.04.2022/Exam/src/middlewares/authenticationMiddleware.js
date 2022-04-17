import * as authenticationService from '../services/authenticationService.js';

export const authenticationMiddleware = (context, next) => {

    context.user = authenticationService.getUser();

    next();
};