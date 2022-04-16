function objDemo() {

    let doubleChocko = {
        flourType: 'brown',
        topping: 'caramel',
        bonus: 'stawberry',
        weight: 100,
    };

    // Copy object
    let copy = doubleChocko; // wrong way

    // Deepcopy object - correct way
    let copy = JSON.parse(JSON.stringify(doubleChocko));
    doubleChocko.bonus = 'none';
    console.log(copy);

}

objDemo();