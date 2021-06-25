function buildingAWall(params) {
    params.sort()

    let concretePerDay = 0
    let loops = 0
    let output = []

    for (let i = array.length; i >= 0; i--) {
        concretePerDay = (30 - params[i] + loops) * params.length * 195
        loops += 30 - params[i]
        output.push(concretePerDay)
        params.pop()
    }

    return output
}

console.log(buildingAWall([21, 25, 28]));