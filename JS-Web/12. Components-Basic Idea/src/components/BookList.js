import { Book } from "./Book";

export const BookList = (props) => {
    return (
        <ul>
            <Book
                title={props.bookList[0].title}
                author={props.bookList[0].author}
                year={props.bookList[0].year}
                edition={props.bookList[0].edition}
                price={props.bookList[0].price}
            />
            <Book
                title={props.bookList[1].title}
                author={props.bookList[1].author}
                year={props.bookList[1].year}
                edition={props.bookList[1].edition}
                price={props.bookList[1].price}
            />
            <Book
                title={props.bookList[2].title}
                author={props.bookList[2].author}
                year={props.bookList[2].year}
                edition={props.bookList[2].edition}
                price={props.bookList[2].price}
            />
        </ul>
    );
};