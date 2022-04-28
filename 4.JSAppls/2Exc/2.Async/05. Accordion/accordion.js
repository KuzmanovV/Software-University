async function solution() {
    const url = `http://localhost:3030/jsonstore/advanced/articles/list`;

    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();

        data.forEach(e => {
            const span = document.createElement('span');
            span.textContent = e.title;

            const btn = document.createElement('button');
            btn.classList.add('button');
            btn.id = e._id;
            btn.textContent = 'More';
            btn.addEventListener('click', morePressed);

            const headDiv = document.createElement(`div`);
            headDiv.classList.add('head');
            headDiv.appendChild(span);
            headDiv.appendChild(btn);

            const extraDiv = document.createElement(`div`);
            extraDiv.classList.add('extra');

            const accDiv = document.createElement(`div`);
            accDiv.classList.add('accordion');
            accDiv.appendChild(headDiv);
            accDiv.appendChild(extraDiv);

            const mainDiv = document.getElementById('main');
            mainDiv.appendChild(accDiv);
        });
    } catch (error) {
        btn.textContent = 'Error!'
    }
}

async function morePressed(e) {
    const btn = e.target;
    const id = btn.id;

    if (btn.textContent == 'More') {
        btn.textContent = 'Loading...'

        const url = `http://localhost:3030/jsonstore/advanced/articles/details/` + id;
        try {
            const res = await fetch(url);
            if (res.status != 200) {
                throw new Error();
            }
            const data = await res.json();

            const p = document.createElement('p');
            p.textContent = data.content;
            const extraDiv = btn.parentElement.parentElement.lastChild;
            extraDiv.appendChild(p);
            extraDiv.style.display = 'block';

            btn.textContent = 'Less';
        } catch (error) {
            btn.textContent = 'Error!'
        }
    } else {
        const extraDiv = btn.parentElement.parentElement.lastChild;
        extraDiv.replaceChildren();
        btn.textContent = 'More';
    }
}

solution();