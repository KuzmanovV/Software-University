let {assert, expect} = require('chai');
let {mathEnforcer} = require('./module');

describe('mathEnforcer', ()=>{
    describe('addFive', ()=>{
        it('Should return undefined with a non-number para', ()=>{
            assert.equal(undefined, mathEnforcer.addFive('a'));
            assert.equal(undefined, mathEnforcer.addFive({}));
            assert.equal(undefined, mathEnforcer.addFive([]));
        })

        it('Should calculate', ()=>{
            expect(mathEnforcer.addFive(.111)).to.be.closeTo(5.111, 0.01);
            assert.equal(0, mathEnforcer.addFive(-5));
        })
    })

    describe('subtructTen', ()=>{
        it('Should return undefined with a non-number para', ()=>{
            assert.equal(undefined, mathEnforcer.subtractTen('a'));
            assert.equal(undefined, mathEnforcer.subtractTen([]));
            assert.equal(undefined, mathEnforcer.subtractTen({}));
        })

        it('Should calculate', ()=>{
            assert.equal(-15, mathEnforcer.subtractTen(-5));
            expect(mathEnforcer.subtractTen(.111)).to.be.closeTo(-9.889, 0.01)
        })
    })

    describe('sum', ()=>{
        it('Should return undefined with a non-number paras', ()=>{
            assert.equal(undefined, mathEnforcer.sum('a', 1));
            assert.equal(undefined, mathEnforcer.sum(1, 'a'));
            assert.equal(undefined, mathEnforcer.sum(1, []));
            assert.equal(undefined, mathEnforcer.sum(1, {}));
            assert.equal(undefined, mathEnforcer.sum('1', 'a'));
            assert.equal(undefined, mathEnforcer.sum(1, '1'));
        })

        it('Should calculate', ()=>{
            assert.equal(-15, mathEnforcer.sum(-5, -10));
            assert.closeTo(.22, .01, mathEnforcer.sum(.111, .111));
            expect(mathEnforcer.sum(.111, .111)).to.be.closeTo(.222, 0.01)
        })
    })
})
