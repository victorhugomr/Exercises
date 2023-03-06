var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

let x = parseInt(lines[0]);
let y = parseInt(lines[1]);

if (x > y) {
  let temp = x;
  x = y;
  y = temp;
}
let sum = 0;

for (let i = x; i <= y; i++) {
  if (i % 13 !== 0) {
    sum += i;
  }
}
console.log(sum);
