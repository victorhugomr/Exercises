var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let max = -1;
let pos = -1;

for (let i = 0; i < 100; i++) {
  let num = parseInt(lines[i]);
  
  if (num > max) {
    max = num;
    pos = i+1;
  }
}

console.log(max);
console.log(pos);
