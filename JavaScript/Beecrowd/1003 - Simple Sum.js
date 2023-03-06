// Reading the input values
let input = require('fs').readFileSync('/dev/stdin', 'utf8');
let lines = input.split('\n');

let A = parseInt(lines.shift());
let B = parseInt(lines.shift());

// Calculating the sum
let SOMA = A + B;

// Printing the result
console.log("SOMA = " + SOMA);