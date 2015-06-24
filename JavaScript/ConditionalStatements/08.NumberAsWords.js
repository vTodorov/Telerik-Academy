/*
 Problem 8. Number as words

 Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.
 */

console.log(' Problem 8. Number as words');

var number = [0,9,10,12,19,25,98,98,273,400,501,617,711,999], // <== replace your numbers here
    currentNumber,
    result = '';


function problemSolver(number){

    function digitToWord(digit) {

        switch (digit) {
            case 0:
                return 'zero';
                break;
            case 1:
                return 'one';
                break;
            case 2:
                return 'two';
                break;
            case 3:
                return 'three';
                break;
            case 4:
                return 'four';
                break;
            case 5:
                return 'five';
                break;
            case 6:
                return ('six');
                break;
            case 7:
                return ('seven');
                break;
            case 8:
                return ('eight');
                break;
            case 9:
                return ('nine');
                break;
            default :
                return ('not a digit ');
                break;
        }
    }

    function lastDigit(lastDigitOfNumber) {
        currentNumber = lastDigitOfNumber % 10;
        return currentNumber;
    }
    function numbersBeforeHundred(number, first) {
        if (!(number % 10)) {
            return first;
        }
        else {
            return (first + ' ' + digitToWord(lastDigit(number)))
        }
    }
    function beforeHundred(number) {
        if (number < 0 || number > 999) {
            console.log('Invalid number');
        }
        else if (number >= 0 && number <= 9) {
            result += digitToWord(number);
        }
        else if (number >= 10 && number <= 15) {

            switch (number) {
                case 10:
                    result += ('ten');
                    break;
                case 11:
                    result += ('eleven');
                    break;
                case 12:
                    result += ('twelve');
                    break;
                case 13:
                    result += ('thirteen');
                    break;
                case 14:
                    result += ('fourteen');
                    break;
                case 15:
                    result += ('fifteen');
                    break;
                default :
                    result += ('not a digit');
                    break;
            }
        }
        else if (number >= 16 && number <= 19) {
            if (number === 18) {
                result += 'eighteen';
            }
            else {

                result += digitToWord(lastDigit(number)) + 'teen';
            }
        }
        else if (number >= 20 && number <= 29) {
            result += 'twenty ' + digitToWord(lastDigit(number));
        }
        else if (number >= 30 && number <= 39) {
            result += numbersBeforeHundred(number, 'thirty');
        }
        else if (number >= 40 && number <= 49) {
            result += numbersBeforeHundred(number, 'forty');
        }
        else if (number >= 50 && number <= 59) {
            result += numbersBeforeHundred(number, 'fifty');
        }
        else if (number >= 60 && number <= 69) {
            result += numbersBeforeHundred(number, 'sixty');
        }
        else if (number >= 70 && number <= 79) {
            result += numbersBeforeHundred(number, 'seventy');
        }
        else if (number >= 80 && number <= 89) {
            result += numbersBeforeHundred(number, 'eighty');
        }
        else if (number >= 90 && number <= 99) {
            result += numbersBeforeHundred(number, 'ninety');
        }
        return result;
    }
    result = '';
    if (number < 100) {
        beforeHundred(number);
    }
    else if (number >= 100 && number <= 999) {
        var firstDigit = (number / 100) | 0;
        var secondDigit = number % 100;

        if(!(secondDigit)){
            result += digitToWord(firstDigit) + " hundred";
        }
        else {
            result += digitToWord(firstDigit) + " hundred and " + beforeHundred(secondDigit);
        }

    }
    return(result);

}

for(var i =0;i<number.length;i+=1){
    console.log(number[i]+ ' as words is: '+ problemSolver(number[i]))
}