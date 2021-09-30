function attachEventsListeners() {
    let ratios = {
        days: 1,
        hours: 24,
        minutes: 1440,
        seconds: 86400
    }

    function convert(value, unit) {
        inDays = value / ratios[unit];
        return {
            days: inDays,
            hours: inDays * ratios.hours,
            minutes: inDays * ratios.minutes,
            seconds: inDays * ratios.seconds
        }
    }

    let daysInputE = document.getElementById('days');
    let hoursInputE = document.getElementById('hours');
    let minutesInputE = document.getElementById('minutes');
    let secondsInputE = document.getElementById('seconds');

    document.querySelector('main').addEventListener('click', e => {
        if (e.target.tagName == 'INPUT' && e.target.type == 'button') {
            let inputE = e.target.parentElement.querySelector('input[type="text"]');
            let time = convert(Number(inputE.value), inputE.id);
            daysInputE.value = time.days;
            hoursInputE.value = time.hours;
            minutesInputE.value = time.minutes;
            secondsInputE.value = time.seconds;
        }
    })
}