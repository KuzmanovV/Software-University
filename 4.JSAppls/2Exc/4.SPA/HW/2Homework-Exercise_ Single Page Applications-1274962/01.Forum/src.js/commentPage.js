import { nav, divContainer } from "./homepage.js";

export function showCommentView(event) {
  let eventTarget = event.target;
  if (eventTarget.tagName == "H2") {
    eventTarget = eventTarget.parentElement;
  }
  const id = eventTarget.dataset.id;
  loadCurrPost(id);
}

async function loadCurrPost(id) {
  try {
    const response = await fetch(
      "http://localhost:3030/jsonstore/collections/myboard/posts/" + id
    );
    if (response.status == 200) {
      let data = await response.json();
      const themeDiv = document.createElement("div");
      themeDiv.className = "theme-content";
      themeDiv.innerHTML = `
    <div class="theme-title">
        <div class="theme-name-wrapper">
            <div class="theme-name">
                <h2>${data.title}</h2>
            </div>
        </div>
    </div>
    
    <div class="comment">
    <div id="postInfo" class="topic-container">
        <div class="topic-name-wrapper">
            <div class="topic-name">
                <a href="#" class="normal">
                    <h2>${data.title}</h2>
                </a>
                <div class="columns">
                    <div>
                        <p>Date: <time>2020-10-10T12:08:28.451Z</time></p>
                        <div class="nick-name">
                            <p>Username: <span>${data.username}</span></p>
                        </div>
                    </div>
    
    
                </div>
            </div>
        </div>`;
      divContainer.replaceChildren(themeDiv);

      let secondChildDiv = document.createElement("div");
      secondChildDiv.id = "postContent";
      secondChildDiv.className = "comment";

        let divHeader = document.createElement('div');
        divHeader.className = "header";
        divHeader.innerHTML = `
        <img src="../static/profile.png" alt="avatar">
        <p><span>${data.username}</span> posted on <time>2020-10-10 12:08:28</time></p>
        
        <p class="post-content">${data.textContent}</p>`
        secondChildDiv.appendChild(divHeader)

      async function getComments() {
        console.log(id);
        const response = await fetch("http://localhost:3030/jsonstore/collections/myboard/comments");

          if (response.status == 200) {
            let data = await response.json();
            let arrOfData = [];
        for(let key in data){
            arrOfData.push(data[key])
        }
       console.log(arrOfData);

        arrOfData = arrOfData.filter(e => e.id == id)
       arrOfData = arrOfData.map(createCommentViewElements)
       console.log(arrOfData);
       arrOfData.forEach(e => secondChildDiv.appendChild(e));
        } 
      }
      getComments()
      themeDiv.appendChild(secondChildDiv);
      
      let commentDiv = document.createElement("div");
      commentDiv.className = "answer-comment";
      commentDiv.innerHTML = `
      <p><span>currentUser</span> comment:</p>
      <div class="answer">
      <form>
      <textarea name="postText" id="comment" cols="30" rows="10"></textarea>
      <div>
      <label for="username">Username <span class="red">*</span></label>
      <input type="text" name="username" id="username">
      </div>
      <button>Post</button>
      </form>
      </div>`;
      commentDiv.querySelector('button').addEventListener('click', onComment.bind(null, id))
      themeDiv.appendChild(commentDiv);
    } else {
      const err = await response.json();
      throw new Error(err.message);
    }
} catch (error) {
    alert(error.message);
}
}





function createCommentViewElements(data) {

    const postCommentDiv = document.createElement('div');
    postCommentDiv.id = `${data.user}-comment`
    postCommentDiv.innerHTML = `
<div class="topic-name-wrapper">
    <div class="topic-name">
        <p><strong>${data.user}</strong> commented on <time>3/15/2021, 12:39:02 AM</time></p>
        <div class="post-content">
            <p>${data.commentContent}</p>
        </div>
    </div>
</div>
</div>`


  return postCommentDiv;
}


async function onComment(id, event){
event.preventDefault();
const form = document.querySelector('form')
const formData = new FormData(form);
const user = formData.get('username');
const commentContent = formData.get('postText');
console.log(id);
try {
    if(user == '' || commentContent == ''){
        throw new Error(`All fields are required!`)
    }
const response = await fetch('http://localhost:3030/jsonstore/collections/myboard/comments',{
    method:'post',
    headers:{
        "Content-Type": 'application/json'
    },
    body: JSON.stringify({user, commentContent, id})
});
if(response.ok == false){
    const err = await response.json();
    throw new Error(err.message);
}
form.reset()
loadCurrPost(id)
} catch (error) {
    alert(error.message)
}

}


