/*
 ' Problem 6. Larger than neighbours

 Write a function that checks if the element at given position in given
 array of integers is bigger than its two neighbours (when such exist).
 */

console.log('Problem 6. Larger than neighbours');

function largerThanNeighbours(array, position) {

    if (position == 0 || position == array.length - 1 || array.length <= 1) {

        return 'No neighbours'
    }
    else if ((array[position] > array[position - 1]) && (array[position] > array[position + 1])) {

        return ('element:' + array[position] + ' is bigger than his neighbours:' + array[position - 1] + ' and ' + array[position + 1]);
    }
    else {

        return ('element:' + array[position] + ' is not bigger than his neighbours:' + array[position - 1] + ' and ' + array[position + 1]);
    }
}

var array = [1, 2, 4, 5, 3];
var position = 3;

console.log(largerThanNeighbours(array, position));

console.log('\n');