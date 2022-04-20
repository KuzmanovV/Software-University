let {assert} = require('chai');

const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        } else {
            sum = (num1 + num2).toFixed(2);
            return sum
        }
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input % 2 === 0) {
            return 'The number is even!';
        } else {
            return 'The number is odd!';
        }

    },
    averageSumArray: function (arr) {

        let arraySum = 0;

        for (let i = 0; i < arr.length; i++) {
            arraySum += arr[i]
        }

        return arraySum / arr.length
    }
};

describe("testNumbers …", function() {
    describe("sumNumber", function() {
        it("sums with valid numbers", function() {
            assert.equal(testNumbers.sumNumbers(3,5), 8)
            //ninus, floating, 0
        });
        it("Should return undefined with invalid numbers", function() {
            assert.equal(testNumbers.sumNumbers('',5), undefined)
            //combines
        });
     });
     describe("numberChecker(input)", () =>{
        it("Error if NaN", ()=> {
            assert.throw(()=>testNumbers.numberChecker('a'), Error, 'The input is not a number!');
        });
        it("Message if odd", ()=> {
            assert.equal(testNumbers.numberChecker(3), 'The number is odd!')
        });   
        it("Message if even", ()=> {
            assert.equal(testNumbers.numberChecker(4), 'The number is even!')
        });       
     });
     describe("averageSumArray(arr)", () =>{
        it("h", ()=> {
            assert.equal(testNumbers.averageSumArray([1,2,3]), 2);
        });
        
     });
    });


