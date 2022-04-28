import { showView } from "./dom.js";
import { showEditSection } from "./editView.js";
import { showHomePage } from "./homeView.js";
import { allUrls } from "./urls.js";

let detailsSection = document.querySelector("#movie-example");
detailsSection.remove();

detailsSection = document.createElement("section");
detailsSection.setAttribute("id", "movie-example");

// let hasLiked = false;

export async function showDetailsSection(event) {
  loadDetails(event);
}

let detailsEvent = null 

async function loadDetails(event){
  detailsEvent = event;
  if(event.target.tagName == 'BUTTON'){
      const loadingP = document.createElement("p");
      loadingP.textContent = "Loading...";
      detailsSection.replaceChildren(loadingP);
      showView(detailsSection);
    
      const userData = JSON.parse(sessionStorage.getItem("userData"));
      const movieId = event.target.dataset.id;
      const movieOwnerId = event.target.dataset.ownerid;
      const likes = await getLikes();
      try {
        const response = await fetch(allUrls.getAllMovies + `/${movieId}`);
        if (response.status != 200) {
          let err = await response.json();
          throw new Error(err.message);
        } else {
          let data = await response.json();
          let isOwner = false;
          if (movieOwnerId == userData.id) {
            isOwner = true;
          }
          const mainDiv = document.createElement("div");
          mainDiv.className = "container";
          mainDiv.innerHTML = `
    <div class="row bg-light text-dark">
    <h1>Movie title: ${data.title}</h1>
    <div class="col-md-8">
        <img class="img-thumbnail" src=${data.img}
        alt="Movie">
    </div>
    <div class="col-md-4 text-center">
        <h3 class="my-3 ">Movie Description</h3>
        <p>${data.description}</p>
        <a class="btn btn-danger" href="#">Delete</a>
        <a class="btn btn-warning" href="#">Edit</a>
        <a class="btn btn-primary" href="#">Like</a>
        <span class="enrolled-span">Liked ${likes}</span>
    </div>
    </div>`;
    detailsSection.replaceChildren(mainDiv);
          const likeBtn = mainDiv.querySelector(
            "div div.col-md-4.text-center a.btn.btn-primary"
          );
          

          const unlikeBtn = document.createElement('a');
          unlikeBtn.className = 'btn btn-primary';
          unlikeBtn.setAttribute('href', '#');
          unlikeBtn.textContent = `Unlike`;
          
    
async function hasLiked(){

  let response = await fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${movieId}%22%20and%20_ownerId%3D%22${userData.id}%22`)
let data = await response.json();
if(data.length >0){
  likeBtn.replaceWith(unlikeBtn);
  unlikeBtn.addEventListener('click', onUnlike.bind(null,userData, data, likeBtn ,unlikeBtn))

}else {
  unlikeBtn.replaceWith(likeBtn);
  likeBtn.addEventListener("click",onLike.bind(null, movieId, userData, data, unlikeBtn, likeBtn));
}
}
hasLiked()
    
          const editBtn = mainDiv.querySelector(
            "div div.col-md-4.text-center a.btn.btn-warning"
            );
            editBtn.setAttribute('data-id', movieId)
            editBtn.setAttribute('data-ownerId', userData.id)
            editBtn.setAttribute('data-token', userData.token)
            editBtn.addEventListener("click", showEditSection);
            
            const deleteBtn = mainDiv.querySelector(
              "div div.col-md-4.text-center a.btn.btn-danger"
              );
              deleteBtn.addEventListener("click", onDelete.bind(null, movieId, userData));
              if (isOwner == false) {
                deleteBtn.style.display = "none";
                editBtn.style.display = "none";
                likeBtn.style.display = 'inline-block';
                
              } else {
                likeBtn.style.display = 'none';
                deleteBtn.style.display = "inline-block";
                editBtn.style.display = "inline-block";
              }
        }
      } catch (error) {
        alert(error.message);
      }
    
      async function getLikes() {
        try {
          const likesResp = await fetch(
            `http://localhost:3030/data/likes?where=movieId%3D%22${movieId}%22&distinct=_ownerId&count`
          );
          if (likesResp.status != 200) {
            let err = await likesResp.json();
            throw new Error(err.message);
          } else {
            let data = await likesResp.json();
            return data;
          }
        } catch (error) {
          alert(error.message);
        }
      } 
    }
  }





async function onLike(movieId, userData,unlikeBtn, likeBtn) {
  try {
    const response = await fetch('http://localhost:3030/data/likes', {
      method: "post",
      headers: {
        "Content-Type": "application/json",
        "X-Authorization": userData.token,
      },
      body: JSON.stringify({ 'movieId':movieId}),
    });
    if (response.ok != true) {
      const err = await response.json();
      throw new Error(err.message);
    } else {
        let movieLikeId = await response.json();
       showDetailsSection(detailsEvent);
    }
  } catch (error) {
    alert(error.message);
  }
}

async function onUnlike(userData, data,likeBtn, unlikeBtn){
  const id = data[0]._id;
  try {
    const response = await fetch('http://localhost:3030/data/likes/'+id, {
      method: "delete",
      headers: {
        "X-Authorization": userData.token,
      }});
    if (response.ok != true) {
      const err = await response.json();
      throw new Error(err.message);
    } else {
        let movieLikeId = await response.json();
       showDetailsSection(detailsEvent);
    }
  } catch (error) {
    alert(error.message);
  }
}


async function onDelete(movieId, userData) {
  
  try {
    let response = await fetch(allUrls.deleteMovie+movieId, {
      method:'delete',
      headers:{
        'X-Authorization': userData.token
      }
    });

    if (response.ok != true) {
      const err = await response.json();
      throw new Error(err.message);
    } else {
      let data = await response.json();
      showHomePage();
    }
  } catch (error) {
    alert(error.message);
    
  }
  
  
}


