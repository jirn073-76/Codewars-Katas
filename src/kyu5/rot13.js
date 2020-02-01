// JavaScript
// I am not proud of this solution.

function rot13(message){
  var alph = 'abcdefghijklmnopqrstuvwxyzabcdefghijklm'.split('');
  var alphUP = alph.map(el=>el.toUpperCase());
  var messagearr = message.split('');
  var indexesUP = [];
  for (var i = 0; i < messagearr.length; i++){
  if(alph.includes(messagearr[i]) || alphUP.includes(messagearr[i])){
    if(alphUP.includes(messagearr[i])){indexesUP.push(i);}
    var index = alph.findIndex(el=>el===messagearr[i].toLowerCase());
    messagearr[i] = alph[index + 13];
    }
  }
  for(var i = 0; i < indexesUP.length; i++){messagearr[indexesUP[i]] = messagearr[indexesUP[i]].toUpperCase();}
  return messagearr.join('');
}
