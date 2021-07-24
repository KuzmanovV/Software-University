function lastKSequence(n, k) {
    let result = [1]
    for (let i = 1; i < n; i++) {
        let threeElementArr = result.slice(-k)
        
        let sum = 0
        for (const element of threeElementArr) {
            sum+=element
        }

        result.push(sum)
    }

    return result.join(' ')
}

console.log(lastKSequence(8, 2));