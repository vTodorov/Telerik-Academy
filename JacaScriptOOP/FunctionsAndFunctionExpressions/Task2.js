function solve() {
    return function (start, end) {

        if (arguments.length < 2) {
            throw new Error();
        }
        if (isNaN(+start)) {
            throw new Error();
        }
        if (isNaN(+end)) {
            throw new Error();
        }

        var divisor,
            maxDivisor,
            primesArr = [],
            isPrime;

        start = +start;
        end = +end;
        for (var i = start; i <= end; i += 1) {
            maxDivisor = Math.sqrt(i);
            isPrime = true;
            for (divisor = 2; divisor <= maxDivisor; divisor += 1) {

                if (!(i % divisor)) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime && i > 1) {
                primesArr.push(i);
            }
        }
        return primesArr;
    }
}