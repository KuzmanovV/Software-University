function jf(inpArr) {
  let storage = {};
  let output = [];
    inpArr.forEach(e => {
      let [juice, qty] = e.split(' => ');

      if (!storage[juice]) {
        storage[juice] = 0;
      }
      storage[juice]+=Number(qty);

      if (storage[juice]/1000>=1) {
        if (!output[juice]) {
          output[juice] = 0;
        }
        
        let newBottles = Math.floor(storage[juice]/1000);
        output[juice]+= newBottles;
        storage[juice]=storage[juice]-newBottles*1000;
      }
  });  

  for (const juice in output) {
    console.log(`${juice} => ${output[juice]}`);
  }
}

jf(['Kiwi => 234',
'Pear => 2345',
'Watermelon => 3456',
'Kiwi => 4567',
'Pear => 5678',
'Watermelon => 6789'])