function tickets(tdescrArr, criteria) {
    class Ticket {
        constructor(destination, price, status) {
            this.destination = destination;
            this.price = Number(price);
            this.status = status;
        }
    }

    let db = [];

    tdescrArr.forEach(element => {
        let [destination, price, status] = element.split('|');
        db.push(Object.entries(new Ticket(destination, price, status)));
    });

    let sortingFuncs = {
        destination: () => {
            return db.sort((a, b) => a[0][1].localeCompare(b[0][1]));
        },
        price: () => {
            return db.sort((a, b) => a[1][1] - b[1][1]);
        },
        status: () => {
            return db.sort((a, b) => a[2][1].localeCompare(b[2][1]));
        }
    }

    let outputArr = [];
    sortingFuncs[criteria]().forEach(element => {
        outputArr.push(new Ticket(element[0][1],element[1][1],element[2][1]));
    });
    return outputArr;
}

console.log(tickets(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'
));