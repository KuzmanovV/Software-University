function solve() {

    let stop = {next: 'depot'};
    const departBtn = document.getElementById('depart');
    const arriveBtn = document.getElementById('arrive');
    const stopInfo = document.querySelector('#info .info');

    async function depart() {
        const url = `http://localhost:3030/jsonstore/bus/schedule/${stop.next}`;
        try {
            departBtn.disabled = 'disabled';
            stopInfo.textContent = `Loading...`;
            
            const res = await fetch(url);
            if (res.status != 200) {
                throw new Error();
            }
            stop = await res.json();
            stopInfo.textContent = `Next stop ${stop.name}`;
            nextStopID = stop.next;

            arriveBtn.disabled = '';
        } catch (error) {
            stopInfo.textContent = 'Error';
        }
    }

    function arrive() {
        stopInfo.textContent = `Arriving at ${stop.name}`;
        
        departBtn.disabled = '';
        arriveBtn.disabled = 'disabled';
    }

    return {
        depart,
        arrive
    };
}

let result = solve();