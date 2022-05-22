const fs = require('fs');
const zlib = require('zlib');

const readStream = fs.createReadStream('./streams/largeFile.txt', { encoding: 'utf-8' });
const writeStream = fs.createWriteStream('./streams/copyFile.txt', { encoding: 'utf-8' });

const gzip = zlib.createGzip();

// First way
readStream.on('data', (chunk) => {
    writeStream.write(chunk);
});

readStream.on('end', () => {
    writeStream.end();
    console.log('Finished');
});

// Second way 
readStream.pipe(writeStream);

// Third way
readStream.pipe(gzip).pipe(writeStream);

writeStream.on('finish', () => console.log('File is saved!'));