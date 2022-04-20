function attachEvents() {
    document.getElementById('submit').addEventListener('click', getForcast);
}

attachEvents();

const currentDivElement = document.getElementById('current');

async function getForcast() {
    currentDivElement.textContent = 'Loading';

    const name = document.getElementById('location').value;

    try {
        const code = await getLocCode(name);
        const [current, upcoming] = await Promise.all([
            getCurrent(code),
            getUpcoming(code),
        ]);

        document.getElementById('forecast').style = 'display:block';
        const symbols = {
            'Sunny': "\u2600",
            'Partly sunny': '\u26C5',
            'Overcast': '\u2601',
            'Rain': '\u2614',
            'Degrees': '\xB0'
        }

        //Current 1 day
        currentDivElement.replaceChildren();
        const divLabelElement = document.createElement('div');
        divLabelElement.classList.add('label');
        divLabelElement.textContent = 'Current conditions';
        currentDivElement.appendChild(divLabelElement);

        const firstForecastSpan = document.createElement('span');
        firstForecastSpan.classList.add('forecast-data');
        firstForecastSpan.textContent = current.name;

        const secondForecastSpan = document.createElement('span');
        secondForecastSpan.classList.add('forecast-data');
        secondForecastSpan.textContent = `${current.forecast.low}${symbols['Degrees']}/${current.forecast.high}${symbols['Degrees']}`;

        const thirdForecastSpan = document.createElement('span');
        thirdForecastSpan.classList.add('forecast-data');
        thirdForecastSpan.textContent = current.forecast.condition;

        const conditionSpan = document.createElement('span');
        conditionSpan.classList.add('condition');
        conditionSpan.appendChild(firstForecastSpan);
        conditionSpan.appendChild(secondForecastSpan);
        conditionSpan.appendChild(thirdForecastSpan);

        const conditionSymbolSpan = document.createElement('span');
        conditionSymbolSpan.classList.add('condition', 'symbol');
        conditionSymbolSpan.textContent = symbols[current.forecast.condition];

        const forecastsDiv = document.createElement('div');
        forecastsDiv.classList.add('forecasts');
        forecastsDiv.appendChild(conditionSpan);
        forecastsDiv.appendChild(conditionSymbolSpan);

        currentDivElement.appendChild(forecastsDiv);

        //Forecast 3days
        const upcomingDivElement = document.getElementById('upcoming');
        const forecastsInfoDiv = document.createElement('div');
        forecastsInfoDiv.classList.add('forecasts-info');

        upcomingDivElement.replaceChildren();
        const nextDivLabelElement = document.createElement('div');
        nextDivLabelElement.classList.add('label');
        nextDivLabelElement.textContent = 'Three-day forecast';
        upcomingDivElement.appendChild(nextDivLabelElement);

        for (let i = 0; i < 3; i++) {
            const firstUpcomingSpan = document.createElement('span');
            firstUpcomingSpan.classList.add('symbol');
            firstUpcomingSpan.textContent = symbols[upcoming.forecast[i].condition];

            const secondUpcomingSpan = document.createElement('span');
            secondUpcomingSpan.classList.add('forecast-data');
            secondUpcomingSpan.textContent = `${upcoming.forecast[i].low}${symbols['Degrees']}/${upcoming.forecast[i].high}${symbols['Degrees']}`;

            const thirdUpcomingSpan = document.createElement('span');
            thirdUpcomingSpan.classList.add('forecast-data');
            thirdUpcomingSpan.textContent = upcoming.forecast[i].condition;

            const upcomingSpan = document.createElement('span');
            upcomingSpan.classList.add('upcoming');
            upcomingSpan.appendChild(firstUpcomingSpan);
            upcomingSpan.appendChild(secondUpcomingSpan);
            upcomingSpan.appendChild(thirdUpcomingSpan);

            forecastsInfoDiv.appendChild(upcomingSpan);
        }
        upcomingDivElement.appendChild(forecastsInfoDiv);

    } catch (error) {
        currentDivElement.textContent = 'Error!';
    }
}

async function getLocCode(name) {
    const url = `http://localhost:3030/jsonstore/forecaster/locations`;
    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();
        const loc = data.find(l => l.name == name);
        return loc.code;
    } catch (error) {
        currentDivElement.textContent = 'Error!';
    }
}

async function getCurrent(code) {
    const url = `http://localhost:3030/jsonstore/forecaster/today/` + code;
    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();
        return data;
    } catch (error) {
        currentDivElement.textContent = 'Error!';
    }
}

async function getUpcoming(code) {
    const url = `http://localhost:3030/jsonstore/forecaster/upcoming/` + code;
    try {
        const res = await fetch(url);
        if (res.status != 200) {
            throw new Error();
        }
        const data = await res.json();
        return data;
    } catch (error) {
        currentDivElement.textContent = 'Error!';
    }
}

