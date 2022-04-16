// Global context
function random() {
    return Math.random();
}

random(); //global invocation -> this=window -> undefined
let math = {
    random: random
};
math.random(); //method invocation


// Object context
let obj = {
    name: 'Peter',
    greed() {
        console.log(`Hello, my name is ${this.name}`);
    }
};

obj.greed(); //method invocation

let greed = obj.greed; // copy fun by reference

greed(); //global invocation


// DOM element - must execute in browser
// document.addEventListener('click', function() {
//     console.log(this);
// });


// Nested functions
function a() {
    function b() {
        function c() {
            function d() {
                console.log(this);
            }
            d(); //global invocation
        }
        c(); //global invocation
    }
    b(); //global invocation
}
a(); //global invocation