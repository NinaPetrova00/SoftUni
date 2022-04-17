import page from '../node_modules/page/page.mjs';
import { authenticationMiddleware } from './middlewares/authenticationMiddleware.js';

import { renderContentMiddleware, renderNavigationBarMiddleware } from "./middlewares/renderMiddleware.js";
import { createView } from './views/create.js';
import { dashboardView } from './views/dashboard.js';
import { deleteView } from './views/delete.js';
import { detailView } from './views/details.js';
import { editView } from './views/edit.js';
import { homePageView } from './views/homePage.js';
import { loginView } from './views/login.js';
import { logoutView } from './views/logout.js';
import { registerView } from './views/register.js';

page(authenticationMiddleware);
page(renderContentMiddleware);
page(renderNavigationBarMiddleware);

page('/', homePageView);
page('/login', loginView);
page('/register', registerView);
page('/logout', logoutView);
page('/dashboard', dashboardView);
page('/details/:petId', detailView);
page('/edit/:petId', editView);
page('/details/:petId/delete', deleteView);
page('/create', createView);
page.start();
///data/pets/:id