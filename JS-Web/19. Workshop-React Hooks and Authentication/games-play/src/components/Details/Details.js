import { useEffect, useState } from 'react';
import { useParams, Link } from 'react-router-dom';
import * as gameService from '../../services/gameService';

export const Details = ({
    addComment
}) => {

    const { gameId } = useParams();
    const [currentGame, setCurrentGame] = useState({});

    const [comment, setComment] = useState({
        username: '',
        comment: ''
    });

    const [error, setError] = useState({
        username: '',
        comment: ''
    });

    useEffect(() => {
        gameService.getOne(gameId)
            .then(result => {
                setCurrentGame(result);
            });
    })

    const addCommentHandler = (ev) => {
        ev.preventDefault();

        const userComment = `${comment.username}: ${comment.comment}`;

        addComment(gameId, userComment);
    };

    const onChange = (ev) => {
        setComment(oldState => ({
            ...oldState,
            [ev.target.name]: ev.target.value
        }));
    };

    const validateUsername = (ev) => {
        const username = ev.target.value;

        let errorMessage = '';

        if (username.length < 4) {
            errorMessage = 'Username must be longer than 4 characters!';
        } else if (username.length > 10) {
            errorMessage = 'Username must be shorter than 10 characters!';
        }

        setError(oldState => ({
            ...oldState,
            username: errorMessage
        }));
    };

    return (
        <section id="game-details">
            <h1>Game Details</h1>
            <div className="info-section">
                <div className="game-header">
                    <img className="game-img" src={currentGame.imageUrl} />
                    <h1>{currentGame.title}</h1>
                    <span className="levels">MaxLevel: {currentGame.maxLevel}</span>
                    <p className="type">{currentGame.category}</p>
                </div>
                <p className="text">{currentGame.summary} </p>

                <div className="details-comments">
                    {/* <h2>Comments:</h2>
                    <ul>
                        {currentGame.comments?.map(c =>
                            <li className="comment">
                                <p>{c}</p>
                            </li>
                        )}
                    </ul>
                    {!currentGame.comments &&
                        <p className="no-comment">No comments.</p>
                    } */}

                </div>
                {/* Edit/Delete buttons ( Only for creator of this game )  */}
                <div className="buttons">
                    <Link to={`/catalogue/${gameId}/edit`} className="button">
                        Edit
                    </Link>
                    <Link to='#' className="button">
                        Delete
                    </Link>
                </div>
            </div>

            <article className="create-comment">
                <label>Add new comment:</label>
                <form className="form" onSubmit={addCommentHandler}>
                    <input
                        type="text"
                        name="username"
                        placeholder="John Doe"
                        onChange={onChange}
                        onBlur={validateUsername}
                        value={comment.username}
                    />
                    {error.username &&
                        <div style={{ color: 'red' }}>{error.username}</div>
                    }
                    <textarea
                        name="comment"
                        placeholder="Comment......"
                        onChange={onChange}
                        value={comment.comment}
                    />

                    <input
                        className="btn submit"
                        type="submit"
                        value="Add Comment"
                    />
                </form>
            </article>
        </section>
    );
};