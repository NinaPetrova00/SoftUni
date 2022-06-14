const express = require('express');
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');

const app = express();
const hashedPassword = '$2b$10$RxNgYg2waoXvs3cSJC4WzOyml2dxn1b7taL6.Prvko6rVxjx6DaZ6';
const saltRounds = 10;
const secret = 'MySuperSecretSecret';

app.get('/hash/:password?', async(req, res) => {
    const salt = await bcrypt.genSalt(saltRounds);
    const hash = await bcrypt.hash(req.params.password, salt);
    console.log('Salt: ', salt);
    console.log('Hash: ', hash);
    res.send(hash);
});

// mysecretpassword is the right password
app.get('/login/:password', async(req, res) => {
    const isValidPassword = await bcrypt.compare(req.params.password, hashedPassword);

    if (isValidPassword) {

        const payload = {
            username: 'Ivan'
        };

        const options = { expiresIn: '2d' };

        const token = jwt.sign(payload, secret, options)

        res.send(token);
    } else {
        res.send('Invalid Password')
    }
});

//eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6Ikl2YW4iLCJpYXQiOjE2NTUxMjkzMDgsImV4cCI6MTY1NTMwMjEwOH0.1Ohkqz8WDXyXY3PW7SoIHWCuzKww8cXdfvpVEDRDFfA
app.get('/verify/:token', (req, res) => {

    jwt.verify(req.params.token, secret, (err, decodedToken) => {
        if (err) {
            return res.status(401).send('You do not have permissions!');
        }
        res.json(decodedToken);
        //this method will return: {"username":"Ivan","iat":1655129308,"exp":1655302108}
    });
});


app.listen(5000, () => console.log('Server is listening on port 5000...'));