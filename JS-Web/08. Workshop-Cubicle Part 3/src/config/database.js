const mongoose = require('mongoose');

const connectionString = 'mongodb://localhost:27017/cubicle';

exports.intiaizeDatabase = () => mongoose.connect(connectionString);