document.addEventListener("DOMContentLoaded", tableAdd)
let input = document.querySelector("#data")
let li;
const tab = [];

input.addEventListener("input", () => {
    if(input.value != ""){
        li.forEach((el) => {
            if(el.textContent.toLowerCase().startsWith(input.value.toLowerCase()))
                el.style.display = "block"
            else
                el.style.display = "none"
        })
    }   
    if(input.value == ""){
        li.forEach((el) => {
            el.style.display = "block"
        })
    }
})

function tableAdd(){
    li = document.querySelectorAll("li");
    li.forEach((el) => {
        tab.push(el.textContent)
    })
}