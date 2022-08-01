import { useContext } from "react";
import { TaskContext } from "../contexts/TaskContext";
import { TaskItem } from "./TaskItem";

export const TaskList = () => {
    const { tasks } = useContext(TaskContext);

    return (
        <ul>
            {tasks.map(t =>
                <TaskItem
                    key={t._id}
                    task={t}
                />
            )}
        </ul>
    );
};