function attachEventsListeners() {
    let [inputField, outputField] = document.querySelectorAll('input[type="text"]');

    let fromOption = document.getElementById('inputUnits');
    let toOption = document.getElementById('outputUnits');
    let convertButton = document.getElementById('convert');

    convertButton.addEventListener('click', operation);

    function operation() {
        let convertNum = Number(inputField.value);
        let result = 0;

        switch (fromOption.value) {
            case 'km':
                convertNum *= 1000;
                break;
            case 'm':
                convertNum = convertNum;
                break;
            case 'cm':
                convertNum *= 0.01;
                break;
            case 'mm':
                convertNum *= 0.001;
                break;
            case 'mi':
                convertNum *= 1609.34;
                break;
            case 'yrd':
                convertNum *= 0.9144;
                break;
            case 'ft':
                convertNum *= 0.3048;
                break;
            case 'in':
                convertNum *= 0.0254;
                break;
        }

        switch (toOption.value) {
            case 'km':
                result = convertNum / 1000;
                break;
            case 'm':
                result = convertNum;
                break;
            case 'cm':
                result = convertNum / 0.01;
                break;
            case 'mm':
                result = convertNum / 0.001;
                break;
            case 'mi':
                result = convertNum / 1609.34;
                break;
            case 'yrd':
                result = convertNum / 0.9144;
                break;
            case 'ft':
                result = convertNum / 0.3048;
                break;
            case 'in':
                result = convertNum / 0.0254;
                break;
        }
        outputField.value = result;
    }
}