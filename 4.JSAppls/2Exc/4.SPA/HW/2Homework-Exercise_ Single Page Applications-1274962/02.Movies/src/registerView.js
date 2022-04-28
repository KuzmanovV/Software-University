import { showView } from "./dom.js";
import { showHomePage } from "./homeView.js";
 

const registerSection = document.querySelector('#form-sign-up');
registerSection.remove();
const form = registerSection.querySelector('form');
form.addEventListener('submit', async(event)=>{
    event.preventDefault();
  const formData = new FormData(form);
  const email = formData.get("email");
  const password = formData.get("password");
  const repass = formData.get('repeatPassword');
  try {

  if(password != repass){
      throw new Error(`Password does not match!`)
  }
  let url = "http://localhost:3030/users/register";
  let options = {
    method: "post",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify({ email, password }),
  };

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

export function showRegisterSection(){
    showView(registerSection);

}