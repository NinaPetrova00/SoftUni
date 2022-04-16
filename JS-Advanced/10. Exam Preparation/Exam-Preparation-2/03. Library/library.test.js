let library = require('./library.js');
const { expect } = require('chai');

describe('Library tests', () => {

    describe('calcPriceOfBook tests', () => {
        // Invalid input tests
        it('Invalid input - name of the book', () => {
            expect(() => library.calcPriceOfBook(1, 2)).to.throw('Invalid input');
        });
        it('Invalid input - year', () => {
            expect(() => library.calcPriceOfBook('1', '2')).to.throw('Invalid input');
        });

        // Valid input tests
        it('Valid data and year is below 1980', () => {
            expect(library.calcPriceOfBook('The Notebook', 1950)).to.equal(`Price of The Notebook is 10.00`);
        });

        it('Valid data and year is 1980', () => {
            expect(library.calcPriceOfBook('The Notebook', 1980)).to.equal(`Price of The Notebook is 10.00`);
        });

        it('Valid data is after 1980', () => {
            expect(library.calcPriceOfBook('The Notebook', 1999)).to.equal(`Price of The Notebook is 20.00`);
        });
    });

    describe('findBook tests', () => {
        // Invalid input tests
        it('Invalid input - booksArr length is zero', () => {
            expect(() => library.findBook([], 'The Notebook')).to.throw('No books currently available');
        });

        // Valid input tests
        it('Valid input - book is found', () => {
            expect(library.findBook(["Troy", "Life Style", "Torronto"], 'Troy')).to.equal('We found the book you want.');
        });
        it('Valid input - book is not found', () => {
            expect(library.findBook(["Troy", "Life Style", "Torronto"], 'The Notebook')).to.equal('The book you are looking for is not here!');
        });
    });

    describe('arrangeTheBooks tests', () => {
        // Invalid input tests
        it('Invalid input - countBooks is string', () => {
            expect(() => library.arrangeTheBooks('12')).to.throw('Invalid input');
        });
        it('Invalid input - countBooks is below zero', () => {
            expect(() => library.arrangeTheBooks(-5)).to.throw('Invalid input');
        });
        it('Invalid input - not enough space for the books', () => {
            expect(library.arrangeTheBooks(50)).to.equal('Insufficient space, more shelves need to be purchased.');
        });

        // Valid input tests
        it('Valid input - enough space for the books', () => {
            expect(library.arrangeTheBooks(30)).to.equal('Great job, the books are arranged.');
        });
        it('Valid input - enough space for the books', () => {
            expect(library.arrangeTheBooks(40)).to.equal('Great job, the books are arranged.');
        })
    });
});