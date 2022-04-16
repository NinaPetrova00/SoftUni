//dynamic assing of properties
let cat = {};
let propName = 'age';
cat['fur-color'] = 'white';
cat.breed = 'Persian'
cat[propName] = 7;

console.log(cat);

// object propety access
console.log(cat.age);
console.log(cat['fur-color']);
console.log(cat[propName]);

//object destrucuting assingment syntax
let { age, breed, ...rest } = cat;
console.log(age);
console.log();

//Clone objects - first way
let {...clonedCat } = cat;

console.log(clonedCat.name);
clonedCat.name = 'Garry';
console.log(cat.name);

//object references
let otherCat = cat;
otherCat.name = 'Gosho';

console.log(otherCat.name);
console.log(cat.name);

// Compairing objects
let person = { name: 'Pesho' };
let person2 = { name: 'Pesho' };
console.log(person == person2);