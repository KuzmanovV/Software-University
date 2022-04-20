function solve() {
    const infoSpan = document.querySelector('.info');
    const departBtn = document.querySelector('#depart');
    const arriveBtn = document.querySelector('#arrive');
    let nextId = 'depot';
    async function depart() {
        infoSpan.textContent = 'Please wait :)'
        const url = `http://localhost:3030/jsonstore/bus/schedule/${nextId}`
        const res = await fetch(url);
        const data = await res.json();
        infoSpan.textContent = `Next stop ${data.name}`

        
        departBtn.disabled = true;
        arriveBtn.disabled = false;


    }

    async function arrive() {
       infoSpan.textContent = 'Please wait :)'
       const url = `http://localhost:3030/jsonstore/bus/schedule/${nextId}`
       const res = await fetch(url);
       const data = await res.json();

       infoSpan.textContent = `Arriving at ${data.name}`
    
       departBtn.disabled = false;
       arriveBtn.disabled = true;
       nextId = data.next;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();