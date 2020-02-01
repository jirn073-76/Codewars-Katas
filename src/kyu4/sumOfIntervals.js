// JavaScript
function sumIntervals(intervals){

  var checkedNo = [];
  var sum = 0;
    
  intervals.forEach(iv => {
      for(var i = iv[0]; i < iv[1]; i++) { 
          if(!checkedNo.includes(i)) {
            sum++;
            checkedNo.push(i);
        }
      }
  });
  
  return sum;
}
