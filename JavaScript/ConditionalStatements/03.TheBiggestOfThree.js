/*
 Problem 3. The biggest of Three

 Write a script that finds the biggest of three numbers.
 Use nested if statements.
 */

console.log('Problem 3. The biggest of Three');

var a = [5, -2, -2, 0, -0.1]; // <== replace your numbers here
var b = [2, -2, 4, -2.5, -0.5]; // <== replace your numbers here
var c = [2, 1, 3, 5, -1.1]; // <== replace your numbers here
var result;
for (var i = 0; i < a.length; i++) {

    if (a[i] > b[i]) {
        if (a[i] > c[i]) {
            result = a[i];
        }
    }
    if (b[i] > a[i]) {
        if (b[i] > c[i]) {
            result = b[i];
        }
    }
    if (c[i] > a[i]) {
        if (c[i] > b[i]) {
            result = c[i];
        }
    }
    console.log("The biggest number is: " + result);
}
console.log('\n\n');