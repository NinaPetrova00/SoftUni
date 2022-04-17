import { html, nothing } from '../../../node_modules/lit-html/lit-html.js';

/*artist: "Pink Floyd"
description: "The Dark Side of the Moon is the eighth studio album by the English rock band Pink Floyd, released on 1 March 1973 by Harvest Records."
genre: "Rock Music"
imgUrl: "/images/pinkFloyd.jpg"
name: "The Dark Side of the Moon"
price: "28.75"
releaseDate: "March 1, 1973"
_createdOn: 1617194295474
_id: "126777f5-3277-42ad-b874-76d043b069cb"
_ownerId: "847ec027-f659-4086-8032-5173e2f9c93a" */
const albumDetails = (albumId) => html `
<div class="btn-group">
    <a href="/albums/${albumId}" id="details">Details</a>
</div>
`;

export const albumTemplate = (album, withDetails = true) => html `
<div class="card-box">
    <img src=${album.imgUrl}>
    <div>
        <div class="text-center">
            <p class="name">Name: ${album.name}</p>
            <p class="artist">Artist: ${album.artist}</p>
            <p class="genre">Genre: ${album.genre}</p>
            <p class="price">Price: ${album.price}</p>
            <p class="date">Release Date: ${album.releaseDate}</p>
        </div>

        ${withDetails ? albumDetails(album._id) : nothing}

    </div>
</div>
`;