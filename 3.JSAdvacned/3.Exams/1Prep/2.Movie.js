class Movie {
    constructor(movieName, ticketPrice) {
        this.movieName = movieName;
        this.ticketPrice = Number(ticketPrice);
        this.screenings = [];
        this.totalProfit = 0;
        this.totalSoldTickets = 0;
    }

    newScreening(date, hall, description) {
        if (this.screenings.some(m => m.date == date && m.hall == hall)) {
            throw new Error(`Sorry, ${hall} hall is not available on ${date}`);
        } else {
            this.screenings.push({date, hall, description});
            return `New screening of ${this.movieName} is added.`;
        }
    }

    endScreening(date, hall, soldTickets) {
        if (this.screenings.some(m => m.date == date && m.hall == hall)) {
            let currentProfit = soldTickets*this.ticketPrice;
            this.totalProfit+=currentProfit;
            this.totalSoldTickets+=soldTickets;
            this.screenings = this.screenings.filter(m=>m.hall!=hall || m.date != date);
            return `${this.movieName} movie screening on ${date} in ${hall} hall has ended. Screening profit: ${currentProfit}`
        } else{
            throw new Error(`Sorry, there is no such screening for ${this.movieName} movie.`);
        }
        
    }

    toString() {
        let result = [];
        result.push(`${this.movieName} full information:`);
        result.push(`Total profit: ${this.totalProfit.toFixed(0)}$`);
        result.push(`Sold Tickets: ${this.totalSoldTickets}`);

        if (this.screenings.length==0) {
            result.push(`No more screenings!`);
        } else{
            this.screenings = this.screenings.sort((a,b)=>a.hall.localeCompare(b.hall));
            result.push(`Remaining film screenings:`);
            this.screenings.forEach(element => {
                result.push(`${element.hall} - ${element.date} - ${element.description}`);
            });
        }

        return result.join(`\n`);
    }
}

let m = new Movie('Wonder Woman 1984', '10.00');
console.log(m.newScreening('October 2, 2020', 'IMAX 3D', `3D`));
console.log(m.newScreening('October 3, 2020', 'Main', `regular`));
console.log(m.newScreening('October 4, 2020', 'IMAX 3D', `3D`));
console.log(m.endScreening('October 2, 2020', 'IMAX 3D', 150));
console.log(m.endScreening('October 3, 2020', 'Main', 78));
m.newScreening('October 4, 2020', '235', `regular`);
m.newScreening('October 5, 2020', 'Main', `regular`);
m.newScreening('October 3, 2020', '235', `regular`);
m.newScreening('October 4, 2020', 'Main', `regular`);
console.log(m.toString());



