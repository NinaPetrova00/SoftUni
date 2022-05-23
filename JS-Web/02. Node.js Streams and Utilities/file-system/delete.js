const fs = require('fs/promises');

//Delete file
fs.unlink('./file-system/text.txt')
    .then(() => {
        console.log('text.txt deleted!');
    });