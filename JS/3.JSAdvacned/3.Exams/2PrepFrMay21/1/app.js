function solve(){
   let titleIE = document.querySelector('#title');
   let categoryIE = document.querySelector('#category');
   let authorIE = document.getElementById('creator');
   let contentIE = document.querySelector('#content');
   
   let createBtn = document.querySelector('.btn.create');
   createBtn.addEventListener('click',(e)=>{
      e.preventDefault();

      let h1E = document.createElement('h1');
      h1E.textContent = titleIE.value;

      let p1E = document.createElement('p');
      p1E.textContent = 'Category:';
      let strong1E = document.createElement('strong');
      strong1E.textContent = categoryIE.value;
      p1E.appendChild(strong1E);

      let p2E = document.createElement('p');
      p2E.textContent = 'Creator:';
      let strong2E = document.createElement('strong');
      strong2E.textContent = authorIE.value;
      p2E.appendChild(strong2E);

      let p3E = document.createElement('p')
      p3E.textContent = contentIE.value;

      let divE = document.createElement('div');
      divE.classList.add('buttons');
      let delBtnE = document.createElement('button');
      delBtnE.classList.add(['btn', 'delete']);
      delBtnE.textContent = 'Delete';
      let archBtnE = document.createElement('button');
      archBtnE.classList.add(['btn', 'archive']);
      archBtnE.textContent = 'Archive';
      divE.appendChild(delBtnE);
      divE.appendChild(archBtnE);

      let articleE = document.createElement('article');
      articleE.appendChild(h1E);
      articleE.appendChild(p1E);
      articleE.appendChild(p2E);
      articleE.appendChild(p3E);
      articleE.appendChild(divE);

      let sectionE = document.querySelector('main section');
      sectionE.appendChild(articleE);
   })
}
