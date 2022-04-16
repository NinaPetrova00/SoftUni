function townsJSON(input) {

    let result = [];

    for (let i = 1; i < input.length; i++) {
        let splitedInput = input[i].split('|');

        let Town = splitedInput[1].trim();
        let Latitude = Number(splitedInput[2].trim()).toFixed(2);
        let Longitude = Number(splitedInput[3].trim()).toFixed(2);

        result.push({ Town, Latitude: Number(Latitude), Longitude: Number(Longitude) });
    }
    console.log(JSON.stringify(result));
}

townsJSON(['| Town | Latitude | Longitude |',
    '| Sofia | 42.696552 | 23.32601 |',
    '| Beijing | 39.913818 | 116.363625 |'
]);