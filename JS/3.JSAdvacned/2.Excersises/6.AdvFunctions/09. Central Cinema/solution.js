function solve() {
    let movieNameE = document.querySelectorAll('#container input')[0];
    let hallE = document.querySelectorAll('#container input')[1];
    let priceE = document.querySelectorAll('#container input')[2];
    let onScreenBtnE = document.querySelector('#container button');
    let onScreenSect = document.querySelector('#movies ul');
    let archSect = document.querySelector('#archive ul');

    onScreenBtnE.addEventListener('click', (e) => {
        e.preventDefault();

        if (movieNameE.value && hallE.value && Number(priceE.value)) {
            let movieNameSpan = document.createElement('span');
            movieNameSpan.textContent = movieNameE.value;
            movieNameE.value = '';

            let hallStrong = document.createElement('strong');
            hallStrong.textContent = `Hall: ${hallE.value}`;
            hallE.value = '';

            let priceStrong = document.createElement('strong');
            priceStrong.textContent = Number(priceE.value).toFixed(2);
            priceE.value = '';
            let soldInput = document.createElement('input');
            soldInput.placeholder = 'Tickets Sold';
            let arcBtn = document.createElement('button');
            arcBtn.textContent = 'Archive';
            let movieDiv = document.createElement('div');
            movieDiv.appendChild(priceStrong);
            movieDiv.appendChild(soldInput);
            movieDiv.appendChild(arcBtn);

            let movieLi = document.createElement('li');
            movieLi.appendChild(movieNameSpan);
            movieLi.appendChild(hallStrong);
            movieLi.appendChild(movieDiv);
            onScreenSect.appendChild(movieLi);

            arcBtn.addEventListener('click', () => {
                if (soldInput.value === '') { return }
                let profitStrong = document.createElement('strong');
                profitStrong.textContent = `Total amount: ${(priceStrong.textContent * Number(soldInput.value)).toFixed(2)}`;

                let delBtn = document.createElement('button');
                delBtn.textContent = 'Delete';

                let movieArchLi = document.createElement('li');
                movieArchLi.appendChild(movieNameSpan);
                movieArchLi.appendChild(profitStrong);
                movieArchLi.appendChild(delBtn);
                archSect.appendChild(movieArchLi);

                movieLi.remove();

                delBtn.addEventListener('click', () => {
                    movieArchLi.remove();
                })

                let archDelBtn = document.querySelector('#archive>button');
                archDelBtn.addEventListener('click', () => {
                    document.querySelector('#archive ul').innerHTML = '';
                })

            })
        }
    })
}