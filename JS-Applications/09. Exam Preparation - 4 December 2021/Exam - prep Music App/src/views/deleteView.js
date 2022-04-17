import * as albumService from '../services/albumService.js';

export const deleteView = async(context) => {

    try {
        const album = await albumService.getOne(context.params.albumId);

        let confirmed = confirm(`Do you want to delete the album: ${album.name}`);

        if (confirmed) {
            await albumService.remove(context.params.albumId);
            context.page.redirect('/catalog');
        }

    } catch (err) {
        alert(err);
    }
};