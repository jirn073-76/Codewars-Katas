// JavaScript
var humanYearsCatYearsDogYears = function(humanYears) {
 var catYears = 0;
 var dogYears = 0;
 var humanYearsBak = humanYears;
 if (humanYears >= 1){catYears += 15; dogYears += 15; humanYearsBak -= 1;}
 if (humanYears > 1){catYears += 9; dogYears += 9; humanYearsBak -= 1;}
 for (var i = 0; i < humanYearsBak; i++){catYears += 4; dogYears += 5;}
  return [humanYears,catYears,dogYears];
}
