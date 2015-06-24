/*
 Problem 4. Sort 3 numbers

 Sort 3 real values in descending order.
 Use nested if statements.
 */

console.log('Problem 4. Sort 3 numbers');

var a=[5,-2,-2,0,-1.1,10,1] // <== replace your numbers here
var b=[1,-2,4,-2.5,-0.5,20,1]; // <== replace your numbers here
var c=[2,1,3,5,-0.1,30,1]; // <== replace your numbers here

var result='';

for (var i = 0;i  < a.length ;i ++) {
if (a[i] >= b[i] && a[i] >= c[i])
{
    if (b[i] >= c[i])
    {
        console.log('a='+a[i]+' b='+b[i]+' c= '+c[i]+' Sorted numbers: '+(a[i] +' '+ b[i] +' '+c[i]));
    }
    else if (c[i] >= b[i])
    {
        console.log('a='+a[i]+' b='+b[i]+' c= '+c[i]+' Sorted numbers: '+(a[i] +' '+ c[i] +' '+b[i]));
    }
}
else if (b[i] >= a[i] && b[i] >= c[i])
{
    if (a[i] >= c[i])
    {
        console.log('a='+a[i]+' b='+b[i]+' c= '+c[i]+' Sorted numbers: '+(b[i] +' '+ a[i] +' '+c[i]));
    }
    else if (c[i] >= a[i])
    {
        console.log('a='+a[i]+' b='+b[i]+' c= '+c[i]+' Sorted numbers: '+(b[i] +' '+ c[i] +' '+a[i]));
    }
}
else if (c[i] >= a[i] && c[i] >= b[i])
{
    if (a[i] >= b[i])
    {

        console.log('a='+a[i]+' b='+b[i]+' c= '+c[i]+' Sorted numbers: '+(c[i] +' '+ a[i] +' '+b[i]));
    }
    else if (b[i] >= a[i])
    {
        console.log('a='+a[i]+' b='+b[i]+' c= '+c[i]+' Sorted numbers: '+(c[i] +' '+ b[i] +' '+a[i]));
    }

}
}
console.log('\n\n');