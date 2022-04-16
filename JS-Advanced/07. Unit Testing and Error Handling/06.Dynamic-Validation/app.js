function validate() {
    let inputEmail = document.getElementById('email');
    inputEmail.addEventListener('change', onChange);

    function onChange(e) {
        const pattern = /[a-z]+@[a-z]+\.[a-z]+/gm;

        if (pattern.test(e.target.value)) {
            e.target.classList.remove('error');
        } else {
            e.target.classList.add('error');
        }
    }
}