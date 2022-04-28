async function solution() {
    let main = document.querySelector('#main');

    let url = 'http://localhost:3030/jsonstore/advanced/articles/list';
    let response = await fetch(url);

    if (response.ok == false) {
        throw new Error('');
    }

    let data = await response.json();

    Object.keys(data).forEach((arti, i) => {
        let { _id, title } = data[arti];

        let article = `        
        <div class="accordion">
            <div class="head">
                <span>${title}</span>
                <button class="button" id=${_id}>More</button>
            </div>
            <div class="extra">
                <p></p>
            </div>
        </div>`;

        main.insertAdjacentHTML('beforebegin', article);
    });

    document.addEventListener('click', getContent);

    async function getContent(event) {
        let isError = false;
        let target = (event.target);
        target.parentElement.parentElement.querySelector('.extra').style.display = 'none';

        let extrasUrl = `http://localhost:3030/jsonstore/advanced/articles/details/${target.id}`;

        try {
            let res = await fetch(extrasUrl);

            if (res.ok == false) {
                throw new Error('');
            }

            let extraDetails = await res.json();

            let content = (extraDetails.content);
            let extraP = target.parentElement.parentElement.querySelector('.extra p');
            extraP.textContent = content;

            toggle(target, isError);

        } catch (error) {
            isError = true;
            toggle(target, isError);
        }
    }

    function toggle(target, isError) {
        let accordion = target.parentElement.parentElement;
        let extra = accordion.querySelector('.extra');

        if (target.textContent.includes('More')) {
            if (isError) {
                accordion.querySelector('.extra p').textContent = 'Error!';
            }
            target.textContent = 'Less';
            extra.style.display = 'block';
        }
        else {
            if (isError) {
                accordion.querySelector('.extra p').textContent = '';
            }
            target.textContent = 'More';
            extra.style.display = 'none';
        }
    }
}