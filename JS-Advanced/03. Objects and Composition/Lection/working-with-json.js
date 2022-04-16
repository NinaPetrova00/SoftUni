let car = {
    model: 'BMW',
    year: 2010,
    facelift: true
};

// Convert object to JSON
let jsonCar = JSON.stringify(car);
console.log(jsonCar);
console.log(typeof jsonCar);

// Convert JSON to object
let parsedCar = JSON.parse(jsonCar);
console.log(parsedCar);
console.log(typeof parsedCar);
console.log(parsedCar.model);