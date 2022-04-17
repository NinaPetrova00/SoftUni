const contactTemplate = (contact) => `
<div class="card" style="width: 18rem;">
  <img src="https://www.howtogeek.com/wp-content/uploads/2021/06/Android-contacts-logo.png?width=1198&trim=1,1&bg-color=000&pad=1,1" class="card-img-top" alt="contact">
  <div class="card-body">
    <h5 class="card-title">${contact.person}</h5>
    <p class="card-text">${contact.phone}</p>
    <a href="#" class="btn btn-primary">Go somewhere</a>
  </div>
</div>
`;
export default contactTemplate;