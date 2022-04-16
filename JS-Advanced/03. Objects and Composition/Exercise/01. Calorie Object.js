function caloriesObj(input) {

    let resultObject = {};

    for (let i = 0; i < input.length; i++) {
        let productName = input[i];
        let calories = Number(input[++i]);
        resultObject[productName] = calories;
    }
    console.log(resultObject);
}
caloriesObj(['Yoghurt', '48', 'Rise', '138', 'Apple', '52']);
caloriesObj(['Potato', '93', 'Skyr', '63', 'Cucumber', '18', 'Milk', '42']);