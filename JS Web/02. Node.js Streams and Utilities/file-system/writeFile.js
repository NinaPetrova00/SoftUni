const fs = require('fs/promises');

//Write a file

const data = 'Amet consequat id mollit dolor nostrud Lorem nisi nisi dolore. Aliquip nostrud pariatur duis eiusmod occaecat Lorem laboris occaecat esse consectetur duis laborum culpa aliqua. Pariatur veniam occaecat culpa non. Elit elit fugiat ex sit. Non adipisicing irure pariatur laboris. Eu laboris id nulla minim deserunt cupidatat proident eu.';

fs.writeFile('./file-system/text.txt', data, { encoding: 'utf-8' })
    .then(() => {
        console.log('Finish!');
    })
    .catch((err) => {
        console.log('error');
    });