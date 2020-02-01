// JavaScript
function spinWords(sentence){
  sentence = sentence.split(' ')
  for(i = 0; i < sentence.length; i++)
  {
    if(sentence[i].length >= 5)
    {
      sentence[i] = sentence[i].split('').reverse().join('');
    }
  }
  return sentence.join(' ');
}
