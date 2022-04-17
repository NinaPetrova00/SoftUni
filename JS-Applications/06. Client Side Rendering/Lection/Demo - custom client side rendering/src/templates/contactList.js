import contactTemplate from './contacts.js';

const contactListTemplate = (contacts) => `
<div class="contact-list" style="display: flex; justify-content: space-around;">
${contacts.map(x=>contactTemplate(x)).join('')}
</div>
`;

export default contactListTemplate;