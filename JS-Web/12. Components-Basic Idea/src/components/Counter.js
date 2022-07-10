import { useState } from "react";

export const Counter = (props) => {
    const [count, setCount] = useState(props.start || 0);
    const [direction, setDirection] = useState('None');

    const increaseHandler = () => {
        setCount(oldCount => oldCount + 1);
        setDirection('Increment');
    };
    const decreaseHandler = () => {
        setCount(oldCount => oldCount - 1);
        setDirection('Decrement');
    };

    const clearHandler = () => {
        setCount(0);
    };

    let title = '';

    if (count < 10) {
        title = 'Counter';
    } else if (count < 20) {
        title = 'Counter 2.0';
    } else if (count < 30) {
        title = 'Counter 3.0';
    } else {
        title = 'Counter Beta';
    };

    return (
        <div>
            <h1 style={{ fontSize: 16 + count + 'px' }}>{direction}: {title}</h1>
            <h2>{count}</h2>
            <button onClick={decreaseHandler}>-</button>
            <button onClick={clearHandler}>Clear</button>
            <button onClick={increaseHandler}>+</button>
        </div >
    );
}