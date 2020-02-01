// JavaScript
function fizzify(i) {
  if (i % 15 == 0)
    return 'FizzBuzz';
  else if (i % 5 == 0)
    return 'Buzz';
  else if (i % 3 == 0)
    return 'Fizz';
  else
    return i;
}

// Return an array
function fizzbuzz(n) {
  var res = [];
  for (var i = 1; i <= n; ++i) res.push(fizzify(i));
  return res;
}
