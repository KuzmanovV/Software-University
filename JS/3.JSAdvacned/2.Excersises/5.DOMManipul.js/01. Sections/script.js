function create(words) {
   let contentE = document.getElementById('content');
   words.forEach(word => {
      let di = document.createElement('div');
      let para = document.createElement('p');
      di.appendChild(para);
      para.textContent = word;
      para.style.display = 'none';
      contentE.appendChild(di);
   });

   contentE.addEventListener('click', e =>{
      if (e.target.tagName == 'DIV' && e.target != contentE) {
         e.target.children[0].style.display = '';
      }
   })
}