import { Fragment, useState, useEffect } from "react";
import { UserDetails } from "./userDetails/UserDetails";
import { UserRow } from "./userRow/UserRow";
import { UserEdit } from "./userEdit/UserEdit";
import { UserActionTypes } from './UserListConstants';
import { UserDelete } from "./userDelete/UserDelete";
import { UserCreate } from "./userCreate/userCreate";

import * as userService from '../../services/userService';

export const UserTable = () => {
    const [users, setUsers] = useState([]);

    const [userAction, setUserAction] = useState({ user: null, action: null });

    useEffect(() => {
        userService.getAll()
            .then(users => setUsers(users));
    }, []);


    const userActionClickHandler = (userId, actionType) => {
        userService.getOne(userId)
            .then(user => {
                setUserAction({
                    user: user,
                    action: actionType,
                });
            });
    };

    const createUserOpenHandler = () => {
        setUserAction({
            user: null,
            action: UserActionTypes.Add
        });
    };

    const closeHandler = () => {
        setUserAction({
            user: null,
            action: null,
        });
    };

    // const userCreateHandler = (ev) => {
    //     ev.preventDefault();

    //     const formData = new FormData(ev.target);

    //     const {
    //         firstName,
    //         lastName,
    //         email,
    //         imageUrl,
    //         phoneNumber,
    //         ...address
    //     } = Object.fromEntries(formData);

    //     const userData = {
    //         firstName,
    //         lastName,
    //         email,
    //         imageUrl,
    //         phoneNumber,
    //         address
    //     };

    //     userService.create(userData)
    //         .then(user => {
    //             console.log(user);
    //             setUsers(state => [...state, user]);
    //             closeHandler();
    //         });
    // };

    const userCreateHandler = (userData) => {
        userService.create(userData)
            .then(user => {
                setUsers(state => [...state, user]);
                closeHandler();
            })
            .catch(err => {
                console.log(err);
            });
    };

    return (
        <Fragment>
            <div className="table-wrapper">
                {/* <!-- Overlap components  --> */}
                {userAction.action === UserActionTypes.Details &&
                    <UserDetails {...userAction.user} onClose={closeHandler} />}

                {userAction.action === UserActionTypes.Edit &&
                    <UserEdit {...userAction.user} onClose={closeHandler} />}

                {userAction.action === UserActionTypes.Delete &&
                    <UserDelete {...userAction.user} onClose={closeHandler} />}

                {userAction.action === UserActionTypes.Add &&
                    < UserCreate onClose={closeHandler} onUserCreate={userCreateHandler} />}

                <table className="table">
                    <thead>
                        <tr>
                            <th>
                                Image
                            </th>
                            <th>
                                First name<svg aria-hidden="true" focusable="false" data-prefix="fas" data-icon="arrow-down"
                                    className="icon svg-inline--fa fa-arrow-down Table_icon__+HHgn" role="img" xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 384 512">
                                    <path fill="currentColor"
                                        d="M374.6 310.6l-160 160C208.4 476.9 200.2 480 192 480s-16.38-3.125-22.62-9.375l-160-160c-12.5-12.5-12.5-32.75 0-45.25s32.75-12.5 45.25 0L160 370.8V64c0-17.69 14.33-31.1 31.1-31.1S224 46.31 224 64v306.8l105.4-105.4c12.5-12.5 32.75-12.5 45.25 0S387.1 298.1 374.6 310.6z">
                                    </path>
                                </svg>
                            </th>
                            <th>
                                Last name<svg aria-hidden="true" focusable="false" data-prefix="fas" data-icon="arrow-down"
                                    className="icon svg-inline--fa fa-arrow-down Table_icon__+HHgn" role="img" xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 384 512">
                                    <path fill="currentColor"
                                        d="M374.6 310.6l-160 160C208.4 476.9 200.2 480 192 480s-16.38-3.125-22.62-9.375l-160-160c-12.5-12.5-12.5-32.75 0-45.25s32.75-12.5 45.25 0L160 370.8V64c0-17.69 14.33-31.1 31.1-31.1S224 46.31 224 64v306.8l105.4-105.4c12.5-12.5 32.75-12.5 45.25 0S387.1 298.1 374.6 310.6z">
                                    </path>
                                </svg>
                            </th>
                            <th>
                                Email<svg aria-hidden="true" focusable="false" data-prefix="fas" data-icon="arrow-down"
                                    className="icon svg-inline--fa fa-arrow-down Table_icon__+HHgn" role="img" xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 384 512">
                                    <path fill="currentColor"
                                        d="M374.6 310.6l-160 160C208.4 476.9 200.2 480 192 480s-16.38-3.125-22.62-9.375l-160-160c-12.5-12.5-12.5-32.75 0-45.25s32.75-12.5 45.25 0L160 370.8V64c0-17.69 14.33-31.1 31.1-31.1S224 46.31 224 64v306.8l105.4-105.4c12.5-12.5 32.75-12.5 45.25 0S387.1 298.1 374.6 310.6z">
                                    </path>
                                </svg>
                            </th>
                            <th>
                                Phone<svg aria-hidden="true" focusable="false" data-prefix="fas" data-icon="arrow-down"
                                    className="icon svg-inline--fa fa-arrow-down Table_icon__+HHgn" role="img" xmlns="http://www.w3.org/2000/svg"
                                    viewBox="0 0 384 512">
                                    <path fill="currentColor"
                                        d="M374.6 310.6l-160 160C208.4 476.9 200.2 480 192 480s-16.38-3.125-22.62-9.375l-160-160c-12.5-12.5-12.5-32.75 0-45.25s32.75-12.5 45.25 0L160 370.8V64c0-17.69 14.33-31.1 31.1-31.1S224 46.31 224 64v306.8l105.4-105.4c12.5-12.5 32.75-12.5 45.25 0S387.1 298.1 374.6 310.6z">
                                    </path>
                                </svg>
                            </th>
                            <th>
                                Created
                                <svg aria-hidden="true" focusable="false" data-prefix="fas"
                                    data-icon="arrow-down" className="icon active-icon svg-inline--fa fa-arrow-down Table_icon__+HHgn" role="img"
                                    xmlns="http://www.w3.org/2000/svg" viewBox="0 0 384 512">
                                    <path fill="currentColor"
                                        d="M374.6 310.6l-160 160C208.4 476.9 200.2 480 192 480s-16.38-3.125-22.62-9.375l-160-160c-12.5-12.5-12.5-32.75 0-45.25s32.75-12.5 45.25 0L160 370.8V64c0-17.69 14.33-31.1 31.1-31.1S224 46.31 224 64v306.8l105.4-105.4c12.5-12.5 32.75-12.5 45.25 0S387.1 298.1 374.6 310.6z">
                                    </path>
                                </svg>
                            </th>
                            <th>Actions</th>
                        </tr>
                    </thead>

                    <tbody>
                        {/* <!-- Table row component --> */}
                        {users.map(user =>
                            <tr key={user._id}>
                                <UserRow
                                    {...user}
                                    onActionClick={userActionClickHandler}

                                />
                            </tr>
                        )}
                    </tbody>

                </table>
            </div>
            <button className="btn-add btn" onClick={createUserOpenHandler}>
                Add new user
            </button>
        </Fragment >
    );
};