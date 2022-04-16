class Cat {

    constructor(name) {
        this.name = name;
    }

    makeSound() {
        console.log(`${this.name}: Meow!`);
    }
}

// First example
let firstCat = new Cat('Puhi');
let secondCat = new Cat('Tom');

// console.log(firstCat);
// console.log(secondCat);

// secondCat.name = 'Mishi';
// console.log(secondCat);

// Second example
let catNames = [
    'Puhi',
    'Tom',
    'Mishi',
    'Zuzi',
];

let cats = catNames.map(x => new Cat(x));
console.log(cats);

cats.forEach(x => x.makeSound());