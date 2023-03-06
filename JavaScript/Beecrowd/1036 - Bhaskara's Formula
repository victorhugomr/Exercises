// Reading the input values
let input = require('fs').readFileSync('/dev/stdin', 'utf8');
let lines = input.split('\n');

let nums = input.split(" ");
let A = parseFloat(nums[0]);
let B = parseFloat(nums[1]);
let C = parseFloat(nums[2]);

// Calculating the discriminant
let delta = Math.pow(B, 2) - 4 * A * C;

// Checking if it's possible to calculate the roots
if (A === 0 || delta < 0) {
  console.log("Impossivel calcular");
} else {
  // Calculating the roots
  let R1 = (-B + Math.sqrt(delta)) / (2 * A);
  let R2 = (-B - Math.sqrt(delta)) / (2 * A);

  // Printing the roots
  console.log("R1 = " + R1.toFixed(5));
  console.log("R2 = " + R2.toFixed(5));
}
