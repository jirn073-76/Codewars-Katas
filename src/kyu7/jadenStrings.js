// JavaScript
String.prototype.toJadenCase = function toJadenCase() {
var sol = [];
for (var i = 0; i < this.split(' ').length; i++){
   var words = this.split(' ');
   var chars = words[i].split('');
   chars[0] = chars[0].toUpperCase();
   chars = chars.join('');
   sol.push(chars);
   var solstr = sol.join(' ');
   }
return solstr;
};
