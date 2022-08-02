import { Link } from 'react-router-dom';

export const CatalogueItem = ({ game }) => {
    return (
        <div className="allGames">
            <div className="allGames-info">
                <img src={game.imageUrl} />
                <h6>{game.category}</h6>
                <h2>{game.title}</h2>
                <Link key={game._id} to={`/catalogue/${game._id}`} className="details-button">
                    Details
                </Link>
                <Link to={`/catalogue/${game._id}/edit`} className="details-button"
                    style={{ marginLeft: '150px' }}>
                    Edit
                </Link>
            </div>
        </div>
    );
};