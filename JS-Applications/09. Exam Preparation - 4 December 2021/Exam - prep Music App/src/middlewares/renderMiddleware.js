import { render } from '../../node_modules/lit-html/lit-html.js';
import { navigationView } from '../views/navigationView.js';

const headerElement = document.querySelector('.header-navigation');
const contentElement = document.querySelector('#main-content');

const renderContent = (templateResult) => {
    render(templateResult, contentElement);
};

export const renderNavigationMiddleware = (context, next) => {
    //TODO: render navigation

    render(navigationView(context), headerElement);
    next();
};

export const renderContentMiddleware = (context, next) => {
    context.render = renderContent;

    next();
};