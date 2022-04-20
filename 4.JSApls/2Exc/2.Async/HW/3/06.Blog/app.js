function attachEvents() {
    let postUrl = 'http://localhost:3030/jsonstore/blog/posts';
    let commentsUrl = 'http://localhost:3030/jsonstore/blog/comments';

    let btnLoadPosts = document.querySelector('#btnLoadPosts');
    let btnViewPost = document.querySelector('#btnViewPost');
    let posts = document.querySelector('#posts');

    let postsData = '';

    btnLoadPosts.addEventListener('click', loadPosts);

    async function loadPosts(event) {
        posts.innerHTML = '';
        let response = await fetch(postUrl);

        if (response.ok == false) {
            throw new Error('Error!');
        }

        postsData = await response.json();

        for (let post in postsData) {
            let option = document.createElement('option');
            option.textContent = postsData[post].title;
            option.value = post;

            posts.appendChild(option);
        }
    }

    btnViewPost.addEventListener('click', ViewPost);

    async function ViewPost() {
        let postTitle = document.querySelector('#post-title');
        let postBody = document.querySelector('#post-body');
        let postComments = document.querySelector('#post-comments');
        postComments.innerHTML = '';
        //-MSbypx-13fHPDyzNRtf
        let getSelected = posts.value;

        let url = commentsUrl;
        let response = await fetch(url);

        if (response.ok == false) {
            throw new Error('Error!');
        }

        let comments = await response.json();

        let commentsPost = Object.entries(comments)
            .flatMap(x => x[1])
            .filter(x => x.postId == getSelected);
        // .map(x => `${x.id} - ${x.text}`);

        //title
        postTitle.textContent = Array.from(posts.querySelectorAll('#posts > option'))
            .filter(x => x.value == getSelected)[0].innerHTML;

        //body
        postBody.textContent = postsData[getSelected].body;

        //comments
        for (let comment of commentsPost) {
            let li = document.createElement('li');
            li.textContent = comment.text;

            postComments.appendChild(li);
        }
    }
}

attachEvents();