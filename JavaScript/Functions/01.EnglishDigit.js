/*
 Problem 1. English digit

 Write a function that returns the last digit of given integer as an English word.
 */

console.log('Problem 1. English digit');

function lastDigitAsWord(number) {
    number = Math.abs(number);
    while (number > 10) {
        number = number % 10;
    }
    return number;
}

var number = [512, 1024, 12309];

for (var i = 0, len = number.length; i < len; i += 1) {
    console.log('number:' + number[i] + ' last digit:' + lastDigitAsWord(number[i]));
}
console.log('\n');