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
        showNotification('Proszę wpisać nazwę potrawy', 'error');
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
            
            showNotification(`Znaleziono ${data.meals.length} przepisów`, 'success');
        } else {
            resultsContainer.innerHTML = '<p class="no-results">Nie znaleziono przepisów. Spróbuj wpisać inną nazwę potrawy.</p>';
            showNotification('Nie znaleziono przepisów', 'warning');
        }
    } catch (error) {
        console.error('Błąd podczas wyszukiwania przepisów:', error);
        resultsContainer.innerHTML = '<p class="no-results">Wystąpił błąd podczas wyszukiwania przepisów. Spróbuj ponownie później.</p>';
        showNotification('Błąd podczas wyszukiwania przepisów', 'error');
    }
}

async function getRandomRecipe() {
    try {
        const response = await fetch('https://www.themealdb.com/api/json/v1/1/random.php');
        const data = await response.json();
        
        if (data.meals && data.meals.length > 0) {
            showRecipeDetails(data.meals[0].idMeal);
            showNotification('Wylosowano przepis dla Ciebie!', 'success');
        }
    } catch (error) {
        console.error('Błąd podczas pobierania losowego przepisu:', error);
        showNotification('Nie udało się pobrać losowego przepisu', 'error');
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
        showNotification('Wystąpił błąd podczas pobierania szczegółów przepisu', 'error');
    }
}

function toggleFavorite(meal) {
    const index = favorites.findIndex(fav => fav.idMeal === meal.idMeal);
    
    if (index === -1) {
        favorites.push(meal);
        showNotification(`"${meal.strMeal}" dodano do ulubionych`, 'success');
    } else {
        favorites.splice(index, 1);
        showNotification(`"${meal.strMeal}" usunięto z ulubionych`, 'info');
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

function showNotification(message, type = 'info') {
    let notificationContainer = document.getElementById('notification-container');
    
    if (!notificationContainer) {
        notificationContainer = document.createElement('div');
        notificationContainer.id = 'notification-container';
        notificationContainer.style.position = 'fixed';
        notificationContainer.style.bottom = '20px';
        notificationContainer.style.right = '20px';
        notificationContainer.style.zIndex = '9999';
        document.body.appendChild(notificationContainer);
    }
    
    const notification = document.createElement('div');
    notification.className = `notification ${type}`;
    notification.style.backgroundColor = getNotificationColor(type);
    notification.style.color = '#fff';
    notification.style.padding = '12px 20px';
    notification.style.marginTop = '10px';
    notification.style.borderRadius = '4px';
    notification.style.boxShadow = '0 2px 5px rgba(0,0,0,0.2)';
    notification.style.display = 'flex';
    notification.style.alignItems = 'center';
    notification.style.justifyContent = 'space-between';
    notification.style.minWidth = '250px';
    notification.style.maxWidth = '350px';
    notification.style.transform = 'translateX(400px)';
    notification.style.transition = 'all 0.3s ease-in-out';
    
    const icon = document.createElement('i');
    icon.className = getNotificationIcon(type);
    icon.style.marginRight = '10px';
    
    const text = document.createElement('span');
    text.textContent = message;
    text.style.flex = '1';
    
    const closeButton = document.createElement('span');
    closeButton.innerHTML = '&times;';
    closeButton.style.marginLeft = '10px';
    closeButton.style.cursor = 'pointer';
    closeButton.style.fontSize = '20px';
    
    closeButton.addEventListener('click', () => {
        notification.style.opacity = '0';
        notification.style.transform = 'translateX(400px)';
        setTimeout(() => notification.remove(), 300);
    });
    
    notification.appendChild(icon);
    notification.appendChild(text);
    notification.appendChild(closeButton);
    
    notificationContainer.appendChild(notification);
    
    setTimeout(() => {
        notification.style.transform = 'translateX(0)';
    }, 10);
    
    setTimeout(() => {
        if (notification.parentNode) {
            notification.style.opacity = '0';
            notification.style.transform = 'translateX(400px)';
            setTimeout(() => notification.remove(), 300);
        }
    }, 5000);
}

function getNotificationColor(type) {
    switch (type) {
        case 'success': return '#2ecc71';
        case 'error': return '#e74c3c';
        case 'warning': return '#f39c12';
        case 'info': return '#3498db';
        default: return '#3498db';
    }
}

function getNotificationIcon(type) {
    switch (type) {
        case 'success': return 'fas fa-check-circle';
        case 'error': return 'fas fa-exclamation-circle';
        case 'warning': return 'fas fa-exclamation-triangle';
        case 'info': return 'fas fa-info-circle';
        default: return 'fas fa-info-circle';
    }
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
