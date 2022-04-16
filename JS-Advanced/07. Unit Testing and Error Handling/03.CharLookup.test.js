const lookupChar = require('./03.CharLookup.js');
const { assert } = require('chai');

describe('lookupChar function tests', () => {

    // Valid input tests
    it('return char at index', () => {
        assert(lookupChar('Love', 1) === 'o');
    });

    it('return char at index', () => {
        assert(lookupChar('L', 0) === 'L');
    });

    // Invalid input tests 
    it('index over the string lenght', () => {
        assert(lookupChar('Love', 10) === 'Incorrect index');
    });

    it('negative string index', () => {
        assert(lookupChar('Love', -10) === 'Incorrect index');
    });

    it('empty string as input', () => {
        assert(lookupChar('', 0) === 'Incorrect index');
    });

    it('return undefined if first parameter is not string', () => {
        assert(lookupChar(100, 10) === undefined);
    });

    it('return undefined if second parameter is not integer', () => {
        assert(lookupChar('Love', 10.5) === undefined);
    });

    it('return undefined with wrong parameters type', () => {
        assert(lookupChar(100, '10.5') === undefined);
    });
});