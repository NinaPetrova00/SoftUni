const jwt = require('jsonwebtoken');
const bcrypt = require('bcrypt');
const { secret, saltRounds } = require('../config/constants');

const User = require('../models/User');

exports.register = async ({ username, password, repeatPassword }) => {
    // User.create(userData)

    //if (password !== repeatPassword) {
    //     return false;
    // } 
    //let hashedPass = await bcrypt.hash(password, saltRounds);

    // let createdUser = User.create({
    //     username: username,
    //     password: hashedPass
    // });


    let createdUser = await User.create({
        username,
        password,
        repeatPassword,
    });
    return createdUser;

};

exports.login = async ({ username, password }) => {
    let user = await User.findOne({ username });

    // check if there is user with a password
    if (!user) {
        return;
    }

    const isValid = await bcrypt.compare(password, user.password);

    if (!isValid) {
        throw {
            message: 'Invalid username or password'
        };
    }

    let result = new Promise((resolve, reject) => {
        jwt.sign({ _id: user._id, username: user.username }, secret, { expiresIn: '2d' }, (err, token) => {

            if (err) {
                return reject(err);
            }

            resolve(token);
        });
    });

    return result;
};
