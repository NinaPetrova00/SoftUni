// function solve(input) {
//     let towns = {}; //object

//     for (const info of input) {
//         let infoArr = info.split(' <-> ');
//         let town = infoArr[0];
//         let population = Number(infoArr[1]);

//         if (!towns[town]) {
//             towns[town] = 0;
//         }
//         towns[town] += population;
//     }
//     for (const town in towns) {
//         console.log(`${town} : ${towns[town]}`);
//     }
// }

// Second way
function solve(input) {
    let towns = {}; //object

    for (const info of input) {
        let [town, populationText] = info.split(' <-> '); //with desctrucuring
        let population = Number(populationText);

        if (!towns[town]) {
            towns[town] = 0;
        }
        towns[town] += population;
    }
    for (const town in towns) {
        console.log(`${town} : ${towns[town]}`);
    }
}
// solve(
//     ['Sofia <-> 1200000',
//         'Montana <-> 20000',
//         'New York <-> 10000000',
//         'Washington <-> 2345000',
//         'Las Vegas <-> 1000000'
//     ]
// );

solve(
    ['Istanbul <-> 100000',
        'Honk Kong <-> 2100004',
        'Jerusalem <-> 2352344',
        'Mexico City <-> 23401925',
        'Istanbul <-> 1000'
    ]
);