async function fetchData() {
    return "Dane pobrane"
}

// fetchData()
    // .then(console.log)

async function getData() {
    try{
        let data = await fetch('https://jsonplaceholder.typicode.com/todos/1')
        let json = await data.json()
        console.log(json)
    }catch(err){
        console.error(err)
    }
}

getData()