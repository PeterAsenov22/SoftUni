function aggregate(arr) {
    function aggr(elements, start, func) {
        for (let e of elements) {
            start = func(start, e);
        }

        return start;
    }

    console.log(aggr(arr, 0, (a, b) => a + b));
    console.log(aggr(arr, 0, (a, b) => a + 1 / b));
    console.log(aggr(arr, '', (a, b) => a + b));
}
