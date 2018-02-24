function algorithm(num1,num2) {
    for (let i = 1; i <= num1; i++) {
        if(num1%i == 0) {
            let divisor = num1 / i;
            if (num2%divisor == 0) {
                return divisor;
            }
        }
    }
}
