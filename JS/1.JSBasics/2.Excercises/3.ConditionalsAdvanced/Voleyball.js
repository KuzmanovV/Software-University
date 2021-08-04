function voleyball(input){
    let year = input[0]
    let holydays = Number(input[1])
    let homeWeekends = Number(input[2])

    let result = (48-homeWeekends)*3.0/4+homeWeekends+holydays*2.0/3

    if(year==='leap')
    result*=1.15

    console.log(Math.floor(result))
}

voleyball(["leap",
"5",
"2"])