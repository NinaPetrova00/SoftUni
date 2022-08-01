import styles from './App.module.css';
import { useEffect, useState } from 'react';
import { createContext } from 'react';

import { TaskList } from './components/TaskList';
import { CreateTask } from './components/CreateTask';

import { useFetch } from './hooks/useFetch';
import { useTodosApi } from './hooks/useTodos';
import { TaskContext } from './contexts/TaskContext';

function App() {

  // *We can change this 
  // const [tasks, setTasks] = useState([]);
  // useEffect(() => {
  //   fetch('http://localhost:3030/jsonstore/todos')
  //     .then(res => res.json())
  //     .then(result => {
  //       setTasks(Object.values(result));
  //     });
  // }, []);


  // *With this
  const [tasks, setTasks, isLoading] = useFetch('http://localhost:3030/jsonstore/todos', []);

  const { removeTodo, createTodo, updateTodo } = useTodosApi();

  const taskCreateHandler = async (newTask) => {
    const createdTask = await createTodo(newTask)

    setTasks(oldState => [
      ...oldState,
      createdTask
    ]);
  };

  // first way
  // const taskDeleteHandler = (taskId) => {
  //   removeTodo(taskId)
  //     .then(() =>
  //       setTasks(oldState => oldState.filter(t => t._id != taskId)));
  // };

  //second way
  const taskDeleteHandler = async (taskId) => {

    await removeTodo(taskId);

    setTasks(oldState => oldState.filter(t => t._id != taskId));
  };

  const toggleTask = async (task) => {

    const updatedTask = { ...task, isCompleted: !task.isCompleted };

    await updateTodo(task._id, updatedTask);

    setTasks(state =>
      state.map(item => item._id == task._id ? updatedTask : item));
  };

  const changeTitle = async (task, newTitle) => {
    const updatedTask = { ...task, newTitle };

    await updateTodo(task._id, updatedTask);

    setTasks(state =>
      state.map(item => item._id == task._id ? updatedTask : item));
  };

  return (
    <TaskContext.Provider value={{ tasks, taskDeleteHandler, toggleTask, changeTitle }}>

      <div className={styles['site-wrapper']}>
        <header>
          <h1>TODO applicaion</h1>
        </header>

        <main>
          {isLoading
            ? <p>Loading</p>
            : <TaskList />
          }

          <CreateTask taskCreateHandler={taskCreateHandler} />
        </main>
      </div>

    </TaskContext.Provider>
  );
}

export default App;
