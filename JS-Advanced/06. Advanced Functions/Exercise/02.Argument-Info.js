function info() {

    let dataObj = {};

    Array.from(arguments).forEach((line) => {
        let type = typeof(line);

        console.log(`${type}: ${line}`);

        if (!dataObj[type]) {
            dataObj[type] = 0; //set it 
        }
        dataObj[type]++; //increase it
    });

    Object.keys(dataObj)
        .sort((a, b) => dataObj[b] - dataObj[a])
        .forEach((key) => console.log(`${key} = ${dataObj[key]}`));

    // Object.keys(dataObj)
    //     .sort((a, b) => {
    //         return dataObj[b] - dataObj[a];
    //     })
    //     .forEach((key) => console.log(`${key} = ${dataObj[key]}`));
}

info('cat', 42, function() { console.log('Hello world!'); });