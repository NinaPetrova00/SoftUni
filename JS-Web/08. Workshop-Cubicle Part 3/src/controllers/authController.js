const router = require('express').Router();

const { sessionName } = require('../config/constants');
const authService = require('../services/authService');

router.get('/register', (req, res) => {
    res.render('authentication/register'); // folder authentication, register.hbs
});

router.post('/register', async (req, res) => {

    let createdUser = await authService.register(req.body);

    if (createdUser) {
        res.redirect('/auth/login');
    } else {
        // res.redirect('404');
        res.redirect('404');
    }
});

router.get('/login', (req, res) => {
    res.render('authentication/login');
});

router.post('/login', async (req, res) => {
    let token = await authService.login(req.body);

    if (!token) {
        res.redirect('/404');
        return;
    }

    res.cookie(sessionName, token, { httpOnly: true });

    res.redirect('/');
});

router.get('/logout', (req, res) => {
    res.clearCookie(sessionName);

    res.redirect('/');
});

module.exports = router;