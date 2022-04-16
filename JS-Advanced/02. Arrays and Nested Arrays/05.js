function incrArr(arr) {

    let newArr = [];
    let biggestNum = 0;
    for (let i = 0; i < arr.length; i++) {
        let currentElement = arr[i];

        if (currentElement > biggestNum) {
            biggestNum = currentElement;
            newArr.push(biggestNum);
        }
    }
    return newArr;
}

console.log(incrArr([1, 3, 8, 4, 10, 12, 3, 2, 24]));
console.log(incrArr([1, 2, 3, 4]));
console.log(incrArr([20, 3, 2, 15, 6, 1]));