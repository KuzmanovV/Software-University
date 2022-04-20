function gladiatorInventory(params) {
    let inventory = params.shift().split(' ')

    for (let i = 0; i < params.length; i++) {
        let command = params[i].split(' ')
        switch (command[0]) {
            case 'Buy':
                if (!inventory.includes(command[1])) {
                    inventory.push(command[1])
                }
                break;
            case 'Trash':
                if (inventory.includes(command[1])) {
                    let index = inventory.indexOf(command[1])
                    inventory.splice(index, 1)
                }
                break;
            case 'Repair':
                if (inventory.includes(command[1])) {
                    inventory = inventory.filter(x => x !== command[1])
                    inventory.push(command[1])
                }
                break;
            case 'Upgrade':
                let targetArr = command[1].split('-')
                if (inventory.includes(targetArr[0])) {
                    inventory.splice(inventory.indexOf(targetArr[0]) + 1, 0, targetArr[0] + ':' + targetArr[1])
                }
                break;

            default:
                break;
        }

    }

    return inventory.join(' ')
}

console.log(gladiatorInventory(['SWORD Shield Spear',
'Trash Bow',
'Repair Shield',
'Upgrade Helmet-V']));