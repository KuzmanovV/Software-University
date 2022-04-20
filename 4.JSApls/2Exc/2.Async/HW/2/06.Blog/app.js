function attachEvents() {
    document.getElementById('btnLoadPosts').addEventListener('click', getAllPost);
    document.getElementById('btnViewPost').addEventListener('click', displayPost);

}

attachEvents();

async function displayPost() {
    const titleElement = document.getElementById('post-title');
    const bodyElement = document.getElementById('post-body');
    const ulElement = document.getElementById('post-comments');

    titleElement.textContent = 'Loading...'
    bodyElement.textContent = '';
    ulElement.replaceChildren(); 


    const selectedId = document.getElementById('posts').value;

    const [post, comments] = await Promise.all([
        getPostById(selectedId),
        getCommentsByPosedId(selectedId)
    ]);

    titleElement.textContent = post.title;
    bodyElement.textContent = post.body;

    comments.forEach(c => {
        const liElement = document.createElement('li');
        liElement.textContent = c.text;
        ulElement.appendChild(liElement);
    });
}

async function getAllPost() {
    let url = `http://localhost:3030/jsonstore/blog/posts`;

    let res = await fetch(url);
    let data = await res.json();

    const selectedElement = document.getElementById('posts');
    selectedElement.replaceChildren();
    Object.values(data).forEach(p => {
        const optionElement = document.createElement('option');
        optionElement.textContent = p.title;
        optionElement.value = p.id;

        selectedElement.appendChild(optionElement);

    });
}
async function getPostById(postId) {
    let url = `http://localhost:3030/jsonstore/blog/posts/` + postId;

    let res = await fetch(url);
    let data = await res.json();

    return data;
}
async function getCommentsByPosedId(postId) {
    let url = `http://localhost:3030/jsonstore/blog/comments`;

    let res = await fetch(url);
    let data = await res.json();

    const comments = Object.values(data).filter(c => c.postId == postId);

    return comments;
}