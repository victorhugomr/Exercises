var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

// Converte a primeira linha para um número inteiro
const n = Number(lines[0]);

// Inicializa os contadores
let inInterval = 0;
let outInterval = 0;

// Itera n vezes para ler os números X
for (let i = 1; i <= n; i++) {
  const x = Number(lines[i]);

  // Verifica se o número está no intervalo [10, 20]
  if (x >= 10 && x <= 20) {
    inInterval++;
  } else {
    outInterval++;
  }
}

// Imprime os resultados
console.log(`${inInterval} in`);
console.log(`${outInterval} out`);
