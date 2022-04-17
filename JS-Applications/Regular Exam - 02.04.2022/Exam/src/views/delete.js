import * as petService from '../services/petsService.js';

export const deleteView = async(context) => {
    try {
        const pet = await petService.getOne(context.params.petId);

        let confirmation = confirm(`Do you really want to delete ${pet.name}?`);

        if (confirmation == true) {
            await petService.delPet(context.params.petId);
            context.page.redirect('/');
        }
    } catch (err) {
        alert(err);
    }
};