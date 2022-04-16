const mathEnforcer = require('./04.MathEnforcer.js');
const { assert } = require('chai');

describe('mathEnforcer function tests', () => {
    describe('addFive function tests', () => {
        // Invalid input tests
        it('should return undefined with string', () => {
            assert.equal(mathEnforcer.addFive('test'), undefined);
        });
        it('should return undefined with an array', () => {
            assert.equal(mathEnforcer.addFive([]), undefined);
        });
        it('should return undefined with an object', () => {
            assert.equal(mathEnforcer.addFive({}), undefined);
        });
        it('should return undefined with undefined', () => {
            assert.equal(mathEnforcer.addFive(undefined), undefined);
        });
        it('should return undefined with null', () => {
            assert.equal(mathEnforcer.addFive(null), undefined);
        });

        // Valid input tests
        it('positive integer number +5', () => {
            assert.equal(mathEnforcer.addFive(5), 10);
        });
        it('negative integer number +5', () => {
            assert.equal(mathEnforcer.addFive(-5), 0);
        });
        it('decimal number +5', () => {
            assert.equal(mathEnforcer.addFive(1.1), 6.1);
        });
    });
    describe('subtractTen function tests', () => {
        // Invalid input tests
        it('should return undefined with string', () => {
            assert.equal(mathEnforcer.subtractTen('test'), undefined);
        });
        it('should return undefined with an array', () => {
            assert.equal(mathEnforcer.subtractTen([]), undefined);
        });
        it('should return undefined with an object', () => {
            assert.equal(mathEnforcer.subtractTen({}), undefined);
        });
        it('should return undefined with undefined', () => {
            assert.equal(mathEnforcer.subtractTen(undefined), undefined);
        });
        it('should return undefined with null', () => {
            assert.equal(mathEnforcer.subtractTen(null), undefined);
        });

        // Valid input tests
        it('positive integer number -10', () => {
            assert.equal(mathEnforcer.subtractTen(5), -5);
        });
        it('negative integer number -10', () => {
            assert.equal(mathEnforcer.subtractTen(-5), -15);
        });
        it('decimal number -10', () => {
            assert.equal(mathEnforcer.subtractTen(15.5), 5.5);
        });
    });
    describe('sum function tests', () => {
        // Invalid input tests
        it('first parameter string, second number', () => {
            assert.equal(mathEnforcer.sum('', 20), undefined);
        });
        it('first parameter number, second string', () => {
            assert.equal(mathEnforcer.sum(20, '20'), undefined);
        });

        // Valid input tests
        it('two positive numbers', () => {
            assert.equal(mathEnforcer.sum(10, 5), 15);
        });
        it('two negative numbers', () => {
            assert.equal(mathEnforcer.sum(-10, -5), -15);
        });
        it('two decimal numbers', () => {
            assert.equal(mathEnforcer.sum(10.5, 5.5), 16);
        });
    });
});