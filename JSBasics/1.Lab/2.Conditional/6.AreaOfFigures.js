function area(input){
if(input[0]=="square")
console.log((Math.pow(Number(input[1]),2)).toFixed(3))
else if(input[0]=="rectangle")
console.log((Number(input[1])*Number(input[2])).toFixed(3))
else if(input[0]=="circle")
console.log((Math.PI*Math.pow(Number(input[1]),2)).toFixed(3))
else
console.log((Number(input[1])*Number(input[2])/2).toFixed(3))
}

area(["square", "3", "2"])