function extract(arr) {
    let biggestNum = arr[0];
    let sequence = [arr[0]];
    for (let i = 1; i < arr.length; i++) {
        if(arr[i]>=biggestNum){
            biggestNum = arr[i];
            sequence.push(arr[i]);
        }
    }

    console.log(sequence.join('\n'));
}
