import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as petService from '../services/petsService.js';

const detailsTemplate = (pet, isPetOwner) => html `
<!--Details Page-->
<section id="detailsPage">
    <div class="details">
        <div class="animalPic">
            <img src="${pet.image}">
        </div>
        <div>
            <div class="animalInfo">
                <h1>Name:${pet.name}</h1>
                <h3>Breed:${pet.breed}</h3>
                <h4>Age:${pet.age}</h4>
                <h4>Weight:${pet.weight}</h4>
                <h4 class="donation">Donation: 0$</h4>
            </div>
            <!-- if there is no registered user, do not display div-->
            <!-- Only for registered user and creator of the pets-->
            ${isPetOwner
            ? html` <div class="actionBtn">
                <a href="/edit/${pet._id}" class="edit">Edit</a>
                <a href="/details/${pet._id}/delete" class="remove">Delete</a>
                <!--(Bonus Part) Only for no creator and user-->
                <a href="#" class="donate">Donate</a>
            </div>`
        : nothing}
        </div>
    </div>
</section>
`;

export const detailView = (context) => {
    petService.getOne(context.params.petId)
        .then(pet => {
            let isPetOwner = pet._ownerId == context.user._id;

            context.render(detailsTemplate(pet, isPetOwner));
        })
}