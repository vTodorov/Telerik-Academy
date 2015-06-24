/*
 Problem 7. The biggest of five numbers

 Write a script that finds the greatest of given 5 variables.
 Use nested if statements.
 */
console.log('Problem 7. The biggest of five numbers');

var a=[5,-2,-2,0,-3]; // <== replace your numbers here
var b=[2,-22,4,-2.5,-0.5]; // <== replace your numbers here
var c=[2,1,3,0,-1.1]; // <== replace your numbers here
var d=[5,0,2,5,-2]; // <== replace your numbers here
var e=[1,0,0,5,-0.1]; // <== replace your numbers here

for (var i = 0; i < a.length; i++) {

    if (a[i] >= b[i] && a[i] >= c[i] && a >= d[i] && a >= e[i])
    {
        console.log("The biggest number is: " + a[i]);
    }
    else if (b[i] >= c[i] && b[i] >= a[i] && b[i] >= d[i] && b[i] >= e[i])
    {
        console.log("The biggest number is: " + b[i]);
    }
    else if (c[i] >= b[i] && c[i] >= a[i] && c[i] >= d[i] && c[i] >= e[i])
    {
        console.log("The biggest number is: " + c[i]);
    }
    else if (d[i] >= a[i] && d[i] >= b[i] && d[i] >= c[i] && d[i] >= e[i])
    {
        console.log("The biggest number is: " + d[i]);
    }
    else if (e[i] >= a[i] && e[i] >= b[i] && e[i] >= c[i] && e[i] >= d[i])
    {
        console.log("The biggest number is: " + e[i]);
    }
}
console.log('\n\n');