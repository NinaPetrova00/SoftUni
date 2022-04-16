function objDemo() {

    let doubleChocko = {
        flourType: 'brown',
        topping: 'caramel',
        bonus: 'stawberry',
        weight: 100,
    };

    for (let element in doubleChocko) {
        console.log(doubleChocko[element]);
    }

    //Built-in methods
    let keys = Object.keys(doubleChocko);
    console.log('Keys:');
    console.log(keys);

    let values = Object.values(doubleChocko);
    console.log('\nValues:');
    console.log(values);

    let entries = Object.entries(doubleChocko);
    console.log('\nEntries:');
    console.log(entries); // aray of arrays
    // we do this, if we want to sort by key/value current object
    console.log(entries[0]);
    console.log(entries[0][1]);
}
objDemo();