async function fetchWithTimeout(url, timeout = 5000) {
    const controller = new AbortController()

    const signal = controller.signal
    
    setTimeout(() => controller.abort(), timeout)

    try{
        let response = await fetch(url, {signal})
        let data = await response.json()

        return data
    }catch(err){
        console.error(err);
    }
}

fetchWithTimeout("https://jsonplaceholder.typicode.com/todos/1")
.then(console.log);
