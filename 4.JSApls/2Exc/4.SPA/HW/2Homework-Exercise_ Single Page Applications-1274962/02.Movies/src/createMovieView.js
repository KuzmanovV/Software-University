import { showView } from "./dom.js";
import { showHomePage } from "./homeView.js";

 

const addSection = document.querySelector('#add-movie');
addSection.remove();
const form = addSection.querySelector('form');
form.addEventListener('submit', async(event)=>{
event.preventDefault();
try {
const userData = JSON.parse(sessionStorage.getItem('userData'))
const formData = new FormData(form);
const title = formData.get('title');
const description = formData.get('description');
const img = formData.get('imageUrl');

if(title == '' || description == '' || img == ''){
    throw new Error(`All fields are required!`)
}
   const response = await fetch('http://localhost:3030/data/movies', {
       method:'post',
       headers: {
           'Content-Type': 'application/json',
           'X-Authorization': userData.token
       },
       body: JSON.stringify({title, description, img})
   });

    if (response.ok == false) {
        let err = await response.json();
        throw new Error(err.message);
    } else {
        form.reset();
        showHomePage();
    }
} catch (error) {
    alert(error.message)
}
})


export function showAddMovieSection(){
    showView(addSection);

}