import { showView } from "./dom.js";
import { showHomePage } from "./homeView.js";
import { allUrls } from "./urls.js";

 
const editSection = document.querySelector('#edit-movie');
editSection.remove();
const form = editSection.querySelector('form');


export function showEditSection(event){
    
    const movieId = event.target.dataset.id;
    const ownerId = event.target.dataset.ownerid;
    const token = event.target.dataset.token;
    
    const formData = new FormData(form);
    const mainDiv = event.target.parentElement.parentElement;
    let [title, imgUrl, descr] = mainDiv.children;
    title = title.textContent;
    let movieName = title.slice(13)
    imgUrl = imgUrl.firstElementChild.src;
    descr = descr.querySelector('p').textContent;
    
    showView(editSection);
    form.querySelector('#titleInp').value = movieName;
    form.querySelector('#descriptionTextArea').value = descr;
    form.querySelector('#imageUrlInp').value = imgUrl;
    
    
    form.addEventListener('submit', async(event)=>{
        event.preventDefault();
        try {
            title = form.querySelector('#titleInp').value;
            descr = form.querySelector('#descriptionTextArea').value;
            imgUrl = form.querySelector('#imageUrlInp').value;
            let response = await fetch(allUrls.updateMoviePUTreq+movieId, {
                method:'put',
                headers: {
                    'Content-Type': 'application/json',
                    'X-Authorization':token
                },
                body: JSON.stringify({'img':imgUrl.trim(), 'description':descr.trim(), 'title':title.trim(), '_ownerId':ownerId})
            });
            if(response.ok == false){
                let err = await response.json();
                throw new Error(err.message);
            }else {
                let data = await response.json();
                form.reset()
                showHomePage();
            }
        } catch (error) {
            alert(error.message);
        }
    
    });
}