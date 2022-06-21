exports.errorHandler = (err, req, res, next) => {
    const status = err.status || 404; // pass it in authController or set it to 404

    const errorMessage = err.message || 'Something went wrong!';

    //res.status(404).render('404', { error: err.message });
    res.status(status).render('404', { error: errorMessage });
};