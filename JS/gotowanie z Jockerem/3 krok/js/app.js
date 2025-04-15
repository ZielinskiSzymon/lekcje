const searchInput = document.getElementById('search-input');
const searchBtn = document.getElementById('search-btn');
const resultsContainer = document.getElementById('results-container');
const favoritesContainer = document.getElementById('favorites-container');
const modal = document.getElementById('recipe-modal');
const closeBtn = document.querySelector('.close-btn');
const modalTitle = document.getElementById('modal-title');
const modalImage = document.getElementById('modal-image');
const modalCategory = document.getElementById('modal-category');
const modalArea = document.getElementById('modal-area');
const ingredientsList = document.getElementById('ingredients-list');
const modalInstructions = document.getElementById('modal-instructions');
const youtubeContainer = document.getElementById('youtube-container');
const youtubeLink = document.getElementById('youtube-link');
const modalFavoriteBtn = document.getElementById('modal-favorite-btn');
const tabBtns = document.querySelectorAll('.tab-btn');
const tabContents = document.querySelectorAll('.tab-content');

let currentMealId = null;
let favorites = JSON.parse(localStorage.getItem('favorites')) || [];

document.addEventListener('DOMContentLoaded', () => {
    displayFavorites();
    document.querySelector('h1').addEventListener('dblclick', () => {
        getRandomRecipe();
    });
});

tabBtns.forEach(btn => {
    btn.addEventListener('click', () => {
        const tabId = btn.getAttribute('data-tab');
        tabBtns.forEach(b => b.classList.remove('active'));
        tabContents.forEach(c => c.classList.remove('active'));
        btn.classList.add('active');
        document.getElementById(`${tabId}-tab`).classList.add('active');
    });
});

searchBtn.addEventListener('click', searchRecipes);
searchInput.addEventListener('keypress', (e) => {
    if (e.key === 'Enter') {
        searchRecipes();
    }
});

async function searchRecipes() {
    const searchTerm = searchInput.value.trim();
    
    if (!searchTerm) {
        return;
    }
    
    resultsContainer.innerHTML = '<div class="loading">Szukam przepisów...</div>';
    
    try {
        const response = await fetch(`https://www.themealdb.com/api/json/v1/1/search.php?s=${searchTerm}`);
        const data = await response.json();
        
        resultsContainer.innerHTML = '';
        
        if (data.meals) {
            data.meals.forEach(meal => {
                const isFavorite = favorites.some(fav => fav.idMeal === meal.idMeal);
                createMealCard(meal, isFavorite);
            });
            
        } else {
            resultsContainer.innerHTML = '<p class="no-results">Nie znaleziono przepisów. Spróbuj wpisać inną nazwę potrawy.</p>';
        }
    } catch (error) {
        console.error('Błąd podczas wyszukiwania przepisów:', error);
        resultsContainer.innerHTML = '<p class="no-results">Wystąpił błąd podczas wyszukiwania przepisów. Spróbuj ponownie później.</p>';
    }
}

async function getRandomRecipe() {
    try {
        const response = await fetch('https://www.themealdb.com/api/json/v1/1/random.php');
        const data = await response.json();
        
        if (data.meals && data.meals.length > 0) {
            showRecipeDetails(data.meals[0].idMeal);
        }
    } catch (error) {
        console.error('Błąd podczas pobierania losowego przepisu:', error);
    }
}

function createMealCard(meal, isFavorite = false, container = resultsContainer) {
    const mealCard = document.createElement('div');
    mealCard.className = 'meal-card';
    mealCard.dataset.id = meal.idMeal;
    
    mealCard.innerHTML = `
        <img src="${meal.strMealThumb}" alt="${meal.strMeal}" class="meal-image">
        <div class="meal-info">
            <h3 class="meal-name">${meal.strMeal}</h3>
            <p class="meal-category">Kategoria: ${meal.strCategory}</p>
            <p class="meal-area">Kuchnia: ${meal.strArea}</p>
            <button class="show-recipe-btn" data-id="${meal.idMeal}">Pokaż przepis</button>
            <button class="favorite-btn ${isFavorite ? 'favorited' : ''}" data-id="${meal.idMeal}">
                <i class="${isFavorite ? 'fas' : 'far'} fa-heart"></i> ${isFavorite ? 'W ulubionych' : 'Dodaj do ulubionych'}
            </button>
        </div>
    `;
    
    container.appendChild(mealCard);
    
    mealCard.querySelector('.show-recipe-btn').addEventListener('click', () => {
        showRecipeDetails(meal.idMeal);
    });
    
    mealCard.querySelector('.favorite-btn').addEventListener('click', (e) => {
        e.stopPropagation();
        toggleFavorite(meal);
    });
}

async function showRecipeDetails(mealId) {
    try {
        const response = await fetch(`https://www.themealdb.com/api/json/v1/1/lookup.php?i=${mealId}`);
        const data = await response.json();
        
        if (data.meals) {
            const meal = data.meals[0];
            currentMealId = meal.idMeal;
            
            modalTitle.textContent = meal.strMeal;
            modalImage.src = meal.strMealThumb;
            modalImage.alt = meal.strMeal;
            modalCategory.textContent = `Kategoria: ${meal.strCategory}`;
            modalArea.textContent = `Kuchnia: ${meal.strArea}`;
            
            ingredientsList.innerHTML = '';
            for (let i = 1; i <= 20; i++) {
                const ingredient = meal[`strIngredient${i}`];
                const measure = meal[`strMeasure${i}`];
                
                if (ingredient && ingredient.trim() !== '') {
                    const ingredientItem = document.createElement('div');
                    ingredientItem.className = 'ingredient-item';
                    ingredientItem.textContent = `${ingredient} - ${measure}`;
                    ingredientsList.appendChild(ingredientItem);
                }
            }
            
            modalInstructions.textContent = meal.strInstructions;
            
            if (meal.strYoutube) {
                youtubeContainer.style.display = 'block';
                youtubeLink.href = meal.strYoutube;
            } else {
                youtubeContainer.style.display = 'none';
            }
            
            const isFavorite = favorites.some(fav => fav.idMeal === meal.idMeal);
            updateFavoriteButton(modalFavoriteBtn, isFavorite);
            
            modalFavoriteBtn.onclick = () => toggleFavorite(meal);
            
            modal.style.display = 'block';
        }
    } catch (error) {
        console.error('Błąd podczas pobierania szczegółów przepisu:', error);
    }
}

function toggleFavorite(meal) {
    const index = favorites.findIndex(fav => fav.idMeal === meal.idMeal);
    
    if (index === -1) {
        favorites.push(meal);
    } else {
        favorites.splice(index, 1);
    }
    
    localStorage.setItem('favorites', JSON.stringify(favorites));
    updateFavoriteButtons(meal.idMeal);
    displayFavorites();
}

function updateFavoriteButtons(mealId) {
    const favoriteBtns = document.querySelectorAll(`.favorite-btn[data-id="${mealId}"]`);
    const isFavorite = favorites.some(fav => fav.idMeal === mealId);
    
    favoriteBtns.forEach(btn => {
        updateFavoriteButton(btn, isFavorite);
    });
    
    if (currentMealId === mealId) {
        updateFavoriteButton(modalFavoriteBtn, isFavorite);
    }
}

function updateFavoriteButton(button, isFavorite) {
    if (isFavorite) {
        button.innerHTML = '<i class="fas fa-heart"></i> W ulubionych';
        button.classList.add('favorited');
    } else {
        button.innerHTML = '<i class="far fa-heart"></i> Dodaj do ulubionych';
        button.classList.remove('favorited');
    }
}

function displayFavorites() {
    favoritesContainer.innerHTML = '';
    
    if (favorites.length === 0) {
        favoritesContainer.innerHTML = '<p class="favorites-empty">Nie masz jeszcze ulubionych przepisów.</p>';
        return;
    }
    
    favorites.forEach(meal => {
        createMealCard(meal, true, favoritesContainer);
    });
}

closeBtn.addEventListener('click', () => {
    modal.style.display = 'none';
});

window.addEventListener('click', (e) => {
    if (e.target === modal) {
        modal.style.display = 'none';
    }
});

document.addEventListener('keydown', (e) => {
    if (e.key === 'Escape' && modal.style.display === 'block') {
        modal.style.display = 'none';
    }
});
