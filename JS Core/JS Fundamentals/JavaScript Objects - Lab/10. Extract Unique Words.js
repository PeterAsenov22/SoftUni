function extractUniqueWords(inputLines) {
    let uniqueWords = new Set();

    for (let line of inputLines) {
        line.split(/\W+/g).filter(e => e!='').map(e => e.toLowerCase()).forEach(e => uniqueWords.add(e));
    }

    return Array.from(uniqueWords).join(', ');
}
