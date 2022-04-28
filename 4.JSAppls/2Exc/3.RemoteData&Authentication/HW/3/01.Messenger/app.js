function attachEvents() {
    submitBtn.addEventListener('click', submitMsg)
    refreshBtn.addEventListener('click', loadMsgs)
    loadMsgs();
}

const refreshBtn = document.getElementById('refresh');
const submitBtn = document.getElementById('submit');
const chatBox = document.getElementById('messages');
const authorInput = document.querySelector('[name="author"]');
const contentInput = document.querySelector('[name="content"]');

async function loadMsgs() {
    const url = 'http://localhost:3030/jsonstore/messenger';
    chatBox.value = 'Chat loading, please wait...';

    refreshBtn.disabled = true;
    const response = await fetch(url);
    const data = await response.json();

    const msgString = Object.values(data).map((el) => `${el.author}: ${el.content}`).join('\n');

    chatBox.value = msgString;
    refreshBtn.disabled = false;

    // return Object.values(data);
}

async function submitMsg() {
    submitBtn.disabled = true;
    
    const author = authorInput.value;
    const msg = contentInput.value;
    
    try {
        if (author === '' || msg === '') {
            throw new Error('Please fill up all the fields.')
        }
        contentInput.value = '';

        const url = 'http://localhost:3030/jsonstore/messenger';
        const response = await fetch(url, {
            method: 'post',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                author: author.trim(),
                content: msg.trim()
            })
        });
        chatBox.value += `\n${author.trim()}: ${msg.trim()}`
    } catch (error) {
        alert(error.message)
    }
    submitBtn.disabled = false;
}

attachEvents();