function edit(element, match, replacer) {

    // while solution
    while (element.textContent.includes(match)) {
        element.textContent = element.textContent.replace(match, replacer);
    }

    //regex solution
    let pattern = new RegExp(match, 'g');
    element.textContent = element.textContent.replace(match, replacer);

};