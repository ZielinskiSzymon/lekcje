async function fetchUsers() {
    const urls = [
        "https://jsonplaceholder.typicode.com/users/1",
        "https://jsonplaceholder.typicode.com/users/2",
        "https://jsonplaceholder.typicode.com/users/3"
    ]

    try{
        const responses = await Promise.all(
            urls.map(url => fetch(url).then(res => res.json()))
        )

        responses.forEach(user => {
            console.log(user.name);
        })
    }catch(err){
        console.error(err)
    }
}

fetchUsers()