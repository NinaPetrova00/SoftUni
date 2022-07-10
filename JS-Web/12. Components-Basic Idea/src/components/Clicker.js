import { useState } from "react";

export const Clicker = () => {
    const [clicks, setClicks] = useState(0);

    const clickHandler = (event) => {
        console.log(event);
        // setClicks(clicks+1); 
        setClicks(oldClicks => oldClicks + 1);
    };

    const dangerClicks = clicks > 20;

    if (clicks > 30) {
        return (<h1>FInished clicks</h1>);
    };
    
    return (
        <div>
            {dangerClicks && <h1>Danger Clicks</h1>}
            {clicks > 10 ? <h3>'Medium Clicks'</h3> : <h4>'Normal clicks'</h4>}
            <button onClick={clickHandler}>{clicks}</button>
        </div>
    );
};