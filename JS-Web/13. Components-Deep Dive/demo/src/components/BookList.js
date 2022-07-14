import { useEffect } from "react";
import { Book } from "./Book";

export const BookList = (props) => {
    // First way
    // const bookElements = [];
    // for (const book of props.books) {
    //     bookElements.push(
    //         <li>
    //             <article>
    //                 <h2>{book.title}</h2>
    //                 <div>Year: {book.year}</div>
    //                 <div>Price: {book.price}$</div>
    //                 <div>Edition: {book.edition}</div>
    //                 <footer>
    //                     <span>Author: {book.author}</span>
    //                 </footer>
    //             </article>
    //         </li>
    //     );
    // };

    // Second way
    // const bookElements = props.books.map(book => <Book
    //     title={book.title}
    //     year={book.year}
    //     price={book.price}
    //     edition={book.edition}
    //     author={book.author}
    // />);

    // Third way
    //const bookElements = props.books.map(book => <Book{...book} />);

    // Fourth way
    //const bookElements = props.books.map(book => <Book data={book} />);


    return (
        <ul style={{ backgroundColor: 'gray' }}>
            {/* {bookElements} */}

            {/* Fifth way */}
            {/* {props.books.map(book => <Book{...book} />)}; */}

            {/* Sixt way */}
            {props.books.map((x, i) => <Book key={i}{...x} />)}
        </ul>
    );
}