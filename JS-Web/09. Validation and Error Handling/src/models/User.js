const mongoose = require('mongoose');
const bcrypt = require('bcrypt');
const { saltRounds } = require('../config/constants');

const userSchema = new mongoose.Schema({
    username: {
        type: String,
        required: [true, 'Username is required'],
        unique: [true, 'Email should be unique'],
        validate: /[a-zA-Z0-9]/,
        minlength: 5
    },
    password: {
        type: String,
        required: [true, 'Password is required'],
        validate: /[a-zA-Z0-9]/,
        minlength: 8
    }
});

userSchema.virtual('repeatPassword').set(function (value) {
    if (this.password !== value) {
        throw new Error('Repeat password should match password');
    }
});

userSchema.pre('save', function (next) {
    bcrypt.hash(this.password, saltRounds)
        .then(hashedPassword => {
            this.password = hashedPassword;

            next();
        });
});

const User = mongoose.model('User', userSchema);

module.exports = User;