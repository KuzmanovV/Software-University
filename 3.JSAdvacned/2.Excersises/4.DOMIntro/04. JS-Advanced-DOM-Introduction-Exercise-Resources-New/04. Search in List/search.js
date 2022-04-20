function search() {
   let townsElements = document.querySelectorAll('li');
   let searchE = document.getElementById('searchText').value;
   let resultE = document.getElementById("result");
   let matches = 0;

   for (const town of townsElements) {
      if (town.textContent.includes(searchE)) {
         town.style.fontWeight = 'bold';
         town.style.textDecoration = 'underline';
         matches++;
      } else {
         town.style.fontWeight = 'normal';
         town.style.textDecoration = 'none';
      }
   }

   resultE.textContent = `${matches} matches found`;
}
