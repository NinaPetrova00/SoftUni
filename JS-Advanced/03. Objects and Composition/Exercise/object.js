function objDemo() {

    let doubleChocko = {
        flourType: 'brown',
        topping: 'caramel',
        bonus: 'stawberry',
        weight: 100,
    };

    console.log(typeof doubleChocko);
    console.log(typeof []);

    // Get values
    console.log(doubleChocko);
    console.log(doubleChocko.bonus); //first way
    console.log(doubleChocko['flourType']); //second way

    // Change values
    doubleChocko.flourType = 'white';
    console.log(doubleChocko);

    // Add new key-value pair
    doubleChocko.count = 5; //first way
    doubleChocko['count'] = 5; //second way
    console.log(doubleChocko);

    //Delete key-value pair
    delete doubleChocko.bonus;
    console.log(doubleChocko);

}

objDemo();