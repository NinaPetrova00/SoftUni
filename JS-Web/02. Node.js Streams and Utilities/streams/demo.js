const fs = require('fs');

// Readable Stream
const readStream = fs.createReadStream('./streams/largeFile.txt', { encoding: 'utf-8', highWaterMark: 10000 });

readStream.on('data', (chunk) => {
    console.log(chunk);
    console.log('-----------------');
});

readStream.on('end', () => {
    console.log('Finished');
});

// Writeable Stream
const writeStream = fs.createWriteStream('./streams/copyFile.txt', { encoding: 'utf-8' });

writeStream.write('Hello World!');
writeStream.write('\n');
writeStream.write('Hello World! 2');

writeStream.on('finish', () => console.log('File is saved!'));

writeStream.end();