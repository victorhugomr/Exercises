var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var n = parseInt(input);

var current = 0;
var next = 1;

for (let i = 1; i <= n; i++) {
  process.stdout.write(`${current}`);

  if (i < n) {
    process.stdout.write(" ");
  }

  let temp = current + next;
  current = next;
  next = temp;
}

process.stdout.write("\n");
