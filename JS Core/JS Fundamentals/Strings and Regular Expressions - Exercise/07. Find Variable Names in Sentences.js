function variableNames(text) {
    let pattern = /\b_([a-zA-Z0-9]+)\b/g;

    let match;
    let matches = [];

    while (match = pattern.exec(text)){
        matches.push(match[1]);
    }

    return matches.join(',');
}
