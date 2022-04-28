async function getInfo() {

    const dataToAdd = document.getElementById('stopId').value;
    const url = `http://localhost:3030/jsonstore/bus/businfo/${dataToAdd}`;
    const timeTableElement = document.getElementById('buses');
    const stopName = document.getElementById('stopName');
  
    try{
       stopName.textContent = 'Please wait :)'
       timeTableElement.replaceChildren();
        const req = await fetch(url);
        
        if(req.status != 200) {
            throw new Error('Invalid stopId')
        }
        
        const data = await req.json();
        stopName.textContent = data.name

        Object.entries(data.buses).forEach(b => {
            const liElement = document.createElement('li');
            liElement.textContent = `Bus ${b[0]} arrives in ${b[1]} minutes`;
            timeTableElement.appendChild(liElement)
        })

    } catch(error) {
        stopName.textContent = 'Error'
    }
    
    
}