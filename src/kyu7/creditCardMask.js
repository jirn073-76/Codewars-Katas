// JavaScript
function maskify(cc) {
    var ccarray = cc.split('');
    for (var i = 0; i < ccarray.length - 4; i++){ccarray[i] = "#";}
    cc = ccarray.join('');
    return cc; 
}
