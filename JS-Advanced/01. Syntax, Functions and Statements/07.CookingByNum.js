function operation(number, p1, p2, p3, p4, p5) {
    let num = Number(number);
    let arrOfCommands = [p1, p2, p3, p4, p5];

    let chop = function() {
        return num / 2;
    };

    let dice = function() {
        return Math.sqrt(num);
    };

    let spice = function() {
        return num + 1;
    };

    let bake = function() {
        return num * 3;
    };

    let fillet = function() {
        return num * 0.80;
    };

    for (let i = 0; i < arrOfCommands.length; i++) {

        let currentCommand = arrOfCommands[i];

        switch (currentCommand) {
            case 'chop':
                num = chop(num);
                console.log(num);
                break;
            case 'dice':
                num = dice(num);
                console.log(num);
                break;
            case 'spice':
                num = spice(num);
                console.log(num);
                break;
            case 'bake':
                num = bake(num);
                console.log(num);
                break;
            case 'fillet':
                num = fillet(num);
                console.log(num);
                break;
        }
    }
}
// operation('32', 'chop', 'chop', 'chop', 'chop', 'chop');
operation('9', 'dice', 'spice', 'chop', 'bake', 'fillet');