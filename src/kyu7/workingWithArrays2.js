// JavaScript
function removeNthElement(arr, n) {
  var arrCopy = arr.slice();
  arrCopy.splice(n, 1);
  return arrCopy;
}
