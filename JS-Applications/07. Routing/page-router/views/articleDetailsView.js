import { render, html } from '../node_modules/lit-html/lit-html.js'

const articleDetailsTemplate = (article) => html `
<article>
    <h1>${article.title}</h1>

    <main>
        ${article.content};
    </main>

    <footer>
        <p>Author:${article.author}</p>
    </footer>
</article>
`;

const fetchArticle = (articleId) =>
    fetch(`http://localhost:3030/jsonstore/articles/${articleId}`)
    .then(response => response.json());


export const articleDetailsView = (context) => {
    const root = document.getElementById('root');

    fetchArticle(context.params.articleId)
        .then(article => {
            render(articleDetailsTemplate(article), root);
        });
};