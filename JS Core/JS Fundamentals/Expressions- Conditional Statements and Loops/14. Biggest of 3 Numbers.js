function biggestOf3Nums(input) {
    let num1 = input[0];
    let num2 = input[1];
    let num3 = input[2];

    if(num1 > num2 && num1 > num3) {
        return num1;
    }
    else if(num2 > num1 && num2 > num3){
        return num2;
    }
    else {
        return num3;
    }
}
