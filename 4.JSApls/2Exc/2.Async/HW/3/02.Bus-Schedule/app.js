function solve() {

    let currentStop = '';
    let nextStop = 'depot';
    let info = document.querySelector('#info > span.info');
    let departBtn = document.querySelector('#depart');
    let ariveBtn = document.querySelector('#arrive');

    async function depart() {
        departBtn.disabled = true;
        const url = `http://localhost:3030/jsonstore/bus/schedule/${nextStop}`;
        let response = await fetch(url);

        try {
            if (response.ok == true) {
                let data = await response.json();
                nextStop = data.next;
                currentStop = data.name;
                info.textContent = `Next stop ${currentStop}`;

                ariveBtn.disabled = false;
            }
            else {
                throw new Error('');
            }
        }
        catch (error) {
            departBtn.disabled = true;
            ariveBtn.disabled = true;
            info.textContent = 'Error';
        }
    }

    async function arrive() {
        departBtn.disabled = false;
        ariveBtn.disabled = true;
        info.textContent = `Arriving at ${currentStop}`;
    }

    return {
        depart,
        arrive
    };
}

let result = solve();