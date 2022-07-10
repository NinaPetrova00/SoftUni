export const Book = (props) => {
    return (
        <article>
            <h2>{props.title}</h2>
            <div>Year: {props.year}</div>
            <div>Price: {props.price}$</div>
            <div>Edition: {props.edition}</div>
            <footer>
                <span>Author: {props.author}</span>
            </footer>
        </article>
    );
};