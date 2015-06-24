/*
 Problem 5. Appearance count

 Write a function that counts how many times given number appears in given array.
 Write a test function to check if the function is working correctly.
 */

console.log('Problem 5. Appearance count');

var arr = [2, 2, 2, 2],
    number = 2;


function numberCounter(arr, number) {
    console.log('array: ' + arr);
    console.log('number: ' + number)
    var counter = 0;
    for (var i = 0, len = arr.length; i < len; i += 1) {

        if (arr[i] === number) {
            counter++;
        }
    }
    if (!(counter)) {
        return 'Number is not found';
    }
    else if (counter === 1) {
        return ('Number:' + number + ' is found:' + counter + ' time');
    }
    else {
        return ('Number:' + number + ' is found:' + counter + ' times');
    }
}
console.log(numberCounter(arr, number));
console.log('\n');


