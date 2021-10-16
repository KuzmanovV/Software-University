function generateReport() {
    let allHeads = Array.from(document.querySelectorAll('input'));
    let checkedHeadersIndexes = [];
    let result = [];

    for (let i = 0; i < 7; i++) {
        if (allHeads[i].checked) {
            checkedHeadersIndexes.push(i);
        }
    }

    let rowElements = Array.from(document.querySelectorAll('tr'));

    for (let i = 1; i < rowElements.length; i++) {
        const row = rowElements.children[i];
        let obj = {};

        for (let j = 0; j < row.length; j++) {

            if (checkedHeadersIndexes.includes(j)) {
                obj[allHeads[j].name] = row[j].textContent;
            }
        }
        
        result.push(obj);
    }

    console.log(result);
}
