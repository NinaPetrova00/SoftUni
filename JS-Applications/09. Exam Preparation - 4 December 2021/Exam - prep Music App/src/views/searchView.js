import { html, nothing } from '../../node_modules/lit-html/lit-html.js';
import * as albumService from '../services/albumService.js';
import { albumTemplate } from './templates/albumTemplate.js';

const searchTemplate = (searchHandler, albums, isLogged) => html `
<!--Search Page-->
<section id="searchPage">
    <h1>Search by Name</h1>

    <div class="search">
        <input id="search-input" type="text" name="search" placeholder="Enter desired albums's name">
        <button class="button-list" @click=${searchHandler}>Search</button>
    </div>

    <h2>Results:</h2>

    <!--Show after click Search button-->
        <!--If have matches-->
        <!--If there are no matches-->
        ${albums.length>0
        ?   albums.map(a=>albumTemplate(a,isLogged))
        : html`<p class="no-result">No result.</p>`
        }
    </div>
</section>
`;

export const searchView = (context) => {

    const searchHandler = (ev) => {
        let searchElement = document.getElementById('search-input');

        albumService.search(searchElement.value)
            .then(albums => {
                const isLogged = Boolean(context.user);
                context.render(searchTemplate(searchHandler, albums,isLogged));
            });
    };
    context.render(searchTemplate(searchHandler, []));
}