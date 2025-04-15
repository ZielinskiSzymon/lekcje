const apiUrl = "https://restcountries.com/v3.1/all";
const usedCountries = [];
const flagImg = document.querySelector('.flag');
const buttons = [
    document.querySelector('.nazwaKraju1'),
    document.querySelector('.nazwaKraju2'),
    document.querySelector('.nazwaKraju3'),
    document.querySelector('.nazwaKraju4')
];
const resultDiv = document.querySelector('.result');
const zyciaDiv = document.querySelector('.zycia');
const pointsSpan = document.querySelector('.punkty');

let currentCountry;
let points = 0;
let countries;
let zycia = 3;

initializeGame();

async function initializeGame() {
    try {
        const response = await fetch(apiUrl);
        if (!response.ok) {
            throw new Error("Błąd podczas pobierania danych");
        }
        countries = await response.json();
        startNewRound();
    } catch (error) {
        console.error(error.message);
        resultDiv.textContent = "Wystąpił błąd podczas ładowania danych. Proszę odświeżyć stronę.";
    }
}

function startNewRound() {
    resultDiv.textContent = "";
    
    const correctCountryIndex = generateRandomIndex(countries.length);
    currentCountry = countries[correctCountryIndex];
    
    flagImg.src = currentCountry.flags.png;
    flagImg.alt = `Flaga kraju ${currentCountry.name.common}`;
    
    const options = [currentCountry];
    while (options.length < 4) {
        const randomIndex = generateRandomIndex(countries.length);
        const randomCountry = countries[randomIndex];
        if (!options.some(country => country.name.common === randomCountry.name.common)) {
            options.push(randomCountry);
        }
    }
    
    shuffleArray(options);
    
    options.forEach((country, index) => {
        buttons[index].value = country.name.common;
        buttons[index].onclick = () => checkAnswer(country.name.common);
    });
}

function generateRandomIndex(max) {
    return Math.floor(Math.random() * max);
}

function shuffleArray(array) {
    for (let i = array.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [array[i], array[j]] = [array[j], array[i]];
    }
    return array;
}

function checkAnswer(selectedCountry) {
    const isCorrect = selectedCountry === currentCountry.name.common;
    
    if (isCorrect) {
        points++;
        pointsSpan.textContent = `Punkty: ${points}`;
        resultDiv.textContent = "Poprawna odpowiedź!";
        resultDiv.style.color = "green";
    } else {
        --zycia
            
        zyciaDiv.textContent = "";
        
        for(let i=0; i<zycia; i++)
            zyciaDiv.textContent += "💗"
        if(zycia == 0){
            przegrana()
            return;
        }
        
        resultDiv.textContent = `Błędna odpowiedź! Prawidłowa to: ${currentCountry.name.common}`;
        resultDiv.style.color = "red";
    }
    
    buttons.forEach(button => button.disabled = true);
    

    setTimeout(() => {
        buttons.forEach(button => button.disabled = false);
        startNewRound();
    }, 2000);
}

async function przegrana() {
    buttons.forEach(element => {
        element.disabled = true
    });
    resultDiv.textContent = `Przegrałeś zdobyłeś ${points} punkty`
}

function addRestartButton() {
    // Create restart button
    const restartButton = document.createElement('button');
    restartButton.textContent = 'Zagraj ponownie';
    restartButton.classList.add('restart-button');
    restartButton.onclick = resetGame;
    
    // Add to the results div when game is over
    resultDiv.appendChild(document.createElement('br'));
    resultDiv.appendChild(restartButton);
}

function resetGame() {
    // Reset game state
    points = 0;
    zycia = 3;
    
    // Update UI
    pointsSpan.textContent = `Punkty: ${points}`;
    zyciaDiv.textContent = "💗💗💗";
    resultDiv.textContent = "";
    
    // Enable buttons
    buttons.forEach(button => button.disabled = false);
    
    // Start new round
    startNewRound();
}

// Modify the przegrana function to include restart button
async function przegrana() {
    buttons.forEach(element => {
        element.disabled = true
    });
    resultDiv.textContent = `Przegrałeś! Zdobyłeś ${points} punkty`;
    
    // Add restart button
    addRestartButton();
}