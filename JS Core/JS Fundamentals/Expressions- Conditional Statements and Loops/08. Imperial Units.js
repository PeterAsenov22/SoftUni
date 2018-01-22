function imperialUnits(number) {
    let inches = number%12;
    let feet = (number - inches)/12;

    return `${feet}'-${inches}"`;
}
