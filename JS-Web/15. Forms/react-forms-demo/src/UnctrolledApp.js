import './App.css';

function App() {

    const submitHandler = (ev) => {
        ev.preventDefault();

        const formData = new FormData(ev.currentTarget);
        const username = formData.get('username');
        const password = formData.get('password');

        console.log(username);
        console.log(password);
    };

    return (
        <div className="App">
            <header className="App-header">
                <form onSubmit={submitHandler}>
                    <div>
                        <label htmlFor="username">Username:</label>
                        <input id="username" type="text" name="username"></input>
                    </div>
                    <div>
                        <label htmlFor="password">Password:</label>
                        <input id="password" type="text" name="password"></input>
                    </div>
                    <div>
                        <input type="submit" value="Login"></input>
                        {/* <button type="submit">Login</button> */}
                    </div>
                </form>
                {/* <button type="button">Login</button> */}
            </header>
        </div>
    );
}

export default App;
