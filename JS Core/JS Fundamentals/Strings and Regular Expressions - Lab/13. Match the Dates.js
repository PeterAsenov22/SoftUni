function extractDates(inputLines) {
    let pattern = /\b([0-9]{1,2})-([A-Z][a-z]{2})-([0-9]{4})\b/g;
    let dates = [];
    let match;

    for (let line of inputLines) {
        while (match = pattern.exec(line)){
           let date = `${match[0]} (Day: ${match[1]}, Month: ${match[2]}, Year: ${match[3]})`;
           dates.push(date);
        }
    }

    return dates.join('\n');
}
