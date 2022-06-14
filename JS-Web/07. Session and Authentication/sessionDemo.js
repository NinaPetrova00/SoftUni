const express = require('express');
const expressSesssion = require('express-session');

const app = express();

app.use(expressSesssion({
    secret: 'keyboard cat',
    resave: false,
    saveUninitialized: true,
    cookie: { secure: false }
}));

app.get('/', (req, res) => {
    req.session.username = 'Ivan ' + Math.random();
    res.send('Home page');
});

app.get('/dogs', (req, res) => {
    console.log(req.session);
    res.send('dogs');
});

app.listen(5000, () => console.log('Server is listening on port 5000...'));