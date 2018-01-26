function cookingByNumbers(input){

    function chop(number) {
        return number/2;
    }
    
    function dice(number) {
        return Math.sqrt(number);
    }
    
    function spice(number) {
        return number + 1;
    }
    
    function bake(number) {
        return number*3;
    }
    
    function fillet(number) {
        return 0.8 * number;
    }

    function operate(number, func) {
        switch (func){
            case 'chop': return chop(number);
            case 'spice': return spice(number);
            case 'bake': return bake(number);
            case 'fillet': return fillet(number);
            case 'dice': return dice(number);
        }
    }

    let startNum = input[0];

    for (let i = 1; i < input.length; i++) {
        startNum = operate(startNum, input[i]);
        console.log(startNum);
    }
}
