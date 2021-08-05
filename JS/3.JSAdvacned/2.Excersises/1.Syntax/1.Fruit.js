function fruits(type, gramms, price) {
    console.log(`I need $${(gramms/1000*price).toFixed(2)} to buy ${(gramms/1000).toFixed(2)} kilograms ${type}.`);
}

fruits('orange', 2500, 1.80)