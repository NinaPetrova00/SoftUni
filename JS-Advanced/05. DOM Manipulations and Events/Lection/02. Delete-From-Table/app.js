function deleteByEmail() {

    let emailInputElement = document.querySelector('input[name="email"]');
    let emailTdElements = document.querySelectorAll('tr td:nth-of-type(2)');

    let emailElements = Array.from(emailTdElements);
    let targetElement = emailElements.find(x => x.textContent == emailInputElement.value);

    let resultElement = document.getElementById('result');

    if (targetElement) {
        targetElement.parentNode.remove();
        resultElement.textContent = 'Deleted.';
    } else {
        resultElement.textContent = 'Not found.';
    }
}

// // Applies for NodeList and HTMLCollection
// for (const email of emailTdElements) {
// }

// // Applies only for NodeList
// emailTdElements.forEach(0);
//targetElement.parentNode.removeChild(targetElement); // old syntax