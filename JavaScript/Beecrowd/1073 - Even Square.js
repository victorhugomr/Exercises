var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// Converte a primeira linha para um número inteiro
const n = parseInt(lines[0]);

// Imprime o quadrado dos valores pares de 1 a N
for (let i = 1; i <= n; i++) {
  if (i % 2 === 0) {
    const square = i * i;
    console.log(`${i}^2 = ${square.toFixed(0)}`);
  }
}
