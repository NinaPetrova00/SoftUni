const router = require('express').Router();
const { isEmail } = require('../utils/validators');

const { sessionName } = require('../config/constants');
const authService = require('../services/authService');

router.get('/register', (req, res) => {
    res.render('authentication/register'); // folder authentication, register.hbs
});

router.post('/register', async (req, res, next) => {

    // First way - using validator.js
    // if(!validator.isEmail(req.body.username)){
    //     res.status(404).send('Invalid email!');
    //     return;
    // }

    // Second way- using custom validator ../utils/validators.js
    if (!isEmail(req.body.username)) {
        // res.status(404).send('Invalid email!');
        //return;
        let error = {
            message: 'Invalid email',
            status: 401,
        };

        next(error);
        return;
    }

    try {
        let createdUser = await authService.register(req.body);

        res.redirect('/auth/login');

    } catch (error) {
        // first way
        //next(error);

        //second way
        res.status(401).render('authentication/login', { error: error.message });
    }
});

router.get('/login', (req, res) => {
    res.render('authentication/login');
});

router.post('/login', async (req, res) => {
    try {
        let token = await authService.login(req.body);

        if (!token) {
            res.redirect('/404');
            return;
        }
        res.cookie(sessionName, token, { httpOnly: true });

        res.redirect('/');
    } catch (error) {
        res.status(400).render('authentication/login', { error: error.message });
    }

});

router.get('/logout', (req, res) => {
    res.clearCookie(sessionName);

    res.redirect('/');
});

module.exports = router;