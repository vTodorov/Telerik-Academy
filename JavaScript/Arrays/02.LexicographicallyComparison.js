/*
 Problem 2. Lexicographically comparison

 Write a script that compares two char arrays lexicographically (letter by letter).
 */
console.log('Problem 2. Lexicographically comparison');

var firstArr=[];
var secondArr=[];

for (var i =0;i<26;i+=1){

    firstArr[i]=String.fromCharCode(97+i);
    secondArr[i]=String.fromCharCode(96+26-i);
}
console.log('First Array: '+firstArr);
console.log('Second Array: '+secondArr);

for(var i=0;i<26;i+=1){

    if(firstArr[i]>secondArr[i]){
        console.log(firstArr[i]+' > '+secondArr[i]);
    }
    else if(secondArr[i]>firstArr[i]){
        console.log(firstArr[i]+' < '+secondArr[i]);
    }
    else{
        console.log(firstArr[i]+' = '+secondArr[i]);
    }
}

console.log("\n\n")