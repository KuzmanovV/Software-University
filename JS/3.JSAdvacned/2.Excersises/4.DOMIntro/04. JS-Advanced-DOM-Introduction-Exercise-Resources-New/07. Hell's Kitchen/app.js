function solve() {
   document.querySelector('#btnSend').addEventListener('click', onClick);

   function onClick() {
      let inpArr = JSON.parse(document.querySelector('#inputs textarea').value);
      let restaurants = {};

      inpArr.forEach(element => {
         let [restName, workersStr] = element.split(' - ');
         let workersObjectsArr = workersStr.split(', ').map(w => {
            let [name, salary] = w.split(' ');
            return { name, salary: Number(salary) };

         })

         if (!restaurants[restName]) {
            restaurants[restName] = {
               workers: [],
               getAvSalary() {
                  return this.workers.reduce((acc, el) => acc + el, 0) / this.workers.length;
               }
            }
         }

         restaurants[restName].workers = restaurants[restName].workers.concat(workersObjectsArr);
      });


      let sortedRests = Object.entries(restaurants)
         .sort((a, b) => b[1].getAvSalary() - a[1].getAvSalary());

      let bestRestaurant = sortedRests[0];
      let sortedWorkers = bestRestaurant[1].workers.sort((a, b) => b.salary - a.salary);

      let bestRestEl = document.querySelector('#bestRestaurant p');
      bestRestEl.textContent = `Name: ${bestRestaurant[0]} Average Salary: ${bestRestaurant[1].getAvSalary().toFixed(2)} Best Salary: ${sortedWorkers[0].salary.toFixed(2)} `;
      let workersStr = sortedWorkers
         .map(x => `Name: ${x.name} With Salary: ${x.salary}`)
         .join(' ');
   }
}