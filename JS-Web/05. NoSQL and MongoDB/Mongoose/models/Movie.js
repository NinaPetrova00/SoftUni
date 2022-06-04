const mongoose = require('mongoose');

//function constructor
const movieSchema = new mongoose.Schema({
    name: {
        type: String,
        required: [true, 'Movie name is required!'],
        minlength: 2,
    },
    description: String,
    genre: {
        type: String,
        enum: ['action', 'fantasy', 'comedy', 'thriller', 'romance'],
    },
    imageUrl: String,
    year: {
        type: Number,
        min: [2012, 'The year {VALUE} is lower than be higher than 2012'],
    }
});

// First way
// movieSchema.method('getInfo', function() {
//     return `${this.name} -  ${this.description || 'n/a'}`;
// });

// Second way
movieSchema.methods.getInfo = function() {
    return `${this.name} - ${this.description || 'n/a'}`;
};

movieSchema.virtual('isNewMovie')
    .get(function() {
        return this.year >= 2020;
    });

movieSchema.path('name').validate(function() {
    return this.name.length >= 2 && this.name.length <= 20;
}, `This movie name should be more than 2 characters and less than 20.`);

//Model:
// factory function
const Movie = mongoose.model('Movie', movieSchema);

exports.Movie = Movie;
//module.exports = Movie;