const { assert } = require("chai");
let {lookupChar} = require('./module');

it('Test if input is not a string', ()=>{
    assert.equal(undefined, lookupChar(1, 1));
    assert.equal(undefined, lookupChar({}, 1));
    assert.equal(undefined, lookupChar([], 1));
    assert.equal(undefined, lookupChar('test', 1.1));
    assert.equal(undefined, lookupChar('test', ''));
    assert.equal(undefined, lookupChar('test', {}));
    assert.equal(undefined, lookupChar('test', []));
})

it('Should receive correct value of index', ()=>{
    assert.equal('Incorrect index', lookupChar('test', -1));
    assert.equal('Incorrect index', lookupChar('test', 4));
    assert.equal('Incorrect index', lookupChar('test', 5));
})

it('Should return character', ()=>{
    assert.equal('e', lookupChar('test', 1));
})
