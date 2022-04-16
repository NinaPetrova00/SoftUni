window.addEventListener('load', solution);

function solution() {

    const block = document.getElementById('block');
    const submitButton = document.getElementById('submitBTN');
    const editButton = document.getElementById('editBTN');
    const continueButton = document.getElementById('continueBTN');
    const preview = document.getElementById('infoPreview');

    submitButton.disabled = false;
    editButton.disabled = true;
    continueButton.disabled = true;

    const inputValues = Array.from(document.getElementById('form').querySelectorAll('input'));
    const labelValues = Array.from(document.getElementById('form').querySelectorAll('label'));
    inputValues.pop(); // remove Submit button from inputValues

    submitButton.addEventListener('click', (e) => {

        const fullName = inputValues[0];
        const email = inputValues[1];

        if (fullName.value !== '' && email.value !== '') {

            for (let i = 0; i < inputValues.length; i++) {

                const liElement = document.createElement('li');
                liElement.textContent = `${labelValues[i].textContent} ${inputValues[i].value}`;
                preview.appendChild(liElement);
            }
            for (let input of inputValues) {
                input.value = '';
            }

            e.target.disabled = true;
            editButton.disabled = false;
            continueButton.disabled = false;
        }
    });

    editButton.addEventListener('click', (e) => {
        const listItems = Array.from(preview.childNodes);

        for (let i = 0; i < inputValues.length; i++) {
            inputValues[i].value = listItems[i].textContent.split(': ')[1];
            listItems[i].remove();
        }
        submitButton.disabled = false;
        editButton.disabled = true;
        continueButton.disabled = true;
    });

    continueButton.addEventListener('click', (e) => {
        block.innerHTML = '';
        let h3 = document.createElement('h3');
        h3.innerText = 'Thank you for your reservation!';
        block.appendChild(h3);
    });
}