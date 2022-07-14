import { useState, useEffect } from "react";
import styles from './Book.module.css';

export const Book = (props) => {
    const [highlighted, setHighlited] = useState(false);
    const [deleted, setDeleted] = useState(false);

    const clickHandler = () => {
        //setHighlited(true);
        setHighlited(oldState => !oldState);
    };
    const deleteClickHandler = () => {
        setDeleted(true);
    };

    useEffect(() => {
        console.log('Mounting');
    }, []);

    useEffect(() => {
        console.log('Updating' + props.title);
    }, [highlighted]);

    let style = {};
    if (highlighted) {
        style.backgroundColor = 'pink';
    };

    if (deleted) {
        return <h2>Deleted</h2>
    };

    return (
        //<li style={style} className={classnames(styles['book-item'], styles['other-class'])}>
        
        <li style={style} className={`${styles['book-item']} ${styles['other-class']}`}>
            <article>
                <h2>{props.title}</h2>
                <div>Year: {props.year}</div>
                <div>Price: {props.price}$</div>
                <div>Edition: {props.edition}</div>
                <footer>
                    <button onClick={clickHandler}>Highlight</button>
                    <button onClick={deleteClickHandler}>Delete</button>
                    <span className={styles.author}>Author: {props.author}</span>
                </footer>
            </article>
        </li>
    );
};
