let add = (function () {
    let sum = 0;

    return function increase(num) {
        sum += num;

        increase.toString = function () {
            return sum;
        };

        return increase;
    };
})();
