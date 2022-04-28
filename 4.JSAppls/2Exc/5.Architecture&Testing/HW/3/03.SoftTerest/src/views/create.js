import {e} from '../dom.js';
import { createIdea } from '../api/data.js';

const section = document.querySelector('#createPage');
section.remove();
const form = section.querySelector('form');
form.addEventListener('submit', onSubmit);
let ctx=null;

export async function showCreatePage(ctxTarget){
    ctx=ctxTarget;
    ctx.showSection(section);
}

async function onSubmit(event){
    event.preventDefault();

    const formData = new FormData(form);

    const title = formData.get('title').trim();
    const description = formData.get('description').trim();
    const img=formData.get('imageURL').trim();

    if(title.length<6){
        return alert('Title must be atleast 6 characters long');
    }
    if(description.length<10){
        return alert('Description must be atleast 10 characters long');
    }
    if(img.length<5){
        return alert('Image URL must be atleast 6 characters long');
    }

    createIdea({title,description,img});
    form.reset();
    ctx.goTo('catalog');
}