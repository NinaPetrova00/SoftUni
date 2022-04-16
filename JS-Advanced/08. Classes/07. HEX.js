class Hex {
    constructor(value) {
        this.value = value;
    }

    //methods
    valueOf() {
        //This function should return the value property of the hex class.
        return this.value;
    };

    toString() {
        //This function will show its hexadecimal value starting with "0x"
        return '0x' + this.value.toString(16).toUpperCase();
    };

    plus(input) {
        //This function should add a number or Hex object and return a new Hex object.
        if (typeof input === 'object') {
            let result = this.value + input.value;
            return new Hex(result);
        } else {
            let result = this.value + input;
            return new Hex(result);
        }
    };

    minus(input) {
        //This function should subtract a number or Hex object and return a new Hex object.
        if (typeof input === 'object') {
            let result = this.value - input.value;
            return new Hex(result);
        } else {
            let result = this.value - input;
            return new Hex(result);
        }
    };

    parse(number) {
        //Create a parse class method that can parse Hexadecimal numbers and convert them to standard decimal numbers.
        return parseInt(number, 16);
    };
}

let FF = new Hex(255);
console.log(FF.toString());
FF.valueOf() + 1 == 256;
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString() === '0xF');
console.log(FF.parse('AAA'));