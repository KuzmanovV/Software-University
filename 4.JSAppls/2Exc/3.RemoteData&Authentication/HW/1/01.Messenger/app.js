function attachEvents() {
    document.getElementById('refresh').addEventListener('click', loadMessages);
    document.getElementById('submit').addEventListener('click', onSubmit);
}

const list = document.getElementById('messages');
const authorInput = document.querySelector('[name="author"]');
const contentInput = document.querySelector('[name="content"]');

attachEvents();

async function onSubmit() {
    const author = authorInput.value;
    const content = contentInput.value;

    const messagesContainer = list.value;
    list.value = 'Loading...';

    await createMessage({ author, content });

    contentInput.value = '';
    authorInput.value = '';
    list.value = messagesContainer;
    list.value += '\n' + `${author}: ${content}`;
}

const url = `http://localhost:3030/jsonstore/messenger`;

async function loadMessages() {
    try {
        list.value = 'Loading...';
        
        const res = await fetch(url);
        if (res.status!=200) {
            throw new Error();
        }
        const messages = Object.values(await res.json());
        list.value = messages.map(m => `${m.author}: ${m.content}`).join('\n');
    } catch (error) {
        list.value = 'ERROR!';
    }
}

async function createMessage(message) {
    try {
        const options = {
            method: 'post',
            headers: {
                'Content-type': 'aplication/json'
            },
            body: JSON.stringify(message)
        };
        const res = await fetch(url, options);
        if (res.status!=200) {
            throw new Error();
        }
        return await res.json();
    } catch (error) {
        list.value = 'ERROR!';
    }
}