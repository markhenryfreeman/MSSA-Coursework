var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;

function searchPokemon() {
    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += whichPokemon; // url = url + pokemon
    fetch(url)
    .then(response => response.json())
    .then(pokemon => {
        var name = document.getElementById('name');
        name.innerHTML = '<p>' + pokemon.name +'</p>';

        var  image = document.getElementById('image');
        image.innerHTML += "<img src=" + pokemon.sprites.front_shiny + ">";
        image.innerHTML += "<img src=" + pokemon.sprites.back_shiny + ">";

        var moves = document.getElementById('moves');
        var firstMove = pokemon.moves[0].move.name;
        var secondMove = pokemon.moves[1].move.name;
        var thirdMove = pokemon.moves[2].move.name;
        var fourthMove = pokemon.moves[3].move.name;
        moves.innerHTML = '<ul>' + "Top Moves: " + '</ul>' + '<li>' + firstMove + '</li>' + '<li>' + secondMove + '</li>' + '<li>' + thirdMove + '</li>' + '<li>' + fourthMove + '</li>';

        console.log(pokemon);
    }).catch(err => console.log(err))
}