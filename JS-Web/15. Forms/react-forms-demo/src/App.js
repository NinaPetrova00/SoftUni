import { useState, useRef, useEffect } from 'react';
import './App.css';

function App() {

    const infoRef = useRef();

    const [formState, setFormState] = useState({
        username: '',
        password: '',
        age: '',
        bio: '',
        gender: 'f',
        userType: 'corporate',
        tac: false,
        egn: '',
        eik: '',
    });

    useEffect(() => {
        if (formState.username && formState.age) {
            infoRef.current.value = `${formState.username} - ${formState.age}`;
        }
    }, [formState.username, formState.age]);


    // const [username, setUsername] = useState('');
    // const [password, setPassword] = useState('');
    // const [age, setAge] = useState(0);
    // const [bio, setBio] = useState('');
    // const [gender, setGender] = useState('m');
    // const [userType, setUserType] = useState('corporate');
    // const [tac, setTac] = useState(false);

    const changeHandler = (ev) => {
        //console.log(ev.target.name, ' - ', ev.target.value);

        setFormState(oldState => ({
            ...oldState,
            [ev.target.name]: ev.target.type == 'checkbox' ? ev.target.checked : ev.target.value
        }));

        //console.log(formState);
    };

    // const checkBoxChangeHandler = (ev) => {
    //     console.log(ev.target.name, ' - ', ev.target.checked);

    //     setFormState(oldState => ({
    //         ...oldState,
    //         [ev.target.name]: ev.target.checked
    //     }));
    // };

    const submitHandler = (ev) => {
        ev.preventDefault();
        // let values = Object.fromEntries(new FormData(ev.target));
        // console.log(values);
        // console.log('username: ', username);
        // console.log('password: ', password);
        // console.log('age: ', age);
        // console.log('gender: ', gender);
        // console.log('userType: ', userType);
        // console.log('tac: ', tac);
    };

    // const usernameChangeHandler = (ev) => {
    //     setUsername(ev.target.value);
    // };

    return (
        <div className="App">
            <header className="App-header">
                <form onSubmit={submitHandler}>
                    <div>
                        <label htmlFor="username">Username:</label>
                        <input type="text" name="username" onChange={changeHandler} value={formState.username} />
                    </div>

                    <div>
                        <label htmlFor="password">Password:</label>
                        <input id="password" type="text" name="password" value={formState.password} onChange={changeHandler}></input>
                    </div>

                    <div>
                        <label htmlFor="age">Age:</label>
                        <input id="age" type="number" name="age" value={formState.age} onChange={changeHandler}></input>
                        {/* <input id="age" type="number" name="age" value={age} onChange={(ev) => setAge(Number(ev.target.value))}></input> */}
                    </div>

                    <div>
                        <label htmlFor="bio">Bio:</label>
                        <textarea name="bio" id="bio" cols="30" rows="10" value={formState.bio} onChange={changeHandler}></textarea>
                    </div>

                    <div>
                        <label htmlFor="gender">Gender:</label>
                        <select name="gender" id="gender" value={formState.gender} onChange={changeHandler}>
                            <option value="m">Male</option>
                            <option value="f">Female</option>
                        </select>
                    </div>

                    <div>
                        <label htmlFor="individual-user-type">Individual:</label>
                        <input type="radio" name="userType" value="individual" id="individual-user-type"
                            onChange={changeHandler}
                            checked={formState.userType == 'individual'} />

                        <label htmlFor="corporate-user-type">Corporate:</label>
                        <input type="radio" name="userType" value="corporate" id="corporate-user-type"
                            onChange={changeHandler}
                            checked={formState.userType == 'corporate'} />
                    </div>

                    <div>
                        <label htmlFor="identifier">
                            {formState.userType == 'individual' ? 'EGN' : 'EIK'}
                        </label>
                        {formState.userType == 'individual'
                            ? <input type="text" id="Identifier" name="egn" value={formState.egn} onChange={changeHandler} />
                            : <input type="text" id="Identifier" name="eik" value={formState.eik} onChange={changeHandler} />}
                    </div>

                    <div>
                        <label htmlFor="tac">Terms and Conditions</label>
                        <input type="checkbox" name="tac" id="tac" checked={formState.tac} onChange={changeHandler} />
                    </div>

                    <div>
                        <input type="submit" value="Register" disabled={!formState.tac}></input>
                        {/* <button type="submit">Login</button> */}
                    </div>

                    <div>
                        <label htmlFor="uncontrolled-input">Uncontrolled Input: </label>
                        <input type="text" name="uncontrolled" id="uncontrolled" ref={infoRef} />
                    </div>

                </form>
                {/* <button type="button">Login</button> */}
            </header>
        </div>
    );
}

export default App;
