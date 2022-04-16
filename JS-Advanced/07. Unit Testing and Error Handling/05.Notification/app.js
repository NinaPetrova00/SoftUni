function notify(message) {

    let notification = document.getElementById('notification');
    notification.innerText = message;
    notification.style.display = 'block';

    // first way
    // setTimeout(() => {
    //     notification.style.display = 'none';
    // }, 2000);

    // second way
    notification.addEventListener('click', (e) => {
        e.target.style.display = 'none';
    });
}