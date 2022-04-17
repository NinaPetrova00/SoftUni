import { render } from '../../node_modules/lit-html/lit-html.js';
import { navigationBarView } from '../views/navigationBar.js';

const headerEl = document.querySelector('.my-navigation');
const mainEl = document.getElementById('content');

const renderContent = (templateResult) => {
    render(templateResult, mainEl);
};

export const renderNavigationBarMiddleware = (context, next) => {

    render(navigationBarView(context), headerEl);

    next();
};

export const renderContentMiddleware = (context, next) => {

    context.render = renderContent;

    next();
};