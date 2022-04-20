function solve(params) {
    let words = new Map
    
    for (const word of params) {
        let counter = 1
        if (words.has(word)) {
            counter+=words.get(word)
        }
        
        words.set(word,counter)
    }

let sorted = [...words].sort((a,b)=>(b[1]-a[1]))

    for (let [word, number] of sorted) {
        console.log(`${word} -> ${number} times`);
    } 
}

solve(["Here", "is", "the", "first", "sentence", 
"Here", "is", "another", "sentence", "And", "finally", "the", "third", "sentence"]);