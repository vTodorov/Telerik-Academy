/*
 Problem 2. Multiplication Sign

 Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 Use a sequence of if operators.
 */
console.log('Problem 2. Multiplication Sign');

var a =[5,-2,-2,0,-1]; // <== replace your numbers here
var b =[2,-2,4,-2.5,-0.5]; // <== replace your numbers here
var c =[2,1,3,4,-5.1]; // <== replace your numbers here

for (var i = 0; i < a.length ; i++) {

if (a[i]*b[i]*c[i]>0) {
    console.log('a='+a[i]+' b='+b[i]+' c='+c[i]+" result: +");
}
    else if(a[i]*b[i]*c[i]<0){
    console.log('a='+a[i]+' b='+b[i]+' c='+c[i]+" result: -");
}
    else{
    console.log('a='+a[i]+' b='+b[i]+' c='+c[i]+"result: 0");

}
}
console.log('\n\n');