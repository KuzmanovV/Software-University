class SummerCamp {
    constructor(organizer, location) {
        this.organizer = organizer;
        this.location = location;
        this.priceForTheCamp = {
            "child": 150, "student": 300, "collegian": 500
        }
        this.listOfParticipants = [];
    }

    registerParticipant(name, condition, money) {
        if (!this.priceForTheCamp[condition]) {
            throw new Error('Unsuccessful registration at the camp.')
        }

        if (this.listOfParticipants.some(p => p.name == name)) {
            return `The ${name} is already registered at the camp.`
        }

        if (money < this.priceForTheCamp[condition]) {
            return `The money is not enough to pay the stay at the camp.`
        }

        this.listOfParticipants.push({ name, condition, power: 100, wins: 0 });
        return `The ${name} was successfully registered.`
    }

    unregisterParticipant(name) {
        if (!this.listOfParticipants.some(p => p.name == name)) {
            throw new Error(`The ${name} is not registered in the camp.`);
        }

        this.listOfParticipants.filter(p => p.name != name);
        return `The ${name} removed successfully.`
    }

    timeToPlay(typeOfGame, participant1, participant2) {
        if (typeOfGame == 'Battleship') {
            if (!this.listOfParticipants.some(p => p.name == participant1)) {
                return `Invalid entered name/s.`
            }
            let obj1 = this.listOfParticipants.find(p => p.name == participant1);
            obj1.power += 20;
            return `The ${participant1} successfully completed the game ${typeOfGame}.`
        } else {
            if (!this.listOfParticipants.some(p => p.name == participant1)
                || !this.listOfParticipants.some(p => p.name == participant2)) {
                return `Invalid entered name/s.`
            }

            let obj1 = this.listOfParticipants.find(p => p.name == participant1);
            let obj2 = this.listOfParticipants.find(p => p.name == participant2);

            if (obj1.condition !== obj2.condition) {
                throw new Error(`Choose players with equal condition.`);
            }

            if (obj1.power > obj2.power) {
                obj1.wins++;
                return `The ${obj1.name} is winner in the game ${typeOfGame}.`
            } else if (obj1.power < obj2.power) {
                obj2.wins++;
                return `The ${obj2.name} is winner in the game ${typeOfGame}.`
            } else {
                return `There is no winner.`;
            }
        }
    }

    toString() {
        let result = [];

        result.push(`${this.organizer} will take ${this.listOfParticipants.length} participants on camping to ${this.location}`);
        let sorted = this.listOfParticipants.sort((a,b)=>(b.wins-a.wins));
        sorted.forEach(element => {
            result.push(`${element.name} - ${element.condition} - ${element.power} - ${element.wins}`);
        });

        return result.join('\n');
    }
}

let camp = new SummerCamp('Jane Austen', 'Pancharevo Sofia 1137, Bulgaria');
camp.registerParticipant('Petar Petarson', 'student', 300)
camp.registerParticipant('Sara Dickinson', 'child', 200)
camp.unregisterParticipant('Sara Dickinson')
camp.unregisterParticipant('John Petarson')



