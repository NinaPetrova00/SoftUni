function create(input) {

    let parentElement = document.getElementById('content');
    let elements = input;

    for (let i = 0; i < elements.length; i++) {

        let div = document.createElement('div');
        let paragraph = document.createElement('p');
        let text = document.createTextNode(elements[i]);

        paragraph.appendChild(text);
        paragraph.style.display = 'none';

        div.appendChild(paragraph);

        div.addEventListener('click', function(event) {
            event.target.children[0].style.display = 'block';
        });

        parentElement.appendChild(div);
    }
}