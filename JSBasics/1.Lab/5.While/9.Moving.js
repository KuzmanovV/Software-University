function moving(args) {
    let volume = Number(args[0])*Number(args[1])*Number(args[2])

    let index = 3
    let boxes = Number(args[3])
    while (boxes !== 'Done' && index<args.length) {
        volume-=Number(boxes)
       index++
       boxes = args[index]
    }
    
    if(volume<0)
            console.log(`No more free space! You need ${Math.abs(volume)} Cubic meters more.`)
        else
        console.log(`${volume} Cubic meters left.`)
}

moving(["10",
"1",
"2",
"4",
"6",
"Done"])