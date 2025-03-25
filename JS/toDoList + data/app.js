let i = 0;

document.getElementById('btn').addEventListener('click', function() {
    const taskContent = document.getElementById('taskContent').value.trim();
    const taskDate = document.getElementById('date').value;
    const existingTasks = Array.from(document.getElementsByClassName('content'));
    const isDuplicate = existingTasks.some(task => task.textContent.includes(taskContent));

    if (taskContent && taskDate && !isDuplicate) {
        i++;
        const taskContainer = document.createElement('div');
        taskContainer.className = 'tasks';
        
        const taskContentSpan = document.createElement('span');
        taskContentSpan.className = 'content';
        taskContentSpan.textContent = `${taskContent} (do wykoniania: ${taskDate})`;

        const removeButton = document.createElement('button');
        removeButton.className = 'remove';
        removeButton.textContent = 'Remove';
        removeButton.addEventListener('click', function() {
            taskContainer.remove();
            i--;
            document.querySelector("#count").textContent = i;
        });

        taskContainer.appendChild(taskContentSpan);
        taskContainer.appendChild(removeButton);

        document.getElementById('container').appendChild(taskContainer);
        document.querySelector("#count").textContent = i;

        const dzis = new Date();
        const data = new Date(taskDate);
        const roznicaDat = Math.round((data - dzis) / (1000 * 3600 * 24));

        console.log(roznicaDat)
        if (roznicaDat < 0) {
            taskContainer.classList.add('red');
        } else if (roznicaDat <= 2) {
            taskContainer.classList.add('orange');
        }
    } else if (isDuplicate) {
        alert("Zawartość się powtarza");
    } else {
        alert("Proszę uzupełnić wszystkie pola");
    }
});
