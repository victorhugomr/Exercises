var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const values = lines[0].split(' ').map(value => parseInt(value));

const arrayValues = [];
arrayValues.push(values[0]);
arrayValues.push(values[1]);
arrayValues.push(values[2]);

const arrayCopy = arrayValues.slice();

arrayCopy.sort((a, b) => a - b);

for (let i = 0; i < arrayCopy.length; i++) {
  console.log(arrayCopy[i]);
}

console.log("");

for (let i = 0; i < arrayValues.length; i++) {
  console.log(arrayValues[i]);
}
