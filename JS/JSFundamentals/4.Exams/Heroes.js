function solve(input) {
    let n = Number(input.shift())
    let heroes = {}
    let commands = {
        CastSpell: (heroes, [name, mpCost, spellName]) => {
            if (mpCost <= heroes[name].mp) {
                heroes[name].mp -= Number(mpCost)
                console.log(`${name} has successfully cast ${spellName} and now has ${heroes[name].mp} MP!`);
            } else {
                console.log(`${name} does not have 
                enough MP to cast ${spellName}!`);
            }
        },
        TakeDamage: (heroes, [name, damage, attacker]) => {
            let hero=heroes[name]
            hero.hp-=damage
            if (hero.hp>0) {
                console.log();
            }
         },
        Recharge: (heroes, [name, mpAmt]) => {
            let initialMP = heroes[name].mp
            heroes[name].mp = Math.min(heroes[name].mp + Number(mpAmt), 200)
            console.log(`${name} recharged for ${heroes[name].mp - initialMP} MP!`);
        },
        Heal: (heroes, [name, hpAmt]) => {
            let hero = heroes[name]
            let initialHP = hero.hp
            hero.hp = Math.min(hero.mp + Number(hpAmt), 100)
            console.log(`${name} healed for ${hero.hp - initialHP} HP!`);
        }
    }

    for (let i = 0; i < n; i++) {
        let [name, hp, mp] = input.shift().split(' ')
        heroes[name] = {
            hp: Number(hp),
            mp: Number(mp)
        }
    }

    while (input[0] !== 'End') {
        let [command, ...args] = input.shift().split(' - ')
        commands[command](heroes, args)
    }
}


solve(['2',
    'Solmyr 85 120',
    'Kyrre 99 50',
    'Heal - Solmyr - 10',
    'Recharge - Solmyr - 50',
    'TakeDamage - Kyrre - 66 - Orc',
    'CastSpell - Kyrre - 15 - ViewEarth',
    'End']);
console.log('----------------');
solve(['4',
    'Adela 90 150',
    'SirMullich 70 40',
    'Ivor 1 111',
    'Tyris 94 61',
    'Heal - SirMullich - 50',
    'Recharge - Adela - 100',
    'CastSpell - Tyris - 1000 - Fireball',
    'TakeDamage - Tyris - 99 - Fireball',
    'TakeDamage - Ivor - 3 - Mosquito',
    'End']);