var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var n = parseInt(input);

for (let i = 1; i <= n; i++) {
  let square = i * i;
  let cube = i * i * i;

  console.log(`${i} ${square} ${cube}`);
  console.log(`${i} ${square + 1} ${cube + 1}`);
}
