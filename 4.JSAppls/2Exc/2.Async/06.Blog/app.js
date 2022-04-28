function attachEvents() {
    document.getElementById('btnLoadPosts').addEventListener('click', getAllPosts);
    document.getElementById('btnViewPost').addEventListener('click', displayPost);
}

attachEvents();

const titleElement = document.getElementById('post-title');

async function displayPost() {
    const selectedId = document.getElementById('posts').value;

    const bodyElement = document.getElementById('post-body');
    const ulElement = document.getElementById('post-comments');

    titleElement.textContent = 'Loading...';
    bodyElement.textContent = '';
    ulElement.replaceChildren();

    const [post, comments] = await Promise.all([
        getPostById(selectedId),
        getCommentsByPostId(selectedId)
    ])

    titleElement.textContent = post.title;
    bodyElement.textContent = post.body;


    comments.forEach(c => {
        const liElement = document.createElement('li');
        liElement.textContent = c.text;
        ulElement.appendChild(liElement);
    })
}

async function getAllPosts() {
    const url = `http://localhost:3030/jsonstore/blog/posts`;
    titleElement.textContent = 'Loading...';

    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();

        const selectElement = document.getElementById('posts');
        selectElement.replaceChildren();
        Object.values(data).forEach(p => {
            const optionElement = document.createElement('option');
            optionElement.textContent = p.title;
            optionElement.value = p.id;
            selectElement.appendChild(optionElement);
        })
    } catch (error) {
        titleElement.textContent = 'Error';
    }
}

async function getPostById(postId) {
    const url = `http://localhost:3030/jsonstore/blog/posts/` + postId;

    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }

        return await res.json();
    } catch (error) {
        titleElement.textContent = 'Error';
    }
}

async function getCommentsByPostId(postId) {
    const url = `http://localhost:3030/jsonstore/blog/comments`;

    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();

        return Object.values(data).filter(c => c.postId == postId);
    } catch (error) {
        titleElement.textContent = 'Error';
    }
}