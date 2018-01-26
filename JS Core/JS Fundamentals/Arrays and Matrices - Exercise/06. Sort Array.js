function sortArray(input) {
    let x = input.sort().sort((a, b)=>a.length > b.length);

    console.log(x.join('\n'));
}
