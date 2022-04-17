import { html } from '../../node_modules/lit-html/lit-html.js';
import * as gamesService from '../api/gamesService.js';
import { createSubmitHandler } from '../util.js';

const editTemplate = (game, onSubmit) => html `
<!-- Edit Page ( Only for the creator )-->
<section id="edit-page" class="auth">
    <form @submit=${onSubmit} id="edit">
        <div class="container">

            <h1>Edit Game</h1>
            <label for="leg-title">Legendary title:</label>
            <input type="text" id="title" name="title" .value=${game.title}>

            <label for="category">Category:</label>
            <input type="text" id="category" name="category" .value=${game.category}>

            <label for="levels">MaxLevel:</label>
            <input type="number" id="maxLevel" name="maxLevel" min="1" .value=${game.maxLevel}>

            <label for="game-img">Image:</label>
            <input type="text" id="imageUrl" name="imageUrl" .value=${game.imageUrl}>

            <label for="summary">Summary:</label>
            <textarea name="summary" id="summary .value=${game.summary}"></textarea>
            <input class="btn submit" type="submit" value="Edit Game">

        </div>
    </form>
</section>
`;


export async function editPage(context) {
    const gameId = context.params.id;
    const game = await gamesService.getById(gameId);

    context.render(editTemplate(game, createSubmitHandler(context, onSubmit)));
}

async function onSubmit(context, data, ev) {
    const gameId = context.params.id;

    if (Object.values(data).some(f => f == '')) {
        alert('All fields are required');

        return;
    }

    await gamesService.update(gameId, {
        title: data.title,
        category: data.category,
        maxLevel: data.maxLevel,
        imageUrl: data.imageUrl,
        summary: data.summary
    });

    ev.target.reset();
    context.page.redirect('/details/' + gameId);
}