function modifyAverage(number) {

    while(getAverage(number) <= 5){
        number = Number(number.toString() + '9');
    }

    console.log(number);

    function getAverage(num) {
        let numAsString = num.toString();
        let sum = 0;

        for (let obj of numAsString) {
            sum += Number(obj);
        }

        return sum/numAsString.length;
    }
}
