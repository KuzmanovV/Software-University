function attachEvents() {
    document.getElementById('submit').addEventListener('click', getForcast);
}

attachEvents();

 let symbols = {
        Sunny: '\u2600', // ☀
        'Partly sunny': '\u26C5', // ⛅
        Overcast: '\u2601', // ☁
        Rain: '\u2614', // ☂
        Degrees: '°',
    }

async function getForcast() {

    let name = document.getElementById('location').value;
    const code = await getLoctionCode(name);
    
    const [current, upcoming] = await Promise.all([
        getCurrent(code),
        getUpcoming(code),
    ]);

    createCurrentCondition(current)
    
    upcoming.forecast.forEach((w) => {
    let forcastInfoDiv = document.createElement('div');
    forcastInfoDiv.classList.add('forecast-info');
    
    let upcomingSpan = document.createElement('span');
    upcomingSpan.classList.add('upcoming');
    let symbolSpan = document.createElement('span');
    symbolSpan.classList.add('symbol');
    if(w.condition === 'Sunny') {
        symbolSpan.textContent = symbols.Sunny;
    } else if(w.condition === 'Overcast') {
        symbolSpan.textContent = symbols.Overcast;
    } else if(w.condition === 'Rain') {
        symbolSpan.textContent = symbols.Rain;
    } else if(w.condition === 'Partly sunny') {
        symbolSpan.textContent = symbols['Partly sunny'];
    }
    upcomingSpan.appendChild(symbolSpan);
    let forecastDataFirstSpan = document.createElement('span');
    forecastDataFirstSpan.classList.add('forecast-data');
    forecastDataFirstSpan.textContent = `${w.low}${symbols.Degrees}/${w.high}${symbols.Degrees}`
    upcomingSpan.appendChild(forecastDataFirstSpan);
    let forcastDataSecondSpan = document.createElement('span');
    forcastDataSecondSpan.classList.add('forecast-data');
    forcastDataSecondSpan.textContent = `${w.condition}`
    upcomingSpan.appendChild(forcastDataSecondSpan);
    forcastInfoDiv.appendChild(upcomingSpan);

    document.getElementById('upcoming').appendChild(forcastInfoDiv)
    })
    
}

function createCurrentCondition(current) {
    let currentDiv  = document.getElementById('current');

   let forecastDiv = document.createElement('div');
   forecastDiv.classList.add('forecasts')

   let conditionSymbolSpan = document.createElement('span');
   conditionSymbolSpan.classList.add('condition-symbol');
   conditionSymbolSpan.textContent = symbols.Sunny;
   forecastDiv.appendChild(conditionSymbolSpan);

   let conditionSpan = document.createElement('span');
   conditionSpan.classList.add('condition');
   let firstForecastDataSpan = document.createElement('span');
   firstForecastDataSpan.classList.add('forecast-data');
   firstForecastDataSpan.textContent = current.name;
   conditionSpan.appendChild(firstForecastDataSpan);
   let secondForecastDataSpan = document.createElement('span');
   secondForecastDataSpan.classList.add('forecast-data');
   secondForecastDataSpan.textContent = `${current.forecast.low}${symbols.Degrees}/${current.forecast.high}${symbols.Degrees}`
   conditionSpan.appendChild(secondForecastDataSpan);
   let thirdForecastDataSpan = document.createElement('span');
   thirdForecastDataSpan.classList.add('forecast-data');
   thirdForecastDataSpan.textContent = current.forecast.condition;
   conditionSpan.appendChild(thirdForecastDataSpan);

   forecastDiv.appendChild(conditionSpan);
   currentDiv.appendChild(forecastDiv)


   
    
    document.getElementById('forecast').style.display = '';
    document.getElementById('submit').disabled = true;

}

async function getLoctionCode(name) {
    const url = 'http://localhost:3030/jsonstore/forecaster/locations';

    const res = await fetch(url);
    const data = await res.json();

    const location = data.find(l => l.name == name)

    return location.code;
}

async function getCurrent(code) {
    const url = 'http://localhost:3030/jsonstore/forecaster/today/' + code;

    const res = await fetch(url);
    const data = await res.json();

    return data
}

async function getUpcoming(code) {
    const url = 'http://localhost:3030/jsonstore/forecaster/upcoming/' + code;

    const res = await fetch(url);
    const data = await res.json();

    return data
}