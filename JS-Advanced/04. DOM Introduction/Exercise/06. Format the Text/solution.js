function solve() {

    let inputElement = document.getElementById('input');
    let textArr = inputElement.value.split('.').filter(s => s !== '');
    let resultElement = document.getElementById('output');

    while (textArr.length > 0) {
        let text = textArr.splice(0, 3).join('. ') + '.';

        let paragraphEl = document.createElement('p');
        paragraphEl.textContent = text;
        resultElement.appendChild(paragraphEl);
    }
}