function calc(a, b) {
    return a + b;
}

// Default export
//module.exports = calc;

// Named export
exports.calc = calc;

exports.multiply = (a, b) => {
    return a * b;
};