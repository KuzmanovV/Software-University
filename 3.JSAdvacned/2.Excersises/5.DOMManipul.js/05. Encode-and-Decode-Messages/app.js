function encodeAndDecodeMessages() {
    let texts = document.querySelectorAll('textarea');
    let buttons = document.querySelectorAll('button');

    let action = {
        encode: {
            text: texts[0],
            btn: buttons[0],
            func: (char) => String.fromCharCode(char.charCodeAt(0) + 1)
        },
        decode: {
            text: texts[1],
            btn: buttons[1],
            func: (char) => String.fromCharCode(char.charCodeAt(0) - 1)
        }
    };

    document.getElementById('main').addEventListener('click', (e)=>{
        if (e.target.tagName!=='BUTTON') {
            return;
        }

        let type = e.target.textContent.includes('Encode') ? 'encode' : 'decode';

        let message = action[type].text.value
                                    .split('').map(action[type].func).join('');

        action.encode.text.value = '';
        action.decode.text.value = message;
    })
}