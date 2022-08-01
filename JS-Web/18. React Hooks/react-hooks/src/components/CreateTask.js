import { useState } from "react";

export const CreateTask = ({
    taskCreateHandler
}) => {
    const [task, setTask] = useState('');

    const onSubmitHandler = (ev) => {
        ev.preventDefault();

        taskCreateHandler(task);
        setTask(''); //clear text/task filed
    };

    const onTaskChange = (ev) => {
        setTask(ev.target.value);
    }

    return (
        <form onSubmit={onSubmitHandler}>
            <input
                type="text"
                name="taskName"
                placeholder="Do the dishes"
                value={task}
                onChange={onTaskChange}
            />
            <input type="submit" value="Add" />
        </form>
    );
};