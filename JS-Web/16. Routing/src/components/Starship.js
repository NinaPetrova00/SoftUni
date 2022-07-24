import { Fragment, useEffect, useState } from "react";
import { Link, useLocation, useNavigate, useParams, Route, Routes } from "react-router-dom";
import { Film } from "./Film";

export const Starship = () => {
    const [starship, setStarship] = useState({});

    //const params = useParams(); -> params.starshipId
    const { starshipId, filmId } = useParams();
    const navigate = useNavigate();

    const location = useLocation();
    console.log(location);

    useEffect(() => {
        fetch(`https://swapi.dev/api/starships/${starshipId}/`)
            .then(res => res.json())
            .then(result => {
                setStarship(result)
            })
            .catch(() => {
                navigate('/404');
            })
    }, [starshipId]);

  
    const nextProductHandler = () => {
        //Redirect to next product
        navigate(`/starships/${Number(starshipId) + 1}`);
    };


    return (
        <Fragment>
            <h2>Starship Page</h2>

            <h3>Starship {starshipId} specification:</h3>

            <ul>
                <li>Name: {starship.name}</li>
                <li>Model: {starship.model}</li>
                <li>Manufacturer: {starship.manufacturer}</li>
            </ul>

            <h3>Films</h3>
            <nav>
                <ul>
                    {starship.films?.map((f, index) =>
                        <li key={f}>
                            <Link to={`/starships/${starshipId}/films/${index}`}>Film {index}</Link>
                        </li>
                    )}
                </ul>
            </nav>

            <section>
                <Routes>
                    {/* <Route path={`films/:filmId`} element={<h3>{film.title}</h3>}></Route> */}
                    <Route path={`films/:filmId`} element={<Film films={starship.films || []}/>}></Route>
                </Routes>
            </section>

            <button onClick={nextProductHandler}>Next Starship</button>
        </Fragment >
    );
};
