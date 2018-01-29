function secretData(inputLines) {
    let pattern = /\*[A-Z][a-zA-Z]*(?=\s|$)|\+[0-9-]{10}(?=\s|$)|(\!|\_)[A-Za-z0-9]+(?=\s|$)/g;

    function matchToBars(match) {
        return '|'.repeat(match.length);
    }

    for (let line of inputLines) {
        console.log(line.replace(pattern, matchToBars));
    }
}
