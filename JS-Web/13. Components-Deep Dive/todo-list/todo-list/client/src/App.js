import { Footer } from "./components/Footer";
import { LoadingSpinner } from "./components/LoadingSpinner";
import { Navigation } from "./components/Navigation";
import { TodoList } from "./components/TodoList";

function App() {
    return (
        <div>
            {/* Navigation header*/}
            <Navigation />

            {/* Main content*/}
            <main className="main">

                {/* Section container*/}
                <section className="todo-list-container">
                    <h1>Todo List</h1>

                    <div className="add-btn-container">
                        <button className="btn">+ Add new Todo</button>
                    </div>

                    <div className="table-wrapper">

                        {/* Loading spinner - show the load spinner when fetching the data from the server-->*/}
                        {/* <LoadingSpinner /> */}

                        {/* Todo list table*/}
                        <TodoList />

                    </div>
                </section>
            </main>

            {/* Footer*/}
            <Footer />

        </div>
    );
}

export default App;
