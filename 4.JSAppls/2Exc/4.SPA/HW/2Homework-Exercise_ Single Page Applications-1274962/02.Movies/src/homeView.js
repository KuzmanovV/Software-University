import { showAddMovieSection } from "./createMovieView.js";
import { showDetailsSection } from "./detailsView.js";
import { showView } from "./dom.js";
import { allUrls } from "./urls.js";

const [...liGuestItems] = document.querySelectorAll("li.nav-item.guest");
const [...liUserItems] = document.querySelectorAll("li.nav-item.user");
const homeSection = document.querySelector("#home-page");
homeSection.remove();
const moviesSection = homeSection.querySelector("#movie");
moviesSection.replaceChildren();

export function showHomePage() {
  showView(homeSection);
  updateNav();
  getMovies();
  addMovie();
}
function addMovie(){
  const userData = JSON.parse(sessionStorage.getItem("userData"));
  const addBtn = document.querySelector('#add-movie-button');
  addBtn.addEventListener('click', showAddMovieSection)
if(userData == null){
  addBtn.disabled = true;
  addBtn.style.display = 'none';
}else {
  addBtn.disabled = false;
  addBtn.style.display = 'block';
  
}
}

async function getMovies() {
  try {
    const response = await fetch(allUrls.getAllMovies);
    if (response.status != 200) {
      const err = await response.json();
      throw new Error(err.message);
    } else {
      let data = await response.json();
      
      const mainDiv = document.createElement("div");
      mainDiv.className = ' mt-3 ';

      const parentDiv = document.createElement("div");
      parentDiv.className = "row d-flex d-wrap";

      const movieCardsHolder = document.createElement("div");
      movieCardsHolder.className = "card-deck d-flex justify-content-center";
      movieCardsHolder.replaceChildren(...data.map(createElements));
      movieCardsHolder.addEventListener('click', showDetailsSection)
      parentDiv.replaceChildren(movieCardsHolder);
      mainDiv.replaceChildren(parentDiv)
      moviesSection.replaceChildren(mainDiv);
    }
  } catch (error) {
    alert(error.message);
  }
}

function createElements(dataObj) {
  const userData = JSON.parse(sessionStorage.getItem("userData"));
  const movieDiv = document.createElement("div");
  movieDiv.className = "card mb-4";
  movieDiv.innerHTML = ` 
<img class="card-img-top" src=${dataObj.img}
alt="Card image cap" width="400">
<div class="card-body">
<h4 class="card-title">${dataObj.title}</h4>
</div>
<div class="card-footer">
<a href="#/details/6lOxMFSMkML09wux6sAF">
<button data-id=${dataObj._id} data-ownerId=${dataObj._ownerId} type="button" class="btn btn-info">Details</button>
</a>`;
if(userData == null){
  movieDiv.querySelector('div.card-footer a button').disabled = true;
}else {
  movieDiv.querySelector('div.card-footer a button').disabled = false;

}
return movieDiv;
}

const ul = document.querySelector("ul.navbar-nav.ml-auto");
ul.replaceChildren();

function updateNav() {
  const userData = JSON.parse(sessionStorage.getItem("userData"));
  if (userData == null) {
    ul.replaceChildren(...liGuestItems);
  } else {
    ul.replaceChildren(...liUserItems);
    ul.querySelector("#userView").textContent = `Welcome, ${userData.email}`;
  }
}
