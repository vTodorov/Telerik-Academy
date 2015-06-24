/*
 Problem 3. Min/Max of sequence

 Write a script that finds the max and min number from a sequence of numbers.
 */
console.log('Problem 3. Min/Max of sequence');

var len,
    min=Number.MAX_VALUE,
    max=Number.MIN_VALUE,
    num = [1,2,3,4,5,6]; // <== replace your numbers here

for (var i =1;len=num.length,i<len;i+=1){

    if(num[i]<min){
        min=num[i];
    }
   if(num[i]>max){
       max=num[i];
   }
}
console.log('min: '+min+' max: '+max );
console.log('\n\n');