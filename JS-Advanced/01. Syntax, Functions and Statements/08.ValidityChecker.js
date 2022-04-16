function check(num1, num2, num3, num4) {
    let x1 = num1;
    let y1 = num2;
    let x2 = num3;
    let y2 = num4;

    let distanceFormula = function() {
        return Math.sqrt(((x2 - x1) ** 2) + ((y2 - y1) ** 2));
    }

    if (Number.isInteger(distanceFormula)) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }
}

check(3, 0, 0, 4);
// check(2, 1, 1, 1);