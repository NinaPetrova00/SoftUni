let car = {
    model: 'BMW',
    year: 2010,
    facelift: true,
    honk: function() { //Method with function expression
        console.log('Beep beep!');
    },
    honk2: () => { //Method with arrow function expression
        console.log('Beep beep2!');
    },
    honk3() { //Object method notation
        console.log('Beep beep3!');
    }
}

car.honk();
car.honk2();
car.honk3();


//Object as function library
function division(a, b) { //function declaration
    return a / b;
}
let calculator = {
    sum: function(a, b) {
        return a + b;
    },
    multiplication: (a, b) => a * b,
    subtraction(a, b) {
        return a - b;
    },
    division
};
console.log(calculator.sum(10, 15));