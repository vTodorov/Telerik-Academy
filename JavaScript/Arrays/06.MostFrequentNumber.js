/*
 Problem 6. Most frequent number

 Write a script that finds the most frequent number in an array.
 */

console.log('Problem 6. Most frequent number');

var bestCount,
    match=0,
    counter=0;
	bestCount=0,
    arr = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];


for (var i = 0; i < arr.length; i++) {

    for (var j = i; j < arr.length; j++) {
        if (arr[i] == arr[j]) {
            counter++;
			if(counter>bestCount){
				bestCount=counter;
				match=arr[i];
			}
        }
    }
	counter=0;
}

console.log('Input:'+arr+' result:'+match+'('+bestCount+' times)');

