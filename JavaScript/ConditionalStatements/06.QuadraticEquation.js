/*
 Problem 6. Quadratic equation

 Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 Calculates and prints its real roots.
 */

console.log('Problem 6. Quadratic equation');

var a =[2,-1,-0.5,5]; // <== replace your numbers here
var b =[5,3,4,2]; // <== replace your numbers here
var c = [-3,0,-8,8]; // <== replace your numbers here

for (var i = 0; len= a.length, i < len ; i++) {

var d = Math.pow(b[i], 2) - (4 * a[i] * c[i]);

    if (d > 0){
        var x1 = ((-b[i]) - Math.sqrt(d)) / (2 * a[i]);
        var x2 = ((-b[i]) + Math.sqrt(d)) / (2 * a[i]);
        console.log('a='+a[i]+' b='+b[i]+' c='+c[i]+' Result: x1='+x1+' x2='+ x2);
    }
    else if (d == 0){
        var x = (-b[i]) / (2 * a[i]);
        console.log('a='+a[i]+' b='+b[i]+' c='+c[i]+" Result: x1 = x2 = " + x);
    }
    else{
        console.log('a='+a[i]+' b='+b[i]+' c='+c[i]+" Result: no real roots");
    }
}
console.log('\n\n');