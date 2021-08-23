function hi(input) {
    let output = [];

    for (const iterator of input) {
        let[name, level, items] = iterator.split(' / ');
        level = Number(level);
        items = items ? items.split(', ') : [];
        output.push({name, level, items});
    }

    return JSON.stringify(output);
}

console.log(hi(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara']
));