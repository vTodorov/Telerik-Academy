/*
 Problem 3. Deep copy

 Write a function that makes a deep copy of an object.
 The function should work for both primitive and reference types.
 */
console.log('Problem 3. Deep copy');

function deepCopy(original){
    return JSON.parse(JSON.stringify(original));
}

var pesho={
    name:'pesho',
    age:15,
}

var copyOfPesho=deepCopy(pesho);
console.log('object:');
console.log(pesho);
console.log('copy of object:')
console.log(copyOfPesho);
console.log('\n');