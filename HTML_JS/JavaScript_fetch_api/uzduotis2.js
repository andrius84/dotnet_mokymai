
document.getElementById('get-jokes').addEventListener('click', () => {
    const jokesNumber = document.getElementById('jokes-number').value;
    getJokes(jokesNumber);
});

async function getJokes(jokesNumber) {
    try {
        await fetch(`https://api-ninjas.com/api/jokes=${jokesNumber}`)
        .then(response => response.json())
        .then(data => data.forEach((joke) => {
            const jokeContainer = document.getElementById('jokes-container');
            const p = document.createElement('p');
            p.textContent = joke.joke;
            jokeContainer.appendChild(p);
        }));
    }
    catch (error) {
        console.error('Error:', error);
    }
}
    
