import { showAddMovieSection } from "./createMovieView.js";
import { showDetailsSection } from "./detailsView.js";
import { showEditSection } from "./editView.js";
import { showHomePage } from "./homeView.js";
import { showLoginSection } from "./loginView.js";
import { showRegisterSection } from "./registerView.js";
showHomePage();
const nav = document.querySelector("#container nav");
nav.addEventListener("click", (event) => {
  if (event.target.tagName == "A") {
    event.preventDefault();
    if (event.target.id == "homePageLink") {
      showHomePage();
    } else if (event.target.id == "logoutBtn") {
      onLogout();
    } else if (event.target.id == "loginLink") {
      showLoginSection();
    } else if (event.target.id == "registerLink") {
      showRegisterSection();
    }
  }
});

async function onLogout() {
  const userData = JSON.parse(sessionStorage.getItem("userData"));
  const url = "http://localhost:3030/users/logout";
  const options = {
    method: "get",
    headers: {
      "X-Authorization": userData.token,
    },
  };
  try {
    let response = await fetch(url, options);
    if (response.ok != true) {
      const err = await response.json();
      throw new Error(err.message);
    } else {
      sessionStorage.clear();
      showHomePage();
    }
  } catch (error) {
    alert(error.message);
  }
}
