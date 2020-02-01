// JavaScript
function weatherInfo (temp) {
  convert = temp => ((temp - 32) * (5/9));
  var c = convert(temp)
  if (c <= 0){return (c + " is freezing temperature");}
  else{return (c + " is above freezing temperature");}
  return temperature;
}
