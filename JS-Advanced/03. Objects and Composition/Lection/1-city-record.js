function solve() {

    // first way
    let record = {
        name: city,
        population: population,
        treasury: treasury,
    };

    // second way
    let record = {};
    record.name = city;
    record.population = population;
    record.treasury = treasury;

    // third way
    let record = {
        name: city,
        population, //make property with name Population and assing to it the value of population 
        treasury
    };
    return record;
};
solve();
console.log(solve('Tortuga',
    7000,
    15000
));