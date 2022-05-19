// Default export
//const calc = require('./calc');

// Named export 
const { calc, multiply } = require('./calc');

function init() {
    let result = calc(2, 3);

    console.log(result);
}

init();