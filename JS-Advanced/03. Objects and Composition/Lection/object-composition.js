let car = {
    model: 'BMW',
    year: 2010,
    facelift: true,
    honk: function() {
        console.log(`${this.model}: Beep beep!`);
    },
    owner: {
        name: 'Pesho',
        age: 30,
        hobbies: [
            'swimming',
            'tennis',
        ]
    }
};
console.log(car.owner.name);


//Nested Destructuring
let { owner: { name } } = car;

//Renaming in destructuring
let { owner: person } = car;
console.log(person);