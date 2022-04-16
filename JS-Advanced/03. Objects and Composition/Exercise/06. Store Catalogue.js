// First way
// function storeCatalogue(arr) {

//     let result = arr.sort((a, b) => a.localeCompare(b));

//     let currentRow = [];
//     let firstChar = '';

//     for (let i = 0; i < result.length; i++) {
//         currentRow = result[i].split(' : ');

//         if (result[i][0] !== firstChar) {
//             console.log(result[i][0]);
//         }
//         console.log(`${currentRow[0]}: ${currentRow[1]}`);

//         firstChar = result[i][0];
//     }
// }

// Second way
function storeCatalogue(arr) {

    let result = arr.sort((a, b) => a.localeCompare(b));

    let current = [];
    let firstChar = '';
    let obj = {};

    for (let i = 0; i < result.length; i++) {

        let [product, price] = result[i].split(' : ');

        obj[product] = price;

        if (result[i][0] !== firstChar) {
            console.log(result[i][0]);
        }

        console.log(`${product}: ${obj[product]}`);

        firstChar = result[i][0];
    }

}

storeCatalogue(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10'
]);