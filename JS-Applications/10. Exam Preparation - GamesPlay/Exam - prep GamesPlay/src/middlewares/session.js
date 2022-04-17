import { getUserData } from "../util.js";

export function addSession(context, next) {

    context.user = getUserData();

    next();
}