function solve() {
    return function (params) {
        var sum=0;
        if(!(params.length)){
            return null;
        }
        if(!(params)){
            throw new Error();
        }

        params.forEach(function (element) {
            element=+element;
            if (isNaN(element)) {
                throw  new Error();
            }
                sum += element;
        });
        return sum;
    }
}