function vc(x1, y1, x2, y2) {
    checkingTo0(x1, y1);
    checkingTo0(x2, y2);

    if (Number.isInteger(Math.sqrt(Math.abs(x1 - x2) ** 2 + Math.abs(y1 - y2) ** 2))) {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else {
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`)
    }

    function checkingTo0(x, y) {
        if (Number.isInteger(Math.sqrt(x ** 2 + y ** 2))) {
            console.log(`{${x}, ${y}} to {0, 0} is valid`);
        } else {
            console.log(`{${x}, ${y}} to {0, 0} is invalid`);
        }

    }

}

vc(3, 0, 0, 4)
vc(2, 1, 1, 1)