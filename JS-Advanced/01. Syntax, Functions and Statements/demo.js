// let firstName = 'Nina';
// const age = 21;
// console.log(firstName + ' ' + age);

//Function declaration
function printFullName(firstName, lastName) {
    console.log(firstName + ' ' + lastName)
}

//Function Invocation
printFullName('Nina', 'Petrova');

//Function expression
let countDown = function(number = 10) {
    for (let i = number; i > 0; i--) {
        console.log(i);
    }
}

countDown(10);

//Arrow function
let countUp = (max) => {
    for (let i = 0; i < max; i++) {
        console.log(i);
    }
};
countUp(10);

//Return value
function sum(a, b) {
    return a + b;
}
let result = sum(5, 10);
console.log(result);

let sumArrow = (a, b) => a + b;
let resultArrow = sumArrow(10, 20);
console.log(resultArrow);

//Methods:
let firstName = 'Nina';
console.log(firstName.toUpperCase());
console.log(Math.PI);