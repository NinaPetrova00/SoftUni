class LibraryCollection {

    constructor(capacity) {
        this.capacity = capacity;
        this.books = [];
    }

    //methods
    addBook(bookName, bookAuthor) {

        if (this.capacity <= 0) {
            throw new Error('Not enough space in the collection.');
        } else {
            this.capacity--;

            let newBook = {
                bookName,
                bookAuthor,
                payed: false
            };

            this.books.push(newBook);

            return `The ${bookName}, with an author ${bookAuthor}, collect.`;
        }
    }

    payBook(bookName) {

        if (!this.books.some(x => x.bookName == bookName)) {
            throw new Error(`${bookName} is not in the collection.`);
        } else {
            for (let b of this.books) {
                if (b.bookName == bookName) {
                    if (b.payed === true) {
                        throw new Error(`${bookName} has already been paid.`);
                    } else {
                        b.payed = true;
                        return `${bookName} has been successfully paid.`;
                    }
                }

            }
        }
    };

    removeBook(bookName) {

        if (!this.books.some(x => x.bookName == bookName)) {
            throw new Error("The book, you're looking for, is not found.");
        } else {
            for (let b of this.books) {
                if (b.bookName == bookName) {
                    if (b.payed == false) {
                        throw new Error(`${bookName} need to be paid before removing from the collection.`);
                    } else {
                        this.books.pop();

                        return `${bookName} remove from the collection.`;
                    }
                }
            }
        }
    };

    getStatistics(bookAuthor) {
        let result = [];

        if (bookAuthor == null) {
            let emptySlots = this.capacity;
            result.push(`The book collection has ${emptySlots} empty spots left.`);

            for (let b of this.books) {

                let isPayed = '';
                if (b.payed) {
                    isPayed = 'Has Paid';
                } else {
                    isPayed = 'Not Paid';
                }
                result.push(`${b.bookName} == ${b.bookAuthor} - ${isPayed}.`);
            }

            // this.books.forEach(x => { result.push(`${x.bookName} == ${x.bookAuthor} - ${x.payed}.`) });

            return result.join('\n');
        } else {
            for (let b of this.books) {
                if (b.bookAuthor == bookAuthor) {
                    let isPayed = '';
                    if (b.payed) {
                        isPayed = 'Has Paid';
                    } else {
                        isPayed = 'Not Paid';
                    }

                    return `${b.bookName} == ${b.bookAuthor} - ${isPayed}.`;
                } else {
                    throw new Error(`${bookAuthor} is not in the collection.`);
                }
            }

        }
    };
}
// const library = new LibraryCollection(2)
// console.log(library.addBook('In Search of Lost Time', 'Marcel Proust'));
// console.log(library.addBook('Don Quixote', 'Miguel de Cervantes'));
// console.log(library.addBook('Ulysses', 'James Joyce'));

// const library = new LibraryCollection(2)
// library.addBook('In Search of Lost Time', 'Marcel Proust');
// console.log(library.payBook('In Search of Lost Time'));
// console.log(library.payBook('Don Quixote'));

const library = new LibraryCollection(2)
library.addBook('In Search of Lost Time', 'Marcel Proust');
library.addBook('Don Quixote', 'Miguel de Cervantes');
library.payBook('Don Quixote');
console.log(library.removeBook('Don Quixote'));
console.log(library.removeBook('In Search of Lost Time'));

// const library = new LibraryCollection(2)
// console.log(library.addBook('Don Quixote', 'Miguel de Cervantes'));
// console.log(library.getStatistics('Miguel de Cervantes'));

// const library = new LibraryCollection(5)
// library.addBook('Don Quixote', 'Miguel de Cervantes');
// library.payBook('Don Quixote');
// library.addBook('In Search of Lost Time', 'Marcel Proust');
// library.addBook('Ulysses', 'James Joyce');
// console.log(library.getStatistics());

// Don Quixote remove from the collection.
// In Search of Lost Time need to be paid before removing from the collection.