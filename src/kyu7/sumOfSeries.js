// JavaScript
function GetSum( a,b ){
    var arr = [];
    if (b < a){
    var z = b;
    b = a;
    a = z;
    }
    for (var i = a; i < b+1; i++){arr.push(i);}
    return arr.reduce((a,b) => a+b, 0);
    if (a === b){return a;}
}
