function solve() {
    let input = document.getElementById('input').value;
    let splitted = input.split('.').filter((e) => e != '' && e!=' ');
    let output = document.getElementById('output');

    for (let i = 0; i < splitted.length; i += 3) {
        let parArr = [];
        for (let j = 0; j < 3; j++) {
            if (splitted[i + j]) {
                parArr.push(splitted[i + j])
            }
        }
        output.innerHTML += `<p>${parArr.join('. ')}.</p>`;
    }
}