function addOrRemove(arr) {
  let num = 1;
  let newArr = [];

    for (let i = 0; i < arr.length; i++) {
        if(arr[i] == 'add'){
            newArr.push(num);
        }
        else if(arr[i] == 'remove') {
           newArr.pop();
        }

        num++;
    }

    if(newArr.length == 0){
        console.log('Empty');
    }
    else {
        console.log(newArr.join('\n'));
    }
}
