var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

const sequence = lines[0];
const vowels = ['a', 'e', 'i', 'o', 'u'];
let filteredSequence = '';

// Filtra a sequência para conter apenas vogais
for (let i = 0; i < sequence.length; i++) {
  if (vowels.includes(sequence[i])) {
    filteredSequence += sequence[i];
  }
}

let isFunny = true;

// Verifica se a sequência filtrada tem as mesmas vogais em ordem direta e inversa
for (let i = 0; i < filteredSequence.length / 2; i++) {
  if (filteredSequence[i] !== filteredSequence[filteredSequence.length - i - 1]) {
    isFunny = false;
    break;
  }
}

if (isFunny) {
  console.log('S');
} else {
  console.log('N');
}
