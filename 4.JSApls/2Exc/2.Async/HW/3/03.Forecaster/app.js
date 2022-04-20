async function attachEvents() {
    let forecast = document.querySelector('#forecast');
    let inputName = document.querySelector('#location');

    let submitBtn = document.querySelector('#submit');
    submitBtn.addEventListener('click', submitFn.bind(null, inputName, forecast));

    async function submitFn(inputName, forecast) {
        forecast.style.display = 'none';
        forecast.querySelector('#upcoming').style.display = 'block';
        forecast.querySelector('#current > div').textContent = 'Current conditions';

        let locationUrl = 'http://localhost:3030/jsonstore/forecaster/locations';

        let response = await fetch(locationUrl);
        let data = await response.json();

        try {
            let founded = data.filter(x => x.name.toLowerCase() == inputName.value.toLowerCase());

            if (inputName.value != null && response.ok == true && founded.length >= 1) {
                weatherLocation(founded, forecast);
            } else {
                throw new Error('Error');
            }

        } catch (error) {
            forecast.querySelector('#upcoming').style.display = 'none';
            forecast.querySelector('#current > div').textContent = 'Error';
            forecast.style.display = 'block';
        }
    }

    async function weatherLocation(founded, forecast) {

        forecast.style.display = 'block';

        let symbols = {
            Sunny: '☀',
            'Partly-sunny': '⛅',
            Overcast: '☁',
            Rain: '☂',
            Degrees: '°'
        };

        //current condition
        createCurrentCondition(founded, forecast, symbols);

        //upcoming condition
        createUpcomingCondition(founded, forecast, symbols);

    }
}

async function createUpcomingCondition(founded, forecast, symbols) {
    let upcomingCondition = forecast.querySelector('#upcoming');
    upcomingCondition.removeChild(upcomingCondition.lastChild);

    let locationCode = founded[0].code;
    let url = `http://localhost:3030/jsonstore/forecaster/upcoming/${locationCode}`;

    let response = await fetch(url);

    if (response.ok == true) {
        let data = await response.json();
        let upcomingDays = data.forecast;

        let divUpcomingInfo = document.createElement('div');
        divUpcomingInfo.className = 'forecast-info';

        for (let day of upcomingDays) {
            let conditionSymbol = document.createElement('span');
            conditionSymbol.className = 'symbol';
            conditionSymbol.textContent = Object.entries(symbols)
                .filter(
                    key => key[0]
                        .includes(day.condition.slice(0, 4))
                )[0][1];

            let infoTemperature = document.createElement('span');
            infoTemperature.className = 'forecast-data';
            infoTemperature.textContent = `${day.low}${symbols.Degrees}/${day.high}${symbols.Degrees}`;

            let infoCondition = document.createElement('span');
            infoCondition.className = 'forecast-data';
            infoCondition.textContent = `${day.condition}`;

            let upcomingSpan = document.createElement('span');
            upcomingSpan.className = 'upcoming';
            upcomingSpan.appendChild(conditionSymbol);
            upcomingSpan.appendChild(infoTemperature);
            upcomingSpan.appendChild(infoCondition);

            divUpcomingInfo.appendChild(upcomingSpan);
        }

        upcomingCondition.appendChild(divUpcomingInfo);
    }
}

async function createCurrentCondition(founded, forecast, symbols) {
    let currentCondition = forecast.querySelector('#current');
    currentCondition.removeChild(currentCondition.lastChild);

    let locationCode = founded[0].code;
    let url = `http://localhost:3030/jsonstore/forecaster/today/${locationCode}`;

    let response = await fetch(url);

    if (response.ok == true) {
        let data = await response.json();

        let conditionSymbol = document.createElement('span');
        conditionSymbol.className = 'condition symbol';
        conditionSymbol.textContent = symbols.Sunny;

        let infoLocation = document.createElement('span');
        infoLocation.className = 'forecast-data';
        infoLocation.textContent = `${data.name}`;

        let infoTemperature = document.createElement('span');
        infoTemperature.className = 'forecast-data';
        infoTemperature.textContent = `${data.forecast.low}${symbols.Degrees}/${data.forecast.high}${symbols.Degrees}`;

        let infoCondition = document.createElement('span');
        infoCondition.className = 'forecast-data';
        infoCondition.textContent = `${data.forecast.condition}`;

        let conditionInfo = document.createElement('span');
        conditionInfo.className = 'condition';
        conditionInfo.appendChild(infoLocation);
        conditionInfo.appendChild(infoTemperature);
        conditionInfo.appendChild(infoCondition);

        let currentDiv = document.createElement('div');
        currentDiv.className = 'forecasts';
        currentDiv.appendChild(conditionSymbol);
        currentDiv.appendChild(conditionInfo);

        currentCondition.appendChild(currentDiv);
    }
}

attachEvents();