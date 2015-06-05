/*
 Problem 2. Reverse number

 Write a function that reverses the digits of given decimal number.
 */
console.log(' Problem 2. Reverse number');

function reverseNumber(number) {

    var temp = number;

    if (number < 0) {
        number = Math.abs(number);
    }

    var toString = number.toString();
    var reversing = toString.split("").reverse().join("");
    var result = Number(reversing);

    if (temp < 0) {
        return ('-' + result);
    }
    else {
        return result;
    }
}

var number = [256, 123.45];

for (var i = 0, len = number.length; i < len; i += 1) {
    console.log('number:' + number[i] + ' reversed number: ' + reverseNumber(number[i]));
}

console.log('\n');
