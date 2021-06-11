function ladybugs(array) {
    let workingArray = array.slice();
    let fieldSize = workingArray.shift();
    let bugsPosition = workingArray.shift().split(' ');
    let finalBugsArray = new Array(fieldSize).fill(0);
  
    for (const position of bugsPosition) {
      let currentBug = Number(position);
      if (currentBug < 0 || currentBug >= fieldSize) {
        continue;
      }
      finalBugsArray[currentBug] = 1;
    }
  
    for (let i = 0; i < workingArray.length; i++) {
      let [ladybugIndex, command, jumpLength] = workingArray[i].split(' ');
  
      ladybugIndex = Number(ladybugIndex);
  
      if (ladybugIndex < 0 || ladybugIndex >= finalBugsArray.length || finalBugsArray[ladybugIndex] !== 1) {
        continue;
      }
  
      // Free Position
      finalBugsArray[ladybugIndex] = 0;
  
      jumpLength = Number(jumpLength);
      
      if (command === 'left') {
        jumpLength = -jumpLength;
      }
  
      ladybugIndex += jumpLength;
      while (ladybugIndex >= 0 && ladybugIndex < finalBugsArray.length) {
        if (finalBugsArray[ladybugIndex] === 0) {
          finalBugsArray[ladybugIndex] = 1;
          break;
        }
        ladybugIndex += jumpLength;
      }
    }
  
    console.log(finalBugsArray.join(' '));
  }

  ladybugs([ 3, '0 1 2',
  '0 right 1',
  '2 right 1' ]
  )