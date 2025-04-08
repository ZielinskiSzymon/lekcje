document.addEventListener('DOMContentLoaded', function() {
  document.getElementById('checkWeather').addEventListener('click', getWeather);
  
  document.getElementById('city').addEventListener('keypress', function(e) {
    if (e.key === 'Enter') {
      getWeather();
    }
  });
  
  document.getElementById('city').value = 'Brzesko';
  getWeather();
});

async function getWeather() {
  const city = document.getElementById('city').value.trim();
  const weatherInfo = document.getElementById('weatherInfo');
  const weatherIcon = document.getElementById('weatherIcon');
  const temperature = document.getElementById('temperature');
  const weatherDetails = document.getElementById('weatherDetails');
  const updateTime = document.getElementById('updateTime');
  
  const existingLocationInfo = weatherInfo.querySelector('h3');
  if (existingLocationInfo) {
    existingLocationInfo.remove();
  }
  
  const locationInfo = document.createElement('h3');
  
  weatherInfo.style.display = 'none';
  weatherIcon.innerHTML = '';
  temperature.innerHTML = '';
  weatherDetails.innerHTML = '';
  
  if (!city) {
      showError('Proszę wpisać nazwę miasta!');
      return;
  }
  
  const apiKey = '1358cadb264b4452b7c92335250104';
  const url = `https://api.weatherapi.com/v1/current.json?key=${apiKey}&q=${city}&lang=pl`;
  
  try {
      weatherInfo.style.display = 'block';
      weatherIcon.innerHTML = '<i class="fas fa-spinner fa-spin"></i>';
      temperature.textContent = '...';
      
      const response = await fetch(url);
      if (!response.ok) {
          throw new Error('Nie znaleziono miasta! Sprawdź nazwę i spróbuj ponownie.');
      }
      
      const data = await response.json();
      
      const now = new Date();
      updateTime.textContent = `Ostatnia aktualizacja: ${now.toLocaleTimeString()}`;
      
      const weatherCode = data.current.condition.code;
      const isDay = data.current.is_day;
      setWeatherIcon(weatherIcon, weatherCode, isDay);
      
      temperature.innerHTML = `${Math.round(data.current.temp_c)}<span class="degree">°C</span>`;
      
      weatherDetails.innerHTML = `
          <p><i class="fas fa-info-circle"></i> <span>${data.current.condition.text}</span></p>
          <p><i class="fas fa-temperature-high"></i> <span>Odczuwalna: ${Math.round(data.current.feelslike_c)}°C</span></p>
          <p><i class="fas fa-tint"></i> <span>Wilgotność: ${data.current.humidity}%</span></p>
          <p><i class="fas fa-wind"></i> <span>Wiatr: ${data.current.wind_kph} km/h</span></p>
          <p><i class="fas fa-compress-alt"></i> <span>Ciśnienie: ${data.current.pressure_mb} hPa</span></p>
          <p><i class="fas fa-eye"></i> <span>Widoczność: ${data.current.vis_km} km</span></p>
      `;
      
      locationInfo.textContent = `${data.location.name}, ${data.location.country}`;
      locationInfo.className = 'location-info';
      weatherInfo.insertBefore(locationInfo, weatherInfo.firstChild);
      
      weatherInfo.style.display = 'block';
      
  } catch (error) {
      showError(error.message);
  }
}

function setWeatherIcon(element, code, isDay) {
  const iconMap = {
      1000: isDay ? 'fa-sun' : 'fa-moon',
      1003: isDay ? 'fa-cloud-sun' : 'fa-cloud-moon',
      1006: 'fa-cloud',
      1009: 'fa-cloud',
      1030: 'fa-smog',
      1063: 'fa-cloud-rain',
      1066: 'fa-snowflake',
      1069: 'fa-cloud-meatball',
      1072: 'fa-cloud-meatball',
      1087: 'fa-bolt',
      1114: 'fa-wind',
      1117: 'fa-wind',
      1135: 'fa-smog',
      1147: 'fa-smog',
      1150: 'fa-cloud-rain',
      1153: 'fa-cloud-rain',
      1168: 'fa-cloud-rain',
      1171: 'fa-cloud-rain',
      1180: 'fa-cloud-rain',
      1183: 'fa-cloud-rain',
      1186: 'fa-cloud-showers-heavy',
      1189: 'fa-cloud-showers-heavy',
      1192: 'fa-cloud-showers-heavy',
      1195: 'fa-cloud-showers-heavy',
      1198: 'fa-temperature-low',
      1201: 'fa-temperature-low',
      1204: 'fa-cloud-meatball',
      1207: 'fa-cloud-meatball',
      1210: 'fa-snowflake',
      1213: 'fa-snowflake',
      1216: 'fa-snowflake',
      1219: 'fa-snowflake',
      1222: 'fa-snowflake',
      1225: 'fa-snowflake',
      1237: 'fa-icicles',
      1240: 'fa-cloud-showers-heavy',
      1243: 'fa-cloud-showers-heavy',
      1246: 'fa-cloud-showers-heavy',
      1249: 'fa-cloud-meatball',
      1252: 'fa-cloud-meatball',
      1255: 'fa-snowflake',
      1258: 'fa-snowflake',
      1261: 'fa-icicles',
      1264: 'fa-icicles',
      1273: 'fa-bolt',
      1276: 'fa-bolt',
      1279: 'fa-bolt',
      1282: 'fa-bolt',
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
