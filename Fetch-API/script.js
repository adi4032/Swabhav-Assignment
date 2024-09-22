let editingPostId = null;
let editingRow = null;

function fetchPosts() {
    fetch('https://jsonplaceholder.typicode.com/posts')
        .then(response => response.json())
        .then(data => {
            const postsTable = document.getElementById('postsTable');
            postsTable.innerHTML = '';

            data.forEach(post => {
                const row = postsTable.insertRow();
                const postId = row.insertCell(0);
                const userIdData = row.insertCell(1);
                const titleData = row.insertCell(2);
                const bodyData = row.insertCell(3);
                const actionsCell = row.insertCell(4);

                postId.innerHTML = post.id;
                userIdData.innerHTML = post.userId;
                titleData.innerHTML = post.title;
                bodyData.innerHTML = post.body;


                const editButton = document.createElement('button');
                editButton.classList.add('btn', 'btn-warning', 'me-2');
                editButton.textContent = 'Edit';
                editButton.addEventListener('click', () => editPost(post, row));
                actionsCell.appendChild(editButton);


                const deleteButton = document.createElement('button');
                deleteButton.classList.add('btn', 'btn-danger');
                deleteButton.textContent = 'Delete';
                deleteButton.addEventListener('click', () => deletePost(post.id, row));
                actionsCell.appendChild(deleteButton);
            });

            document.getElementById('recordCount').textContent = data.length;
        })
        .catch(error => console.error('Error fetching posts:', error));
}


document.getElementById('postSubmissionForm').addEventListener('submit', function (e) {
    e.preventDefault();

    const userId = document.getElementById('userId').value;
    const title = document.getElementById('title').value;
    const body = document.getElementById('body').value;

    const postData = {
        userId: parseInt(userId),
        title,
        body
    };

    if (editingPostId) {
        fetch(`https://jsonplaceholder.typicode.com/posts/${editingPostId}`, {
            method: 'PUT',
            body: JSON.stringify(postData),
            headers: {
                'Content-Type': 'application/json'
            }
        })
            .then(response => {
                if (!response.ok) {
                    throw new Error('Failed to update post');
                }
                return response.json();
            })
            .then(data => {
                editingRow.cells[1].innerHTML = data.userId;
                editingRow.cells[2].innerHTML = data.title;
                editingRow.cells[3].innerHTML = data.body;

                editingPostId = null;
                editingRow = null;
                document.getElementById('postSubmissionForm').reset();
            })
            .catch(error => console.error('Error updating post:', error));
    } else {

        fetch('https://jsonplaceholder.typicode.com/posts', {
            method: 'POST',
            body: JSON.stringify(postData),
            headers: {
                'Content-Type': 'application/json'
            }
        })
            .then(response => response.json())
            .then(data => {
                const postsTable = document.getElementById('postsTable');
                const newRow = postsTable.insertRow();
                const postId = newRow.insertCell(0);
                const userIdData = newRow.insertCell(1);
                const titleData = newRow.insertCell(2);
                const bodyData = newRow.insertCell(3);
                const actionsCell = newRow.insertCell(4);

                postId.innerHTML = data.id;
                userIdData.innerHTML = data.userId;
                titleData.innerHTML = data.title;
                bodyData.innerHTML = data.body;


                const editButton = document.createElement('button');
                editButton.classList.add('btn', 'btn-warning', 'me-2');
                editButton.textContent = 'Edit';
                editButton.addEventListener('click', () => editPost(data, newRow));
                actionsCell.appendChild(editButton);

                const deleteButton = document.createElement('button');
                deleteButton.classList.add('btn', 'btn-danger');
                deleteButton.textContent = 'Delete';
                deleteButton.addEventListener('click', () => deletePost(data.id, newRow));
                actionsCell.appendChild(deleteButton);

                document.getElementById('recordCount').textContent = postsTable.rows.length;
                document.getElementById('postSubmissionForm').reset();
            })
            .catch(error => console.error('Error adding post:', error));
    }
});

function editPost(post, row) {
    document.getElementById('userId').value = post.userId;
    document.getElementById('title').value = post.title;
    document.getElementById('body').value = post.body;

    editingPostId = post.id;
    editingRow = row;
}

function deletePost(postId, row) {
    fetch(`https://jsonplaceholder.typicode.com/posts/${postId}`, {
        method: 'DELETE'
    })
        .then(() => {
            row.remove();
            document.getElementById('recordCount').textContent = document.getElementById('postsTable').rows.length;
        })
        .catch(error => console.error('Error deleting post:', error));
}

window.onload = fetchPosts;
