function solve(arr) {
    const sortArr = arr.sort((a, b) => a - b);
    copiedSortedArr = [...sortArr];
    const result = [];
    for (let index = 0; index < sortArr.length; index++) {
        if (index % 2 == 0) {
            result.push(copiedSortedArr.shift());
        } else {
            result.push(copiedSortedArr.pop());
        }
    }

    return result;
}

console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));