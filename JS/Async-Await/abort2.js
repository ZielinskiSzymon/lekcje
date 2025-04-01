async function fetchWithTimeout(url, timeout) {
    const controller = new AbortController()

    const timeoutId = setTimeout(() => {
        controller.abort()
    }, timeout)

    try{
        const response = await fetch(url, {signal: controller.signal})

        clearTimeout(timeoutId)

        const data = await response.json()
        console.log("Dane", data);      
    }catch(err){
        if(err.name === "AbortError")
            console.error("Żądanie zostało anulowane timeout!")
        else
            console.error(err);
    }
}

fetchWithTimeout("https://jsonplaceholder.typicode.com/posts/1", 3000)
