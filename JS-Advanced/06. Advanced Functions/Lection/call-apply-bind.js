// Call
function introduce(firstName, lastName) {
    console.log(`Hello ${firstName} ${lastName}, my name is ${this.name}`);
}

introduce('Gosho', 'Ivanov'); // global invocation -> undefined

let person = {
    name: 'Pesho'
};

// Call, apply
introduce.call(person, 'Gosho', 'Ivanov'); // invoke using call
introduce.apply(person, ['Gosho', 'Ivanov']); // invoke using apply


// Bind
let superHuman = {
    name: 'Superman'
};

let superIntroduction = introduce.bind(superHuman, 'Louis', 'Lane');
superIntroduction();
// let superIntroduction = introduce.bind(superHuman);
// superIntroduction('Louis', 'Lane');