function extractText() {
    console.log('extract Text');

    let ulElements = document.getElementById('items');
    console.log(ulElements.textContent);

    let textAreaElement = document.getElementById('result');
    textAreaElement.textContent = ulElements.textContent;
}