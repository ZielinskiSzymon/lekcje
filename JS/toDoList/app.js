let i = 0;


document.getElementById('btn').addEventListener('click', function() {
    i++;

    const taskContent = document.getElementById('taskContent').value.trim();
    const existingTasks = Array.from(document.getElementsByClassName('content'));

    const isDuplicate = existingTasks.some(task => task.textContent == taskContent);

    if (taskContent != '' && !isDuplicate) {
        const taskContainer = document.createElement('div');
        taskContainer.className = 'tasks';

        const taskContentSpan = document.createElement('span');
        taskContentSpan.className = 'content';
        taskContentSpan.textContent = taskContent;

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

        document.getElementById('taskContent').value = '';

        document.querySelector("#count").textContent = i;


        // alert(document.querySelector("#date").value)
        alert(Date(year))

    } else if (isDuplicate) {
        alert("Zawartosc sie powtarza");
    }
});
