const flowerShop = require('./flowerShop.js');
const { expect } = require('chai');

describe('FlowerShop tests', () => {

    describe('calcPriceOfFlowers tests', () => {
        // Invalid input tests
        it('Invalid input - type of flower is a number', () => {
            expect(() => flowerShop.calcPriceOfFlowers(12, 1, 5)).to.throw('Invalid input!');
        });
        it('Invalid input - type of flower is an array', () => {
            expect(() => flowerShop.calcPriceOfFlowers([], 1, 5)).to.throw('Invalid input!');
        });
        it('Invalid input - type of flower is an object', () => {
            expect(() => flowerShop.calcPriceOfFlowers({}, 1, 5)).to.throw('Invalid input!');
        });
        it('Invalid input - price is string', () => {
            expect(() => flowerShop.calcPriceOfFlowers('rose', '1', 5)).to.throw('Invalid input!');
        });
        it('Invalid input - price is decimal', () => {
            expect(() => flowerShop.calcPriceOfFlowers('rose', '1.5', 5)).to.throw('Invalid input!');
        });
        it('Invalid input - quantity is string', () => {
            expect(() => flowerShop.calcPriceOfFlowers('rose', 1, '5')).to.throw('Invalid input!');
        });
        it('Invalid input - quantity is string', () => {
            expect(() => flowerShop.calcPriceOfFlowers('rose', '1', 5.5)).to.throw('Invalid input!');
        });

        // Valid input tests
        it('Valid input - returning rounded result', () => {
            // expect(library.findBook(["Troy", "Life Style", "Torronto"], 'Troy')).to.equal('We found the book you want.');
            expect(flowerShop.calcPriceOfFlowers('rose', 5, 1)).to.equal('You need $5.00 to buy rose!');
        });
    });

    describe('checkFlowersAvailable tests', () => {
        // Invalid input tests
        it('Invalid input - unavailable flowers', () => {
            // expect(() => flowerShop.checkFlowersAvailable(12, 1, 5)).to.throw('Invalid input!');
            expect(flowerShop.checkFlowersAvailable('Lotus', ["Rose", "Lily", "Orchid"])).to.equal('The Lotus are sold! You need to purchase more!');
        });

        // Valid input tests
        it('Valid input - available flowers', () => {
            expect(flowerShop.checkFlowersAvailable('Rose', ["Rose", "Lily", "Orchid"])).to.equal('The Rose are available!');
        });
    });

    describe('sellFlowers tests', () => {
        // Invalid input tests
        it('Invalid input - gardenArr is a string', () => {
            expect(() => flowerShop.sellFlowers('someFlower', 5)).to.throw('Invalid input!');
        });
        it('Invalid input - gardenArr is a number', () => {
            expect(() => flowerShop.sellFlowers(10, 5)).to.throw('Invalid input!');
        });
        it('Invalid input - gardenArr is an object', () => {
            expect(() => flowerShop.sellFlowers({}, 5)).to.throw('Invalid input!');
        });

        it('Invalid input - space is a string', () => {
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], '5')).to.throw('Invalid input!');
        });
        it('Invalid input - space is a decimal', () => {
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 5.5)).to.throw('Invalid input!');
        });
        it('Invalid input - space is below zero', () => {
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], -5)).to.throw('Invalid input!');
        });
        it('Invalid input - space is greater than gardenArr length', () => {
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 5)).to.throw('Invalid input!');
        });
        it('Invalid input - space is equal to gardenArr length', () => {
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 3)).to.throw('Invalid input!');
        });

        // Valid input tests
        it('Valid input - return changed array', () => {
            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 1)).to.equal('Rose / Orchid');
        });
    });
});

// mocha '.\03. Flowers Shop\flowerShop.test.js'