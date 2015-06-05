/*
 Problem 4. Lexicographically smallest

 Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.
 */
console.log(' Problem 4. Lexicographically smallest');

/*
var smallest='zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz',
    largest='';

for (prop in document){

 if(prop>largest){
  largest=prop;
 }
 if(prop<smallest){
  smallest=prop;
 }
}
console.log('The smallest property in document is: '+smallest);
console.log('The largest property in document is: '+largest);
*/

function smallestAndLargestProp(target){
 var smallest='zzzzzzzzzzzzzzzzzzzzzzzzzzzzz',
     largest='';

 for (prop in target){

  if(prop>largest){
   largest=prop;
  }
  if(prop<smallest){
   smallest=prop;
  }
 }
 return 'The lexicographically smallest element in '+target+' is: '+smallest+' and the larges is: '+ largest;
}

console.log(smallestAndLargestProp(document));

console.log(smallestAndLargestProp(window));

console.log((smallestAndLargestProp(navigator)));