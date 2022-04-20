import { showView } from "./dom.js";
import { showHomePage } from "./homeView.js";

const loginSection = document.querySelector("#form-login");
loginSection.remove();
const form = loginSection.querySelector("form");
form.addEventListener("submit", async (event) => {
  event.preventDefault();
  const formData = new FormData(form);
  const email = formData.get("email");
  const password = formData.get("password");

  let url = "http://localhost:3030/users/login";
  let options = {
    method: "post",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ email, password }),
  };

  try {
    let response = await fetch(url, options);
    if (response.ok == false) {
      const err = await response.json();
      throw new Error(err.message);
    } else {
      const data = await response.json();
      const userData = {
        username: data.username,
        email: data.email,
        id: data._id,
        token: data.accessToken,
      };

      form.reset();
      sessionStorage.setItem("userData", JSON.stringify(userData));
      showHomePage();
    }
  } catch (error) {
    alert(error.message);
  }
});

export function showLoginSection() {
  showView(loginSection);
}
