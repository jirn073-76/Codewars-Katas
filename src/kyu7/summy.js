// JavaScript
function summy(sOI){
   sOI = sOI.split(' ').map(Number);
   return sOI.reduce((a, b) => a+b, 0);
}
