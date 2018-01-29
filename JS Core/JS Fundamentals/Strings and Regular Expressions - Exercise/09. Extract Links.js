function extractLinks(inputLines) {
    let pattern = /www\.[a-zA-Z0-9-]+(\.[a-z]+)+/g;
    let matchedLinks = [];
    let match;

    for (let line of inputLines) {
        while (match = pattern.exec(line)){
            matchedLinks.push(match[0]);
        }
    }

    return matchedLinks.join('\n');
}
