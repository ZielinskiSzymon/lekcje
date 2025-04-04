document.addEventListener('DOMContentLoaded', function() {
  document.getElementById('checkWeather').addEventListener('click', getWeather);
  
  // Dodanie obsługi Enter w polu input
  document.getElementById('city').addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
      getWeather();
    }
  });
  
  // Sprawdź pogodę dla domyślnego miasta (Warszawa) przy pierwszym załadowaniu
  document.getElementById('city').value = 'Warszawa';
  getWeather();
});
const locationInfo = document.createElement('h3');

async function getWeather() {
  const city = document.getElementById('city').value.trim();
  const weatherInfo = document.getElementById('weatherInfo');
  const weatherIcon = document.getElementById('weatherIcon');
  const temperature = document.getElementById('temperature');
  const weatherDetails = document.getElementById('weatherDetails');
  const updateTime = document.getElementById('updateTime');
  
  weatherInfo.style.display = 'none';
  weatherIcon.innerHTML = '';
  temperature.innerHTML = '';
  weatherDetails.innerHTML = '';
  
  if (!city) {
      showError('Proszę wpisać nazwę miasta!');
      return;
  }
  
  const apiKey = '1358cadb264b4452b7c92335250104'; // Twój klucz API z WeatherAPI
  const url = `https://api.weatherapi.com/v1/current.json?key=${apiKey}&q=${city}&lang=pl`;
  
  try {
      // Pokazanie animacji ładowania
      weatherInfo.style.display = 'block';
      weatherIcon.innerHTML = '<i class="fas fa-spinner fa-spin"></i>';
      temperature.textContent = '...';
      
      const response = await fetch(url);
      if (!response.ok) {
          throw new Error('Nie znaleziono miasta! Sprawdź nazwę i spróbuj ponownie.');
      }
      
      const data = await response.json();
      
      // Aktualizacja czasu
      const now = new Date();
      updateTime.textContent = `Ostatnia aktualizacja: ${now.toLocaleTimeString()}`;
      
      // Ustawienie ikony pogody
      const weatherCode = data.current.condition.code;
      const isDay = data.current.is_day;
      setWeatherIcon(weatherIcon, weatherCode, isDay);
      
      // Ustawienie temperatury
      temperature.innerHTML = `${Math.round(data.current.temp_c)}<span class="degree">°C</span>`;
      
      // Ustawienie szczegółów pogody
      weatherDetails.innerHTML = `
          <p><i class="fas fa-info-circle"></i> <span>${data.current.condition.text}</span></p>
          <p><i class="fas fa-temperature-high"></i> <span>Odczuwalna: ${Math.round(data.current.feelslike_c)}°C</span></p>
          <p><i class="fas fa-tint"></i> <span>Wilgotność: ${data.current.humidity}%</span></p>
          <p><i class="fas fa-wind"></i> <span>Wiatr: ${data.current.wind_kph} km/h</span></p>
          <p><i class="fas fa-compress-alt"></i> <span>Ciśnienie: ${data.current.pressure_mb} hPa</span></p>
          <p><i class="fas fa-eye"></i> <span>Widoczność: ${data.current.vis_km} km</span></p>
      `;
      
      // Pokazanie informacji o lokalizacji
      locationInfo.textContent = `${data.location.name}, ${data.location.country}`;
      weatherInfo.insertBefore(locationInfo, weatherInfo.firstChild);
      
      weatherInfo.style.display = 'block';
      
  } catch (error) {
      showError(error.message);
  }
}

function setWeatherIcon(element, code, isDay) {
  const iconMap = {
      1000: isDay ? 'fa-sun' : 'fa-moon', // Sunny / Clear
      1003: isDay ? 'fa-cloud-sun' : 'fa-cloud-moon', // Partly cloudy
      1006: 'fa-cloud', // Cloudy
      1009: 'fa-cloud', // Overcast
      1030: 'fa-smog', // Mist
      1063: 'fa-cloud-rain', // Patchy rain possible
      1066: 'fa-snowflake', // Patchy snow possible
      1069: 'fa-cloud-meatball', // Patchy sleet possible
      1072: 'fa-cloud-meatball', // Patchy freezing drizzle possible
      1087: 'fa-bolt', // Thundery outbreaks possible
      1114: 'fa-wind', // Blowing snow
      1117: 'fa-wind', // Blizzard
      1135: 'fa-smog', // Fog
      1147: 'fa-smog', // Freezing fog
      1150: 'fa-cloud-rain', // Patchy light drizzle
      1153: 'fa-cloud-rain', // Light drizzle
      1168: 'fa-cloud-rain', // Freezing drizzle
      1171: 'fa-cloud-rain', // Heavy freezing drizzle
      1180: 'fa-cloud-rain', // Patchy light rain
      1183: 'fa-cloud-rain', // Light rain
      1186: 'fa-cloud-showers-heavy', // Moderate rain at times
      1189: 'fa-cloud-showers-heavy', // Moderate rain
      1192: 'fa-cloud-showers-heavy', // Heavy rain at times
      1195: 'fa-cloud-showers-heavy', // Heavy rain
      1198: 'fa-temperature-low', // Light freezing rain
      1201: 'fa-temperature-low', // Moderate or heavy freezing rain
      1204: 'fa-cloud-meatball', // Light sleet
      1207: 'fa-cloud-meatball', // Moderate or heavy sleet
      1210: 'fa-snowflake', // Patchy light snow
      1213: 'fa-snowflake', // Light snow
      1216: 'fa-snowflake', // Patchy moderate snow
      1219: 'fa-snowflake', // Moderate snow
      1222: 'fa-snowflake', // Patchy heavy snow
      1225: 'fa-snowflake', // Heavy snow
      1237: 'fa-icicles', // Ice pellets
      1240: 'fa-cloud-showers-heavy', // Light rain shower
      1243: 'fa-cloud-showers-heavy', // Moderate or heavy rain shower
      1246: 'fa-cloud-showers-heavy', // Torrential rain shower
      1249: 'fa-cloud-meatball', // Light sleet showers
      1252: 'fa-cloud-meatball', // Moderate or heavy sleet showers
      1255: 'fa-snowflake', // Light snow showers
      1258: 'fa-snowflake', // Moderate or heavy snow showers
      1261: 'fa-icicles', // Light showers of ice pellets
      1264: 'fa-icicles', // Moderate or heavy showers of ice pellets
      1273: 'fa-bolt', // Patchy light rain with thunder
      1276: 'fa-bolt', // Moderate or heavy rain with thunder
      1279: 'fa-bolt', // Patchy light snow with thunder
      1282: 'fa-bolt', // Moderate or heavy snow with thunder
  };
  
  const defaultIcon = isDay ? 'fa-cloud-sun' : 'fa-cloud-moon';
  const iconClass = iconMap[code] || defaultIcon;
  
  element.innerHTML = `<i class="fas ${iconClass}"></i>`;
}

function showError(message) {
  const weatherInfo = document.getElementById('weatherInfo');
  weatherInfo.innerHTML = `<p class="error">${message}</p>`;
  weatherInfo.style.display = 'block';
}