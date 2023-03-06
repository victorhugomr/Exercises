// Reading the input value
let input = require('fs').readFileSync('/dev/stdin', 'utf8');
let R = parseFloat(input);

// Calculating the volume
const PI = 3.14159;
let VOLUME = (4/3) * PI * Math.pow(R, 3);

// Printing the result
console.log("VOLUME = " + VOLUME.toFixed(3));
