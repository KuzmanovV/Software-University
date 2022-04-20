//let {PaymentPackage} = require('module');
let{assert} = require('chai');

//let instance = undefined;
//beforeEach(()=>{
    //instance = new PaymentPackage('HR Services', 1500);
//})

it('cons', ()=>{
    instance = new PaymentPackage('HR Services', 1500);
    assert.equal(instance._name, 'HR Services');
//assert.equal(instance._value, 1500);
//assert.equal(instance._VAT, 20);
//assert.equal(instance._active, true);
})

it('name', ()=>{
    instance = new PaymentPackage('HR Services', 1500);
    assert.equal(instance.name, 'HR Services')
})