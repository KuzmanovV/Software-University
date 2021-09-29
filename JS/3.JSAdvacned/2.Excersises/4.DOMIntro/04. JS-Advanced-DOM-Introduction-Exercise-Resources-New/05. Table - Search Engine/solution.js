function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let fieldE = document.querySelectorAll('tbody tr');
      let searchE = document.getElementById('searchField').value;

      for (const field of fieldE) {
         if (field.textContent.includes(searchE)) {
            field.classList.add('select');
         } else {
            field.classList.remove('select');
         }
      }

      document.getElementById('searchField').value = "";
   }
}