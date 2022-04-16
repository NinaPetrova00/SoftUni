// Closure
function counterBuilder() {
    let counter = 0;

    return function() {
        counter++;
        console.log(counter);
    }
}

let counter = counterBuilder();
counter(); //impure function
counter(); //impure function
counter(); //impure function
counter(); //impure function