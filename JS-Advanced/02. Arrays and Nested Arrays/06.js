function ascendFunction(arr) {

    let sorted = arr.sort((a, b) => a.localeCompare(b));

    let orderNum = 1;
    sorted.forEach((element) => {
        console.log(`${orderNum}.${element}`);
        orderNum++;
    });
}

ascendFunction(["John", "Bob", "Christina", "Ema"]);