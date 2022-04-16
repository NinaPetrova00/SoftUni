let car = {
    model: 'BMW',
    year: 2010,
    facelift: true,
    honk: function() {
        console.log(`${this.model}: Beep beep!`);
    },
};

car.honk();
car.model = 'Mercedess';
car.honk();

//Change execution context
let singleHonk = car.honk; //сочи към референцията на функцията
singleHonk();

let otherCar = {
    model: 'Ford'
}

otherCar.bibitka = car.honk;
otherCar.bibitka();