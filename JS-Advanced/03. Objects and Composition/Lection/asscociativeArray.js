let phoneBook = {
    Ivan: '452555', //не е нужно да пишем кавички за Иван
    'Nina Petrova': '12366', //пишем кавички, ако са 2 имена
    'Georgi Ivanov': '2563663',
};

//Accessing 
console.log(phoneBook['Nina Petrova']);

//Changing
phoneBook['Ivan'] = '0203333';
console.log(phoneBook['Ivan']);

//Iteration - for in
for (key in phoneBook) {
    console.log(`${key} - ${phoneBook[key]}`);
}

//Iteration - methods
let names = Object.keys(phoneBook);
let phones = Object.values(phoneBook);
console.log(names); //returns array with all the keys
console.log(phones); //returns array with all the values

Object.keys(phoneBook).forEach(x => {
    console.log(`${x}-${phoneBook[x]}`);
});

//Entries - used for sorting of object
let entries = Object.entries(phoneBook);
for (const kvp of entries) {
    console.log(kvp);
}