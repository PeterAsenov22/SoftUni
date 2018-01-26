function performMultiplications(text) {

    function multiply(match,num1,num2) {
        return Number(num1) * Number(num2);
    }

    text = text.replace(/(-?\d+)\s*\*\s*(-?\d+(\.\d+)?)/g, multiply);

    return text;
}
