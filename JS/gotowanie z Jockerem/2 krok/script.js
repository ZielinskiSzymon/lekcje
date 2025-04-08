document.addEventListener('DOMContentLoaded', function() {
    const searchInput = document.getElementById('search-input');
    const searchBtn = document.getElementById('search-btn');
    const resultsContainer = document.getElementById('results');
    const modal = document.getElementById('recipe-modal');
    const closeBtn = document.querySelector('.close-btn');
    const tabButtons = document.querySelectorAll('.tab-btn');
    const tabContents = document.querySelectorAll('.tab-content');


    tabButtons.forEach(button => {
        button.addEventListener('click', function() {
            const tabId = this.getAttribute('data-tab');
            tabButtons.forEach(btn => btn.classList.remove('active'));
            this.classList.add('active');
            tabContents.forEach(content => {
                content.classList.remove('active');
                if (content.id === `${tabId}-tab`) {
                    content.classList.add('active');
                }
            });
        });
    });

    searchBtn.addEventListener('click', searchMeals);
    searchInput.addEventListener('keypress', function(e) {
        if (e.key === 'Enter') {
            searchMeals();
        }
    });

    closeBtn.addEventListener('click', function() {
        modal.style.display = 'none';
    });

    window.addEventListener('click', function(e) {
        if (e.target === modal) {
            modal.style.display = 'none';
        }
    });

    async function searchMeals() {
        const keyword = searchInput.value.trim();
        
        if (keyword === '') {
            alert('Proszę wpisać nazwę potrawy!');
            return;
        }

        resultsContainer.innerHTML = '<div class="no-results">Wyszukiwanie przepisów...</div>';

        try {
            const response = await fetch(`https://www.themealdb.com/api/json/v1/1/search.php?s=${keyword}`);
            const data = await response.json();

            if (data.meals && data.meals.length > 0) {
                displayMeals(data.meals, resultsContainer);
            } else {
                resultsContainer.innerHTML = '<div class="no-results">Nie znaleziono przepisów.</div>';
            }
        } catch (error) {
            resultsContainer.innerHTML = '<div class="no-results">Wystąpił błąd podczas wyszukiwania przepisów. Spróbuj ponownie później.</div>';
            console.error('Błąd:', error);
        }
    }

    function displayMeals(meals, container) {
        container.innerHTML = '';

        meals.forEach(meal => {
            
            const mealCard = document.createElement('div');
            mealCard.className = 'meal-card';
            mealCard.innerHTML = `
                <img src="${meal.strMealThumb}" alt="${meal.strMeal}" class="meal-image">
                <div class="meal-info">
                    <h3 class="meal-name">${meal.strMeal}</h3>
                    <div class="meal-category">${meal.strCategory || 'Brak kategorii'}</div>
                    <div class="meal-area">${meal.strArea || 'Brak regionu'}</div>
                    <button class="show-recipe-btn" data-id="${meal.idMeal}">Zobacz przepis</button>
                </div>
            `;

            const showRecipeBtn = mealCard.querySelector('.show-recipe-btn');
            
            showRecipeBtn.addEventListener('click', function() {
                showRecipeDetails(meal.idMeal);
            });
            
            container.appendChild(mealCard);
        });
    }

    async function showRecipeDetails(mealId) {
        try {
            const response = await fetch(`https://www.themealdb.com/api/json/v1/1/lookup.php?i=${mealId}`);
            const data = await response.json();
            
            if (data.meals && data.meals.length > 0) {
                const meal = data.meals[0];
                
                const ingredients = [];
                for (let i = 1; i <= 20; i++) {
                    const ingredient = meal[`strIngredient${i}`];
                    const measure = meal[`strMeasure${i}`];
                    
                    if (ingredient && ingredient.trim() !== '') {
                        ingredients.push({ ingredient, measure });
                    }
                }
                
                document.getElementById('modal-image').src = meal.strMealThumb;
                document.getElementById('modal-image').alt = meal.strMeal;
                document.getElementById('modal-title').textContent = meal.strMeal;
                document.getElementById('modal-category').textContent = meal.strCategory || 'Brak kategorii';
                document.getElementById('modal-area').textContent = meal.strArea || 'Brak regionu';
                
                const ingredientsContainer = document.getElementById('modal-ingredients');
                ingredientsContainer.innerHTML = '';
                ingredients.forEach(item => {
                    const ingredientItem = document.createElement('div');
                    ingredientItem.className = 'ingredient-item';
                    ingredientItem.textContent = `${item.ingredient} - ${item.measure}`;
                    ingredientsContainer.appendChild(ingredientItem);
                });
                
                document.getElementById('modal-instructions').textContent = meal.strInstructions;
                
                const youtubeContainer = document.getElementById('modal-youtube-container');
                if (meal.strYoutube) {
                    youtubeContainer.innerHTML = `
                        <a href="${meal.strYoutube}" target="_blank" class="youtube-link">
                            <i class="fab fa-youtube"></i> Zobacz film instruktażowy
                        </a>
                    `;
                } else {
                    youtubeContainer.innerHTML = '';
                }
                
                modal.style.display = 'block';
            }
        } catch (error) {
            console.error('Błąd podczas pobierania szczegółów przepisu:', error);
        }
    }   
});