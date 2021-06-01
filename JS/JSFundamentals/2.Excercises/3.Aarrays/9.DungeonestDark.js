function game(input) {
    let rooms = input[0].split('|')
    let health = 100
    let coins = 0
    let isDead = false
    let lastRoom = 0
    for (let index = 0; index < rooms.length; index++) {
        const element = rooms[index];
        let room = element.split(' ')
        lastRoom++

        if (room[0] === 'chest') {
            console.log(`You found ${room[1]} coins.`);
            coins+= +room[1]
        }
        else if (room[0] === 'potion') {
            let healed = room[1]
            health+= +room[1]
            
            if (health > 100) {
                healed= +room[1]-(health-100)
                health = 100
            }
            else
            healed = room[1]

            console.log(`You healed for ${healed} hp.`);
            console.log(`Current health: ${health} hp.`);
        } else {
            health -= +room[1]
            if (health <= 0) {
                console.log(`You died! Killed by ${room[0]}.`);
                console.log(`Best room: ${lastRoom}`);
                isDead = true
                break
            }
            else
                console.log(`You slayed ${room[0]}.`);
        }
    }

    if (!isDead) {
console.log(`You've made it!`);
console.log(`Coins: ${coins}`);
console.log(`Health: ${health}`);
    }
}

game(["cat 10|potion 30|orc 10|chest 10|snake 25|chest 110"])