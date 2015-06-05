/*
 Problem 5. Selection sort

 Sorting an array means to arrange its elements in increasing order.
 Write a script to sort an array.
 Use the selection sort algorithm: Find the smallest element, move it at the first position,
  find the smallest from the rest, move it at the second position, etc.
 */

console.log('Problem 5. Selection sort');

var sequence= [5,9,100,1,2,3,4,7,15,26,98],
    min=Number.MAX_VALUE;

console.log('sequence:'+sequence);

function selectionSort (sortMe) {
    var i, j, tmp, tmp2;
    for (i = 0; i < sortMe.length - 1; i++) {
        tmp = i;
        for (j = i + 1; j < sortMe.length; j++) {
            if (sortMe[j] < sortMe[tmp]) {
                tmp = j;
            }
        }
        if (tmp != i) {
            tmp2 = sortMe[tmp];
            sortMe[tmp] = sortMe[i];
            sortMe[i] = tmp2;
        }
    }
    return sortMe;
}
console.log('sorted sequence:'+selectionSort(sequence));

console.log('\n\n')

