// JavaScript

function expandedForm(num) {
  var solution = "";
  num = num.toString().split('').map(Number);
  for (var i = 0; i < num.length; i++){num[i] *= Math.pow(10, (num.length-i-1));}
  num = (num.filter(n => n !== 0));
  for (var i = 0; i < num.length; i++){if(i < 1){solution += num[i]}else{solution += " + " + num[i]}}
  return solution;
}
