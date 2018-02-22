function aggregateSecond(arr) {
    arr = arr.map(e => Number(e));

    function reduce(func) {
        let result = arr[0];

        for (let elem of arr.slice(1)) {
            result = func(result,elem);
        }

        return result;
    }

    let sum = reduce((a,b) => a+b);
    let min = reduce((a,b) => Math.min(a,b));
    let max = reduce((a,b) => Math.max(a,b));
    let product = reduce((a,b) => a*b);
    let join = reduce((a,b) => ''+a+b);

    console.log(`Sum = ${sum}`);
    console.log(`Min = ${min}`);
    console.log(`Max = ${max}`);
    console.log(`Product = ${product}`);
    console.log(`Join = ${join}`);
}
