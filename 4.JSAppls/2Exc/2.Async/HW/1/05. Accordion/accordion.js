function solution() {
    getData()
}
solution()

async function getData() {
    const url = 'http://localhost:3030/jsonstore/advanced/articles/list';
    const res = await fetch(url);
    const data = await res.json();

    data.map(createBoxes)

}

function createBoxes(box) {
    const sectionElement = document.querySelector('section')
    const firstDiv = document.createElement('div');

    firstDiv.classList.add('accordion');


    const spanElement = document.createElement('span');
    spanElement.textContent = box.title;
    const button = document.createElement('button');
    button.id = box._id;
    button.textContent = 'More'
    button.classList.add('button')
    button.id = box._id;

    const secondDiv = document.createElement('div');
    secondDiv.classList.add('head');
    secondDiv.appendChild(button)
    secondDiv.appendChild(spanElement);
    firstDiv.appendChild(secondDiv);
    sectionElement.appendChild(firstDiv)




    const thirdDiv = document.createElement('div');
    thirdDiv.classList.add('extra');
    thirdDiv.id = box._id;
    const pElement = document.createElement('p');
    pElement.id = box._id;
    pElement.textContent = 'Lets do it baby'
    thirdDiv.appendChild(pElement)

    sectionElement.appendChild(thirdDiv);

    sectionElement.addEventListener('click', revealData)


}

async function revealData(event) {
    let button = event.target
    let currentId = button.id;
        const url = 'http://localhost:3030/jsonstore/advanced/articles/details/' + currentId;
        const res = await fetch(url);
        const data = await res.json();
        if (button.tagName != 'BUTTON') {
            return;
        }

        [...document.querySelectorAll('p')].forEach(p => {
            if(p.id === currentId) {
                p.textContent = data.content;
                [...document.querySelectorAll('.extra')].forEach(ex => {
                    if(ex.id === currentId) {
                        ex.style.display == 'block' ? ex.style.display = 'none' : ex.style.display = 'block';
                        button.textContent == 'More' ? button.textContent = 'Less' : button.textContent = 'More'
                    }
                })

            }    
        });
        
}

