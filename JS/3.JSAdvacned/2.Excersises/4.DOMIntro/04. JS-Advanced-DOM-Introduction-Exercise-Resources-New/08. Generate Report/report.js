function generateReport() {
    let allHeads = Array.from(document.querySelectorAll('input'));
    //console.log(allHeads[2]);
    let checkedHeadersIndexes = [];
    let result = [];

    for (let i = 0; i < allHeads.length; i++) {
        if (allHeads[i].checked==true) {
            checkedHeadersIndexes.push(i);
        }
    }

    let rowElements = Array.from(document.querySelectorAll('tbody tr'))

    for (let i = 0; i < rowElements.length; i++) {
        const row = rowElements[i];

        let obj = {};
        for (const iterator of checkedHeadersIndexes) {
            obj[allHeads[iterator].name] = row.children[iterator].textContent;
        }

        result.push(obj);
    }

    document.getElementById('output').value = JSON.stringify(result);
    //console.log(JSON.stringify(result));
}
