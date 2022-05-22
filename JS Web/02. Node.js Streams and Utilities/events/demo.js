const EventEmitter = require('events');

const eventEmitter = new EventEmitter();

eventEmitter.on('sing', (songTitle) => {
    console.log(`${songTitle} - Lalalalla`);
});

eventEmitter.emit('sing', 'Starboy');