import { loadTopic } from './topic.js';

export async function homePage() {
    const main = document.querySelector('main');
    const newTopicDiv = document.querySelector('.new-topic-border');

    const res = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts');
    const data = await res.json();
    
    main.innerHTML = '';
    
    const fragment = document.createDocumentFragment();
    Object.values(data).map(createElement).forEach(d => fragment.appendChild(d));

    newTopicDiv.appendChild(fragment);
    main.appendChild(newTopicDiv);
    
}

function createElement(post) {
    const divTopic = document.createElement('div');
    divTopic.className = 'topic-container';
    divTopic.innerHTML = `<div class="topic-name-wrapper">
                                <div class="topic-name">
                                    <input type="hidden" id="inputId" value="${post._id}">
                                    <a href="#" class="normal">
                                        <h2>${post.title}</h2>
                                    </a>
                                    <div class="columns">
                                        <div>
                                        <p>Date: <time>${post.time}</time></p>
                                            <div class="nick-name">
                                                <p>Username: <span>${post.username}</span></p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>`;
    divTopic.addEventListener('click', (e) => {
        if (e.target.tagName == 'H2') {
            const id = e.target.parentNode.parentNode.querySelector('#inputId').value;
            loadTopic(id);
        }
    });

    return divTopic;
}