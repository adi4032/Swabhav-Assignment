const form = document.getElementById("form");
const dateInput = document.getElementById("date");
const activityContainer = document.getElementById("activity-container");
const addActivityButton = document.getElementById("add-activity");
const displayActivities = document.getElementById("displayActivities");

let ActivityIndex = 0;

addActivityButton.addEventListener("click", function () {
    const newActivityForm = document.createElement("div");
    newActivityForm.classList.add("activity-form");
    newActivityForm.innerHTML = `
        <h3>Activity ${ActivityIndex + 1}</h3>
        <label for="project-name-${ActivityIndex}">Enter Project Name:</label>
        <select id="project-name-${ActivityIndex}">
            <option value="Lending">Lending</option>
            <option value="Banking">Banking</option>
        </select>

        <label for="sub-project-${ActivityIndex}">Enter Sub-project Name:</label>
        <select id="sub-project-${ActivityIndex}">
            <option value="lending-sub">Banking Subject</option>
            <option value="banking-sub">Lending Subject</option>
        </select>

        <label for="batch-${ActivityIndex}">Enter Batch:</label>
        <select id="batch-${ActivityIndex}">
            <option value="Apro Captive">Apro Captive</option>
            <option value="Apro Payments">Apro Payments</option>
        </select>

        <div>
          <label for="hours-needed-${ActivityIndex}">Hours Needed:</label>
          <input type="number" id="hours-needed-${ActivityIndex}" />
        </div>

        <div>
          <label for="activity-${ActivityIndex}">Activity:</label>
          <textarea id="activity-${ActivityIndex}"></textarea>
        </div>
    `;
    activityContainer.appendChild(newActivityForm);
    ActivityIndex++;
});

form.addEventListener("submit", function (event) {
    event.preventDefault();

    const date = dateInput.value;
    const onLeave = document.getElementById("on-leave").value === "true"; 

    const activityForms = document.querySelectorAll(".activity-form");
    const activities = Array.from(activityForms).map((form, index) => ({
        timesheetId: 0,
        project: form.querySelector(`#project-name-${index}`).value,
        subProject: form.querySelector(`#sub-project-${index}`).value,
        batch: form.querySelector(`#batch-${index}`).value,
        hoursNeeded: parseInt(form.querySelector(`#hours-needed-${index}`).value, 10),
        activity: form.querySelector(`#activity-${index}`).value
    }));

    const data = {
        dateId: 0,
        todaysDate: date,
        onLeave: onLeave,
        timesheetList: activities
    };

    fetch("http://localhost:5023/api/Timesheet", {
        method: "POST",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(data)
    })
    .then(response => {
        if (!response.ok) {
            return response.json().then(err => Promise.reject(err));
        }
        return response.json();
    })
    .then(data => {
        console.log("Successfully posted:", data);
        getData(); 
    })
    .catch(error => {
        console.error("Error:", error);
    });
});

const getData = async () => {
    try {
        const response = await fetch("http://localhost:5023/api/Timesheet");
        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }
        const data = await response.json();
        displayActivities.innerHTML = ""; 

        if (data.length > 0) {
            const table = document.createElement("table");
            table.style.width = "100%";
            table.style.borderCollapse = "collapse";
            table.innerHTML = `
                <thead>
                    <tr>
                        <th>Date</th>
                        <th>On Leave</th>
                        <th>Project</th>
                        <th>Sub-project</th>
                        <th>Batch</th>
                        <th>Hours Needed</th>
                        <th>Activity</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            `;
            
            const tbody = table.querySelector("tbody");

            data.forEach(entry => {
                entry.timesheetList.forEach(activity => {
                    const row = document.createElement("tr");
                    row.innerHTML = `
                        <td>${entry.todaysDate}</td>
                        <td>${entry.onLeave}</td>
                        <td>${activity.project}</td>
                        <td>${activity.subProject}</td>
                        <td>${activity.batch}</td>
                        <td>${activity.hoursNeeded}</td>
                        <td>${activity.activity}</td>
                    `;
                    tbody.appendChild(row);
                });
            });

            displayActivities.appendChild(table);
        } else {
            displayActivities.innerHTML = "<p>No activities found.</p>";
        }
    } catch (error) {
        console.error("Error fetching data:", error);
    }
};

getData();
