// function rotateArray(arr, rotations) {

//     for (let i = 0; i < rotations; i++) {
//         let lastElement = arr.pop();
//         arr.unshift(lastElement);
//     }

//     console.log(arr.join(' '));
// }

// rotateArray(['1', '2', '3', '4'], 2);
// rotateArray(['Banana', 'Orange', 'Coconut', 'Apple'], 15);




// Filter
let cars = ['Opel', 'Reanut', 'Audi', 'Lada', 'Ford'];
let fourLetterCars = cars.filter(car => car.length == 4);
console.log('\nOriginal arr:');
console.log(cars);
console.log('Filtered arr:');
console.log(fourLetterCars);

// Map
let numbers = [1, 2, 3, 4, 5];
let mapedNumbers = numbers.map(num => num * 2);
console.log('\nOriginal arr:');
console.log(numbers);
console.log('Mapped arr:');
console.log(mapedNumbers);

// Reduce
let sum = numbers.reduce((accumulator, num) => {
    return accumulator + num;
}, 0);
console.log('\nOriginal arr:');
console.log(numbers);
console.log('Reduced arr:');
console.log(sum);