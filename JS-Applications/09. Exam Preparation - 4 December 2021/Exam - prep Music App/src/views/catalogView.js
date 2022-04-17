import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as albumService from '../services/albumService.js';
import { albumTemplate } from './templates/albumTemplate.js';


const catalogTemplate = (albums, user) => html `
<!--Catalog-->
<section id="catalogPage">
    <h1>All Albums</h1>

    ${albums.map(a => albumTemplate(a, Boolean(user)))}

    ${albums.length == 0
    ? html`<p>No Albums in Catalog!</p>`
    : nothing}

</section>
`;

export const catalogView = (context) => {
    albumService.getAll()
        .then(albums => {
            context.render(catalogTemplate(albums, context.user));
        });
}