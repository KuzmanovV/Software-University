let { assert } = require('chai');

const numberOperations = {
   powNumber: function (num) {
      return num * num;
   },
   numberChecker: function (input) {
      input = Number(input);

      if (isNaN(input)) {
         throw new Error('The input is not a number!');
      }

      if (input < 100) {
         return 'The number is lower than 100!';
      } else {
         return 'The number is greater or equal to 100!';
      }
   },
   sumArrays: function (array1, array2) {

      const longerArr = array1.length > array2.length ? array1 : array2;
      const rounds = array1.length < array2.length ? array1.length : array2.length;

      const resultArr = [];

      for (let i = 0; i < rounds; i++) {
         resultArr.push(array1[i] + array2[i]);
      }

      resultArr.push(...longerArr.slice(rounds));

      return resultArr
   }
};

describe("numberOperations …", () => {
   describe("powNumber …", () => {
      it("returns pow …", () => {
         assert.equal(numberOperations.powNumber(2), 4)
      });
   });
   describe("numberChecker …", () => {
      it("Should throw if not a number …", () => {
         assert.throw(() => numberOperations.numberChecker('string'));
         assert.throw(() => numberOperations.numberChecker({}));
      });
      it("Should return message if below 100", () => {
         assert.equal(numberOperations.numberChecker('99'),'The number is lower than 100!' );
      });
      it("Should return message if 100", () => {
         assert.equal(numberOperations.numberChecker('100'),'The number is greater or equal to 100!' );
         assert.equal(numberOperations.numberChecker('101'),'The number is greater or equal to 100!' );
      });
   });
   describe("sumArrays(array1, array2) …", () => {
      it("Should return summed array from 2 equal length arrays", () => {
         assert.deepEqual(numberOperations.sumArrays([1,1,1], [1,2,3]), [2,3,4]);
      });
      it("Should return summed array from not equal length arrays", () => {
         assert.deepEqual(numberOperations.sumArrays([1,1,1], [1,2,3,4]), [2,3,4,4]);
      });
   });
});
