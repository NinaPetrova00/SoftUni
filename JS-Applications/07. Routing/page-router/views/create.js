import { render, html } from '../node_modules/lit-html/lit-html.js'
import page from '../node_modules/page/page.mjs'

const createArticleHandler = (context, ev) => {
    ev.preventDefault();

    let formData = new FormData(ev.currentTarget);

    let title = formData.get('title');
    let content = formData.get('content');
    let author = formData.get('author');

    fetch('http://localhost:3030/jsonstore/articles', {
            method: 'POST',
            headers: {
                'content-type': 'application/json'
            },
            body: JSON.stringify({ title, content, author })
        })
        .then(res => res.json())
        .then(article => {
            page.redirect(`/articles/${article._id}`)
        });
};

const createTemplate = (context) => html `
<form @submit=${(ev) => createArticleHandler(context, ev)}>
        <div>
            <label for="title">Title</label>
            <input type="text" id="title" name="title" />
        </div>

        <div>
            <label for="content">Content</label>
            <textarea name="content" id="content" cols="30" rows="10"></textarea>
        </div>

        <div>
            <label for="author">Author</label>
            <input type="text" name="author" id="author" />
        </div>

        <div>
            <input type="submit" value="Create" />
        </div>
    
    </form>
`;

const root = document.getElementById('root');

export const createView = (context) => {

    render(createTemplate(context), root);

};