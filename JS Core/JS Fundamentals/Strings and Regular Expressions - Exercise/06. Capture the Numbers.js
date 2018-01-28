function captureNumbers(inputLines) {
    let pattern = /\d+/g;
    let match;
    let matches = [];
    for (let line of inputLines) {
        while (match = pattern.exec(line)){
            matches.push(match[0]);
        }
    }

    return matches.join(' ');
}
