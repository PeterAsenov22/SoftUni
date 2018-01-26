function negativePositiveNumbers(arr) {
    let newArray = new Array();

    for (let i = 0; i < arr.length; i++) {
        if(arr[i]<0){
            newArray.unshift(arr[i]);
        }
        else{
            newArray.push(arr[i]);
        }
    }

    console.log(newArray.join('\n'));
}
