const fs = require('fs/promises');

//Rename file or directory
fs.rename('./test', './renamed')
    .then(() => {
        console.log('Renamed directory!');
    });