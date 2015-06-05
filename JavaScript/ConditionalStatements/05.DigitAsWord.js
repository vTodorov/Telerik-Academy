/*
 Problem 5. Digit as word

 Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
 Print “not a digit” in case of invalid input.
 Use a switch statement.
 */

console.log('Problem 5. Digit as word');

var input=[2,1,0,5,-0.1,'hi',9,10]; // <== replace your numbers here

for (var i = 0;i  <input.length ;i++) {

    switch (input[i]){
        case 0: console.log(input[i]+' zero'); break;
        case 1: console.log(input[i]+' one'); break;
        case 2: console.log(input[i]+' two'); break;
        case 3: console.log(input[i]+' three'); break;
        case 4: console.log(input[i]+' four'); break;
        case 5: console.log(input[i]+' five'); break;
        case 6: console.log(input[i]+' six'); break;
        case 7: console.log(input[i]+' seven'); break;
        case 8: console.log(input[i]+' eight'); break;
        case 9: console.log(input[i]+' nine'); break;
        default :console.log(input[i]+' not a digit');break;
    }
}
console.log('\n\n');