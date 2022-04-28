function attachEvents() {
    const symbols = {
        'Sunny': '\u2600',
        'Partly sunny': '\u26C5',
        'Overcast': '\u2601',
        'Rain': '\u2614',
        'Degrees': '\u00B0',
    }
    const submitedLocation = document.getElementById('location');
    const forecastSection = document.getElementById('forecast');
    const conditionDiv = document.getElementById('current');
    const forecastDiv = document.getElementById('upcoming');
    const btn = document.getElementById('submit')
    btn.addEventListener('click', getWeather);

    async function getWeather() {
        try {
            const res = await fetch(`http://localhost:3030/jsonstore/forecaster/locations`);
            if (res.status != 200) {
                throw new Error('An error occurred');
            }

            const locationsArray = await res.json();
            const location = locationsArray.find(x => x.name == submitedLocation.value);

            const current = await showCurrent(location.code);
            const forecasts = await shwoForecast(location.code);
            console.log(forecasts);

            const currentForecasts = e('div', { classList: 'forecasts' },
                e('span', { classList: 'condition symbol' }, `${symbols[current.forecast.condition]}`),
                e('span', { classList: 'condition' },
                    e('span', { classList: 'forecast-data' }, current.name),
                    e('span', { classList: 'forecast-data' }, `${current.forecast.low}${symbols["Degrees"]}/${current.forecast.high}${symbols["Degrees"]}`),
                    e('span', { classList: 'forecast-data' }, current.forecast.condition)
                )
            )

            const forecastInfo = document.createElement('div');
            for (let current of forecasts.forecast) {
                const forecast = e('span', { classList: 'upcoming' },
                    e('span', { classList: 'symbol' }, `${symbols[current.condition]}`),
                    e('span', { classList: 'forecast-data' }, `${current.low}${symbols["Degrees"]}/${current.high}${symbols["Degrees"]}`),
                    e('span', { classList: 'forecast-data'}, current.condition)
                )
                forecastInfo.appendChild(forecast);
            }

            forecastSection.style.display = 'block';
            conditionDiv.appendChild(currentForecasts);
            forecastDiv.appendChild(forecastInfo);

        } catch (error) {
            console.log(error);
            forecastSection.style.display = 'block';
            forecastSection.innerHTML = 'Error';
        }
    }

    async function showCurrent(code) {
        const res = await fetch(`http://localhost:3030/jsonstore/forecaster/today/${code}`);
        return res.json();
    }

    async function shwoForecast(code) {
        const res = await fetch(`http://localhost:3030/jsonstore/forecaster/upcoming/${code}`);
        return res.json();
    }

    function e(type, attr, ...content) {
        const element = document.createElement(type);

        for (let prop in attr) {
            element[prop] = attr[prop];
        }
        for (let item of content) {
            if (typeof item == 'string' || typeof item == 'number') {
                item = document.createTextNode(item);
            }
            element.appendChild(item);
        }

        return element;
    }
}

attachEvents();