function pd(year, month, day) {
    let date = new Date(year,month,day);
    date.setDate(date.getDate()-1);
    return `${date.getFullYear()}-${date.getMonth()}-${date.getDate()}`
}

console.log(pd(2016, 9, 30));
console.log(pd(2016, 10, 1));