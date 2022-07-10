import React from 'react';

export const Timer = (props) => {
    //const [time, setTimeFunction] = React.useState(0);
    const [time, setTimeFunction] = React.useState(props.start);

    console.log('render');

    setTimeout(() => {
        if(time<100){
            setTimeFunction(time+1);
        }
    }, 1000);

    return (
        <div>
            <h2>Timer: {time} sec</h2>
        </div>
    );
};