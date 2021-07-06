function solve(input) {
    let players = {}
    let typeArr = {
        S: 4,
        H: 3,
        D: 2,
        C: 1
    }
    let powerArr = {
        J: 11,
        Q: 12,
        K: 13,
        A: 14
    }

    for (let line of input) {
        [person, hand] = line.split(': ')
        hand = hand.split(', ')

        if (!players.hasOwnProperty(person)) {
            players[person] = []
        }

        players[person].push(...hand)
    }

    Object.keys(players).forEach(key => {
        let cardsArr = new Set(players[key])
        let total = 0
        Array.from(cardsArr).forEach(card => {
            let elements = card.split('')
            let type = elements.pop()
            let power = elements.join('')
            if (isNaN(power)) {
                total += powerArr[power] * typeArr[type]
            } else {
                total += power * typeArr[type]
            }
        })
        
        players[key] = total
        console.log(`${key}: ${players[key]}`)
    })
}

solve([
    'Peter: 2C, 4H, 9H, AS, QS',
    'Tomas: 3H, 10S, JC, KD, 5S, 10S',
    'Andrea: QH, QC, QS, QD',
    'Tomas: 6H, 7S, KC, KD, 5S, 10C',
    'Andrea: QH, QC, JS, JD, JC',
    'Peter: JD, JD, JD, JD, JD, JD'
])