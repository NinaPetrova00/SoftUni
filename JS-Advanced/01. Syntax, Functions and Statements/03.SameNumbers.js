function same(a) {

    let num = a.toString();
    let sum = 0;
    let isSame = true;
    let firstDigit = num[0];

    for (let i = 0; i < num.length; i++) {
        // sum+=Number(num[i]);
        sum += +num[i];

        if (num[i] != firstDigit) {
            isSame = false;
        }
    }
    console.log(isSame);
    console.log(sum);
}

same(2222222);
same(1234);