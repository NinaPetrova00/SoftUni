function getArticleGenerator(input) {

    let articles = input;

    return () => { //closure
        if (articles.length > 0) {
            let container = document.getElementById('content');
            let article = document.createElement('article');
            let currentText = articles.shift();

            article.innerText = currentText;
            container.appendChild(article);
        }
    }
}