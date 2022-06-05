const router = require('express').Router();
const { Movie } = require('../models/Movie');

router.get('/', async(req, res) => {
    const movies = await Movie.find().lean();
    res.render('movies', { movies });

    // moviesResult.forEach(movie => {
    //     console.log(movie.getInfo());
    //     console.log(movie.isNewMovie);
    // });
    //   res.render('movies', { movies: [] });
});

router.get('/create', (req, res) => {
    res.render('createMovie');
});

router.post('/create', async(req, res) => {
    console.log(req.body);

    // First way to create db document
    // const movie = new Movie(req.body);
    // let savedMovie = await movie.save();

    // Second way to create db document
    let savedMovie = await Movie.create(req.body);

    console.log(savedMovie);
    res.redirect('/movies');
});

router.get('/:movieId', async(req, res) => {
    // let movie = await Movie.findOne({ _id: req.params.movieId }).lean();
    let movie = await Movie.findById(req.params.movieId).lean();

    res.render('movieDetails', { movie });
});

module.exports = router;
