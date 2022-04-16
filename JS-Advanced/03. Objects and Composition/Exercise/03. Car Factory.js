function carFactory(input) {

    let resultCar = {};
    let engine = {};
    let carriage = {};

    resultCar.model = input.model;

    if (input.power <= 90) {
        engine.power = 90;
        engine.volume = 1800;
    } else if (input.power <= 120) {
        engine.power = 120;
        engine.volume = 2400;
    } else if (input.power <= 200) {
        engine.power = 200;
        engine.volume = 3500;
    }

    carriage.type = input.carriage;
    carriage.color = input.color;

    resultCar.engine = engine;
    resultCar.carriage = carriage;

    if (input.wheelsize % 2 === 0) {
        input.wheelsize--;
    }

    resultCar.wheels = [input.wheelsize, input.wheelsize, input.wheelsize, input.wheelsize];
    return resultCar;

}
carFactory({ model: 'VW Golf II', power: 90, color: 'blue', carriage: 'hatchback', wheelsize: 14 });