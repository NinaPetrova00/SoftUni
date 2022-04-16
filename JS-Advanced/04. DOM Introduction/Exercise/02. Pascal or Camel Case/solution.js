function solve() {

    let text = document.getElementById('text').value;
    let convention = document.getElementById('naming-convention').value;

    let result = '';

    if (convention === 'Camel Case') {
        for (let i = 0; i < text.length; i++) {
            let currentEl = text[i];

            if (currentEl === ' ') {
                result += text[i + 1].toUpperCase();
                i++;
            } else {
                result += currentEl.toLowerCase();
            }
        }
    } else if (convention === 'Pascal Case') {

        for (let i = 0; i < text.length; i++) {
            let currentEl = text[i];
            if (currentEl === ' ') {
                result += text[i + 1].toUpperCase();
                i++;
            } else if (i === 0) {
                result += currentEl.toUpperCase();
            } else {
                result += currentEl.toLowerCase();
            }
        }
    } else {
        result = 'Error!';
    }

    let resultElement = document.getElementById('result');
    resultElement.textContent = result;
}