function search(input, cmd) {
    let [take, del, find] = cmd
    let output = []

    let sliced = input.slice(0, take).splice(del).filter(x => x === find)
    return `Number ${find} occurs ${sliced.length} times.`
}

console.log(search([5, 2, 3, 3, 1, 6],
    [5, 2, 3]));