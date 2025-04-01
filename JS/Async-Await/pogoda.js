async function getWeather(city) {
    try{
        console.log(`Poberanie pogody dla: ${city}...`);

        const response = await fetch(`https://wttr.in/${city}?format=j1`)

        const data = await response.json();
        console.log("Odpowiedź z serwera: ",data);
        
        const tempC = data.current_condition[0].temp_C;

        console.log(`Aktualna temperatura w ${city}: ${tempC}*C`);      
    }catch(err){
        console.error(err)
    }
}

getWeather("Stróże")