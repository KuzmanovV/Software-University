class Parking {
    constructor(capacity) {
        this.capacity = capacity;
        this.vehicles = [];
    }

    addCar(carModel, carNumber) {
        if (this.vehicles.length == this.capacity) {
            throw new Error('Not enough parking space.');
        }

        this.vehicles.push({ carModel, carNumber, payed: false });
        return `The ${carModel}, with a registration number ${carNumber}, parked.`
    }

    removeCar(carNumber) {
        let targetCar = this.vehicles.find(obj => obj.carNumber == carNumber);

        if (!targetCar) {
            throw new Error(`The car, you're looking for, is not found.`);
        }

        if (!targetCar.payed) {
            throw new Error(`${carNumber} needs to pay before leaving the parking lot.`);
        }

        this.vehicles = this.vehicles.filter(obj => { return obj.carNumber != carNumber });
        return `${carNumber} left the parking lot.`
    }

    pay(carNumber) {
        let targetCar = this.vehicles.find(obj => obj.carNumber == carNumber);

        if (!targetCar) {
            throw new Error(`${carNumber} is not in the parking lot.`);
        }

        if (targetCar.payed) {
            throw new Error(`${carNumber}'s driver has already payed his ticket.`);
        }

        targetCar.payed = true;
        return `${carNumber}'s driver successfully payed for his stay.`
    }

    getStatistics(carNumber) {
        if (!carNumber) {
            let result = `The Parking Lot has ${this.capacity-this.vehicles.length} empty spots left.`
            let sorted = this.vehicles.slice().sort((a,b)=>a.localeCompare(b));
            
            sorted.forEach(car => {
                result += `\n${car.carModel} == ${car.carNumber} - ${car.payed ? 'Has payed': 'Not payed'}`;
            });

            return result;
        }

        let targetCar = this.vehicles.find(obj=>obj.carNumber==carNumber);
        
        return `${ targetCar.carModel } == ${ targetCar.carNumber } - ${ targetCar.payed ? 'Has payed': 'Not payed'}`
    }
}

const parking = new Parking(12);

console.log(parking.addCar("Volvo t600", "TX3691CA"));
console.log(parking.getStatistics());

console.log(parking.pay("TX3691CA"));
console.log(parking.removeCar("TX3691CA"));


