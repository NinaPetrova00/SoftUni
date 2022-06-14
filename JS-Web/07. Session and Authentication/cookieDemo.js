const express = require('express');
const cookieParser = require('cookie-parser');

const app = express();

app.use(cookieParser());

app.get('/', (req, res) => {
    res.cookie('Test Cookie', 'Some test value');
    res.send('Hello World');
});

app.get('/dogs', (req, res) => {
    let cookies = req.cookies;
    console.log(cookies);
    res.send('I love dogs');
});

app.listen(5000, () => console.log('Server is listening on port 5000...'));