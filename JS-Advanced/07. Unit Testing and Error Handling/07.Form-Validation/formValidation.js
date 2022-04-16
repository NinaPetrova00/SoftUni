function validate() {

    let usernameInput = document.getElementById('username');
    let emailInput = document.getElementById('email');
    let passwordInput = document.getElementById('password');
    let confirmPasswordInput = document.getElementById('confirm-password');

    usernameInput.addEventListener('change', onChange);
    emailInput.addEventListener('change', onChange);
    passwordInput.addEventListener('change', onChange);
    confirmPasswordInput.addEventListener('change', onChange);

    let usernameRegex = /[A-Za-z0-9]/gm;
    let passRegex = /\w/gm;

    function onChange() {
        // Username
        if (usernameInput.value.length < 3 || usernameInput.length > 20 || !(usernameRegex.test(usernameInput.value))) {
            usernameInput.style.borderColor = 'red';
        } else {
            usernameInput.style.borderColor = 'none';
        }

        // Password
        if (passwordInput.value.length < 5 || passwordInput.value.length > 15 || !(passRegex.test(passwordInput.value)) ||
            passwordInput.value !== confirmPasswordInput.value) {
            console.log(passwordInput.value);
            console.log(confirmPasswordInput.value);
            passwordInput.style.borderColor = 'red';
        } else {
            passwordInput.style.borderColor = 'none';
        }

        // Confirm pass
        if (confirmPasswordInput.value.length < 5 || confirmPasswordInput.value.length > 15 || !(passRegex.test(confirmPasswordInput.value)) ||
            passwordInput.value !== confirmPasswordInput.value) {
            confirmPasswordInput.style.borderColor = 'red';
        } else {
            confirmPasswordInput.style.borderColor = 'none';
        }
    }
}