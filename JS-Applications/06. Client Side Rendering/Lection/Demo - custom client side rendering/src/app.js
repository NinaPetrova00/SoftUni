// import navbarTemplate from './templates/navbar.js'
// import contactListTemplate from './templates/contactList.js';
// import contactTemplate from './templates/contacts.js';

import { getContacts } from './api.js';
import render from './render.js';
import mainTemplate from './templates/mainTemplate.js';

const rootElement = document.getElementById('root');

const contacts = await getContacts();

render(mainTemplate({ contacts }), rootElement);

// contacts.forEach(x => {
//     let templateResult = contactTemplate(x);
//     render(templateResult, rootElement);
// });


window.addContact = function() {
    fetch(' http://localhost:3030/jsonstore/contacts', {
            method: 'POST',
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify({ person: 'Stamat', phone: '48515' })
        })
        .then(res => res.json())
        .then(contact => {
            render(mainTemplate({ contacts: [...contacts, contact] }), rootElement);
        });
}