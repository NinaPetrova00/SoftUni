function sortingArr(arr) {

    let newArr = arr.sort((a, b) => {
        if (a.length === b.length) {
            return a.localeCompare(b);
        } else {
            return a.length - b.length;
        }
    });
    console.log(newArr.join('\n'));
}

sortingArr(['alpha', 'beta', 'gamma']);
sortingArr(['Isacc', 'Theodor', 'Jack', 'Harrison', 'George']);
sortingArr(['test', 'Deny', 'omen', 'Default']);