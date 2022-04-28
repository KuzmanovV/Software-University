async function getInfo() {
    let stopInfo = document.querySelector('#stopInfo');
    let input = stopInfo.querySelector('div > input#stopId');
    let stopName = stopInfo.querySelector('div#result > #stopName');
    let buses = stopInfo.querySelector('div#result > #buses');

    let url = `http://localhost:3030/jsonstore/bus/businfo/${input.value}`;

    stopName.textContent = '';
    buses.textContent = '';
    stopName.textContent = 'Loading...';

    try {
        let response = await fetch(url);

        if (response.ok == true) {
            let data = await response.json();

            stopName.textContent = data.name;

            for (let bus in data.buses) {
                let li = document.createElement('li');
                li.textContent = `Bus ${bus} arrives in ${data.buses[bus]} minutes`;
                buses.appendChild(li);
            }
        }
        else{
            throw new Error('');
        }
    } catch (error) {
        stopName.textContent = 'Error';
        buses.textContent = '';
    }

}