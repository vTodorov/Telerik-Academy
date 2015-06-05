/*
 Problem 3. Occurrences of word

 Write a function that finds all the occurrences of word in a text.
 The search can be case sensitive or case insensitive.
 Use function overloading.
 */
console.log('Problem 3. Occurrences of word');


function occurrencesOfWord(text, wordToFind, lower) {

    switch (arguments.length) {
        case 2:

            var wordArray = text.split(/[\s,]+/),
                matches = 0;

            for (var i = 0, len = wordArray.length; i < len; i += 1) {

                if (wordToFind === wordArray[i]) {
                    matches += 1;
                }
            }
            if (matches === 1) {
                return ('Word: "' + wordToFind + '" is found: ' + matches + ' time');
            }
            else if (matches > 0) {
                return ('Word: "' + wordToFind + '" is found: ' + matches + ' times');
            }
            else {
                return ('Word: "' + wordToFind + '" is not found');
            }

            ;
            break;
        case  3:


            var wordArray = text.split(/[\s,]+/),
                matches = 0,
                wordArrayToLower = [];

            wordToFind = wordToFind.toLowerCase();

            for (var i = 0, len2 = wordArray.length; i < len2; i += 1) {
                wordArrayToLower[i] = wordArray[i].toLowerCase();
            }

            for (var i = 0, len = wordArrayToLower.length; i < len; i += 1) {

                if (wordToFind === wordArrayToLower[i]) {
                    matches += 1;
                }
            }
            if (matches === 1) {
                return ('Word: "' + wordToFind + '" is found: ' + matches + ' time');
            }
            else if (matches > 0) {
                return ('Word: "' + wordToFind + '" is found: ' + matches + ' times');
            }
            else {
                return ('Word: "' + wordToFind + '" is not found');
            }
            ;
            break;
    }
}

var text = 'bla bla . bla BLA bla BLa';
var word = 'bla';
var caseSensitive;

console.log('Text: ' + text);
console.log('Case Sensitive:');
console.log(occurrencesOfWord(text, word));
console.log('No Case Sensitive:');
console.log(occurrencesOfWord(text, word, caseSensitive));
console.log('\n');