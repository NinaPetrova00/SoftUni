const baseUrl = 'https://swapi.dev/api';


// function declaration
async function getStarWarsCharacter(id) {
    let response = await fetch(`${baseUrl}/${id}`);
    let character = await response.json();

    return 'Pesho';
}

let name = getStarWarsCharacter(4);
console.log(name);
// // function expression
// const getStarWarsCharacter = async function () {

// }

// // arrow funtion
// const getStarWarsCharacter = async () => {

// }