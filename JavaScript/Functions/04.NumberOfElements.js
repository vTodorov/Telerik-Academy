/*
 Problem 4. Number of elements

 Write a function to count the number of div elements on the web page
 */

console.log('Problem 4. Number of elements');



function numberOfDivs() {

   var count = document.getElementsByTagName('DIV').length;

    return (count+' divs found');
}

console.log(numberOfDivs());
console.log('\n');