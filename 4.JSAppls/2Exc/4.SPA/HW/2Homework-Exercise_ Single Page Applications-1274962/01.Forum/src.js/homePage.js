import { showCommentView } from "./commentpage.js";
import { updateHomeView, updateCreatedPostsView } from "./render.js";

export const nav = document.getElementById('navigation');
nav.addEventListener('click', (event)=>{
    if(event.target.tagName == "A"){
        showHomePage();
    }
})
export const divContainer = document.getElementById('divContainer');
const main = document.getElementById('postCreation');
const createdPostsDiv = document.getElementById('createdPostsDiv');
createdPostsDiv.replaceChildren();
const footer = document.querySelector('footer');
const [cancelBtn, Postbtn] = document.querySelectorAll('.new-topic-buttons button')
const form  = main.querySelector('form');
form.addEventListener('submit', createPost);
cancelBtn.addEventListener('click', onCancel);
Postbtn.addEventListener('click', createPost);
main.appendChild(createdPostsDiv);
divContainer.appendChild(main);

export function showHomePage(){
    divContainer.replaceChildren(main)
    getPosts();
    updateHomeView(nav, divContainer, footer)
}

function onCancel(event){
    event.preventDefault()
    form.reset()
}

async function createPost(event){
    event.preventDefault();
    event.stopImmediatePropagation();
try {
    const formData = new FormData(form);
    const title = formData.get('topicName');
    const username = formData.get('username');
    const textContent = formData.get('postText');

    if(title == '' || username == '' || textContent == ''){
        throw new Error(`All fields are required!`);
    }

    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts', {
        method:'post',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({title, username, textContent})
    })
    
    if(response.ok != true){
        const err = await response.json();
        throw new Error(err.message)
    }else {
        let data = await response.json();
        form.reset();
        showHomePage()
    }
} catch (error) {
    alert(error.message);
}

}



async function getPosts(){

try {
    const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/posts');
    if(response.status == 200 || response.status == 204){
        let data = await response.json();
        let arrOfData = [];
        for(let key in data){
            arrOfData.push(data[key])
        }
       createdPostsDiv.replaceChildren(...arrOfData.map(createPostElement));
    }else {
        const err = await response.json();
        throw new Error(err.message)

    }
} catch (error) {
    alert(error.message);
}

}

function createPostElement(dataObj){
let div = document.createElement('div');
div.className = "topic-container";
div.innerHTML = `
<div class="topic-name-wrapper">
    <div class="topic-name">
        <a data-id=${dataObj._id} href="#" class="normal">
            <h2>${dataObj.title}</h2>
        </a>
        <div class="columns">
            <div>
                <p>Date: <time>2020-10-10T12:08:28.451Z</time></p>
                <div class="nick-name">
                    <p>Username: <span>${dataObj.username}</span></p>
                </div>
            </div>


        </div>
    </div>
</div>`;

div.querySelector('a').addEventListener('click', showCommentView)

return div

}