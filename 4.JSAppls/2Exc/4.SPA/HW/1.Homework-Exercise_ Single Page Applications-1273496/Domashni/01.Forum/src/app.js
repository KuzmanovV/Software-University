import { newTopic } from './topic.js';
import { homePage } from './home.js';

function addEvents() {
    const publicBtn = document.querySelector('.public');
    publicBtn.addEventListener('click', newTopic);

    const cancelBtn = document.querySelector('.cancel');
    cancelBtn.addEventListener('click', (e) => {
        const form = e.target.parentNode.parentNode;
        form.reset();
    });
}

homePage();
addEvents();