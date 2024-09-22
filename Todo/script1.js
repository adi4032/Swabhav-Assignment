const btn = document.getElementById("AddTask");
const input = document.getElementById("inputText");
const ul = document.getElementById("taskList");

const myArray = [];

function renderTasks() {
    ul.innerHTML = '';

    myArray.forEach((task, index) => {
        const li = document.createElement("li");
        li.classList.add("task-item", "d-flex", "justify-content-between", "align-items-center", "py-2", "border-bottom");
        if (task.done) {
            li.style.textDecoration = "line-through";
            li.classList.add("text-muted");
        }

        li.innerText = task.text;

        const confirmBtn = document.createElement("button");
        confirmBtn.innerText = "Done";
        confirmBtn.classList.add("btn", "btn-sm", "btn-success", "me-2");

        const deleteBtn = document.createElement("button");
        deleteBtn.classList.add("btn", "btn-sm", "btn-danger");
        const icon = document.createElement("i");
        icon.classList.add("bi", "bi-trash-fill");
        deleteBtn.appendChild(icon);

        li.appendChild(confirmBtn);
        li.appendChild(deleteBtn);
        ul.appendChild(li);

        confirmBtn.addEventListener('click', () => {
            myArray[index].done = !myArray[index].done;
            renderTasks();
        });
        deleteBtn.addEventListener('click', () => {
            myArray.splice(index, 1);
            console.log("DELETED : " + myArray.map(task => task.text));
            renderTasks();
        });
    });
}

btn.addEventListener("click", () => {
    const taskText = input.value.trim();
    if (taskText !== "") {
        const taskExists = myArray.some(task => task.text === taskText);
        if (!taskExists) {
            myArray.push({ text: taskText, done: false });
            input.value = "";
            console.log(myArray.map(task => task.text));
            renderTasks();
        } else {
            alert("Task already exists!");
        }
    }
});
