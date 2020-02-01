// JavaScript
function printerError(s) {
    var str = s;
    var errcount = 0;
    var error = false;
    var correct_str = "abcdefghijklm";
    
    for (var i=0; i < str.length; i++) {
       for (var j=0; j < correct_str.length; j++) {
         if (str[i] !== correct_str[j]) {
           error = true;
         } else {
            error = false;
            break;
         }
       }
       if (error) {
         errcount++;
         error = false;
       }
    }
    
    return errcount + "/" + str.length;   
}
