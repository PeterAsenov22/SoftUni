function evenPositionElement(arr) {
    let evenPositionElements  = [];
    for (let i = 0; i < arr.length; i+=2) {
        evenPositionElements.push(arr[i]);
    }

    console.log(evenPositionElements.join(' '));
}
