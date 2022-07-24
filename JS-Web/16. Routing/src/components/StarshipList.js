import { Fragment, useEffect, useState } from "react";
import { Link } from 'react-router-dom';

export const StarshipList = () => {
    const [starships, setStarship] = useState([]);

    useEffect(() => {
        fetch('https://swapi.dev/api/starships')
            .then(res => res.json())
            .then(result => {
                setStarship(result.results);
            })
    }, []);

    return (
        <Fragment>
            <h3>Starhips:</h3>
            <ul>
                console.log(starship.index);
                {starships.map((s, index) => <li><Link key={s.name} to={`/starships/${index + 1}`}>{s.name}</Link></li>)}
            </ul>
        </Fragment>

    );
}