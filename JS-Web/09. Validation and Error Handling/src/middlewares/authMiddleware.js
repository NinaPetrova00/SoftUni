const jwt = require('jsonwebtoken');
const { promisify } = require('util');
const { secret, sessionName } = require('../config/constants');

const jwtVerify = promisify(jwt.verify);

exports.auth = async (req, res, next) => {
    let token = req.cookies[sessionName];

    if (token) {
        try {
            let decodedToken = await jwtVerify(token, secret);

            req.user = decodedToken;

            res.locals.user = decodedToken;
        } catch (err) {
            console.log(err);

            res.redirect('/404');
            return;
        }
    }

    next();
};

exports.isAuth = (req, res, next) => {
    if (!req.user) {
        res.redirect('/404');
        return;
    }
    next();
}