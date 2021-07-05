function solve(input) {
    let players = {}
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

        Array.from(cardsArr).forEach(card=>{
            let elements = card.split('')
            let type = elements.pop()
            let cardNumber=elements.join('')
            if (isNaN(cardNumber)) {
                
            }
        })
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