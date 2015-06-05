/* Problem 1. Exchange if greater

 Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
 As a result print the values a and b, separated by a space.
 */
console.log('Problem 1. Exchange if greater');

var a=[5,3,5.5]; // <== replace your numbers here
var b=[2,4,4.5]; // <== replace your numbers here

for (var i = 0; i < a.length ; i++) {

if (a[i]<b[i]) {
console.log('a='+a[i]+' b='+b[i]+' result:'+a[i]+' '+b[i]);
}
    else{

    console.log('a='+a[i]+' b='+b[i]+' result:'+b[i]+' '+a[i]);
}
}
console.log('\n\n');
