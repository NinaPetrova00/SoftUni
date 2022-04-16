function magicNum(arr) {

    let sum = arr[0].reduce((a, b) => a + b); //sum of first row

    for (let i = 0; i < arr.length; i++) {

        let currentColSum = 0;

        for (let j = 0; j < arr.length; j++) {
            currentColSum += arr[j][i];
        }

        if (currentColSum !== sum) {
            return false;
        }
    }
    return true;
};

magicNum([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]
]);