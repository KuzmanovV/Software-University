import { showView } from './dom.js';

const section = document.getElementById('edit-movie');
section.remove();

 export function showEdit() {
    showView(section);
}

//Del functionality
// const userData = JSON.parse(sessionStorage.getItem('userData'));
//     if (userData != null) {
//         console.log('Deleting!');
//         document.querySelectorAll('.btn btn-danger').addEventListener('click', ()=>{
//         });
//     }

