var input = require('fs').readFileSync('/dev/stdin', 'utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());

for (var i = 0; i < n; i++) {
  var text = lines.shift().trim(); // remove leading and trailing spaces
  var words = text.split(' ');
  var message = '';

  for (var j = 0; j < words.length; j++) {
    if (words[j].length > 0) {
      message += words[j][0];
    }
  }

  console.log(message);
}
