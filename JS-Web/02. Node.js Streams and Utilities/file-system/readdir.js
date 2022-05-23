const fs = require('fs');

// List files in a directory
fs.readdir('.', (err, data) => {
    if (err) {
        return;
    }

    console.log(data);
});

fs.readdir('./file-system', (err, data) => {
    if (err) {
        return;
    }

    console.log(data);
});