let {isOddOrEven} = require('./module');
let {assert} = require('chai');

it('Test invalide input', ()=>{
    assert.equal(undefined, isOddOrEven(1));
    assert.equal(undefined, isOddOrEven({}));
    assert.equal(undefined, isOddOrEven({}));
});

it('Test even output', ()=>{
    assert.equal('even', isOddOrEven('even'));
});

it('Test odd output', ()=>{
    assert.equal('odd', isOddOrEven('odd'));
})