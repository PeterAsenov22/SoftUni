function lastKNumbersSeq(n,k) {
    let arr = [1];

    for (let i = 1; i < n; i++) {
        let sum = 0;
        arr.slice(-k).forEach(e => sum+=e);
        arr[i] = sum;
    }

    console.log(arr.join(' '));
}
