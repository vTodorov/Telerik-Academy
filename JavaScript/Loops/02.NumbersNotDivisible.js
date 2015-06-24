/*
 Problem 2. Numbers not divisible

 Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time
 */
console.log('Problem 2. Numbers not divisible');

n=35; // <== replace your numbers here

for(var i =0;i<=n;i+=1){

    if(!(!(i%3)&&(!(i%7)))){

console.log(i);
    }
}
console.log('\n\n');