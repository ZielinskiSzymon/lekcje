fetch("https://jsonplaceholder.typicode.com/users")
    .then(response => response.json())
    .then(data => {
        console.log(data);
        const ul = document.querySelector("ul")

        data.forEach(user => {
            let li = document.createElement("li");
            li.textContent = `${user.name} - ${user.email}`;
            ul.appendChild(li);
        });
    })
    .catch(error => console.log(error));
