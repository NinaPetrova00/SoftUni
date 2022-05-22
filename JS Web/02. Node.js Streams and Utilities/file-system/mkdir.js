const fs = require('fs/promises');

// Create a directory
fs.mkdir('./test')
    .then(() => {
        console.log('Created ./test directory!');
    });