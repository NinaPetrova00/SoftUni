import { useEffect, useContext, useState } from "react";
import { TaskContext } from "../contexts/TaskContext";

import styles from './TaskItem.module.css';

export const TaskItem = ({
    task
}) => {
    const [isEdit, setIsEdit] = useState(false);

    const { taskDeleteHandler, toggleTask, changeTitle } = useContext(TaskContext);

    useEffect(() => {
        console.log('Mount');

        return () => {
            console.log('Unmount')
        }
    }, []);

    const taskEditHandler = () => {
        setIsEdit(true);
    };

    const classNames = [
        task.isCompleted ? styles.completed : '',
        styles['taks-item']
    ];

    const onEdit = (ev) => {
        ev.preventDefault();
        const { title } = Object.fromEntries(new FormData(ev.target));

        changeTitle(task, title);
        setIsEdit(false);
        console.log(title);
    };


    return (
        <li>
            {isEdit
                ? <form onSubmit={onEdit}>
                    <input type="text" name="title" defaultValue={task.title}></input>
                    <input type="submit" value="edit"></input>
                </form>

                : <>
                    <span
                        className={classNames.join(' ')}
                        onClick={() => toggleTask(task)}
                    >
                        {task.title}
                    </span>
                    <button onClick={() => taskDeleteHandler(task._id)}>x</button>
                    <button onClick={taskEditHandler}>edit</button>
                </>
            }
        </li>
    );
};