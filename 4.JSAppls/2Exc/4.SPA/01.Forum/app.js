
import { e } from "./dom.js";

const topicsElement = document.querySelector('.topic-title');
const mainElement = document.querySelector('main');
const homeBtn = document.querySelector('#homeBtn');
const form = document.querySelector('form');
const commentsView = document.querySelector('.theme-content');

home();
homeBtn.addEventListener('click', () => {
    mainElement.replaceChildren(form);
    mainElement.appendChild(topicsElement);
    home();
});

const cancelBtn = document.querySelector('.new-topic-buttons .cancel');
cancelBtn.addEventListener('click', (event) => {
    event.preventDefault();
    form.reset();
})

form.addEventListener('submit', onPost);

async function onPost(event) {
    event.preventDefault();
    const formData = new FormData(form);

    const title = formData.get('topicName').trim();
    const user = formData.get('username').trim();
    const text = formData.get('postText').trim();
    const date = new Date();

    try {
        const res = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ title, user, text, date }),
        });

        if (res.ok != true) {
            const error = await res.json();
            throw new Error(error.message)
        }

        form.reset();
        home();
    } catch (err) {
        alert(err.message);
    }
}

async function home() {
    topicsElement.replaceChildren();
    commentsView.replaceChildren();

    const res = await fetch('http://localhost:3030/jsonstore/collections/myboard', {
        method: 'get',
    });
    const data = await res.json();
    Object.values(Object.values(data)[0]).forEach(post => {
        const postElement = e('div', { className: 'topic-container' },
            e('div', { className: 'topic-name-wrapper' },
                e('div', { className: 'topic-name' },
                    e('a', { href: '#', className: 'normal' },
                        e('h2', { id: post._id }, post.title),
                        e('div', { className: 'columns' },
                            e('div', {},
                                e('p', {}, `Date: `, e('time', {}, `${post.date}`))),
                            e('div', { className: 'nick-name' },
                                e('p', {}, 'Username: ', e('span', {}, post.user))))))));

        topicsElement.appendChild(postElement);
    });
};

topicsElement.addEventListener('click', onTopic)
async function onTopic(event) {
    event.preventDefault();
    if (event.target.tagName == 'H2') {
        const postId = event.target.id;

        const res = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts/' + postId);
        const data = await res.json();

        mainElement.replaceChildren()
    }
}

async function showComments() {

}





