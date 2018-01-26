function processOddNumbers(arr) {
    let result = [];
    arr.filter((e,i) => i%2!=0).map(e => result.unshift(e*2));

    console.log(result.join(' '));
}
