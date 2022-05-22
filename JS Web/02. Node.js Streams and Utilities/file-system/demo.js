const fs = require('fs');

// Read file - synchronous
//const text = fs.readFileSync('./file-system/text.txt', { encoding: 'utf-8' });
//console.log(text);

// Read file - asynchronous
fs.readFile('./file-system/text.txt', { encoding: 'utf-8' }, (err, data) => {
    if (err) {
        console.log(err);
        return;
    }

    console.log(data);
});