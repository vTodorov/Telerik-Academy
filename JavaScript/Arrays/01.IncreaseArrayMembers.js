/*
 Problem 1. Increase array members

 Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.
 Print the obtained array on the console.
 */
 console.log('Problem 1. Increase array members')
var number=[];

for(var i = 0;i<=20;i+=1){
 var currentValue=i*5;
 number[i]=currentValue;
 console.log('index:'+i+' value:'+currentValue);
}

console.log('\n\n')