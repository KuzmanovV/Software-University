let {assert} = require('chai');
let {MathEnforcer, mathEnforcer} = require('./module');

describe('mathEnforcer', ()=>{
    describe('addFive', ()=>{
        it('Should return undefined with a non-number para', ()=>{
            assert.equal(undefined, mathEnforcer.addFive('a'));

            //additionalv td
        })

        it('Should calculate right the function', ()=>{
            assert.equal(10, mathEnforcer.addFive(5));
        })
    })

    describe('subtructTen', ()=>{
        it('Should return undefined with a non-number para', ()=>{
            assert.equal(undefined, mathEnforcer.addFive('a'));

            //additionalv td
        })

        it('Should calculate right the function', ()=>{
            assert.equal(5, mathEnforcer.addFive(15));
        })
    })

    describe('sum', ()=>{
        it('Should return undefined with a non-number paras', ()=>{
            assert.equal(undefined, mathEnforcer.addFive('a', 1));
            assert.equal(undefined, mathEnforcer.addFive(1, 'a'));

            //additionalv td
        })

        it('Should calculate right the function', ()=>{
            assert.equal(15, mathEnforcer.addFive(5, 10));
        })
    })
})
