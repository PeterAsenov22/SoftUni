function scoreToHtml(jsonString) {
    let scoresInfo = JSON.parse(jsonString);

    function htmlEscape(text) {
        let map = { '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;' };

        return text.replace(/[\"&'<>]/g, ch => map[ch]);
    }

    let result = '<table>\n'
    result += '  <tr><th>name</th><th>score</th></tr>\n'
    for (let scoreInfo of scoresInfo) {
        result += `  <tr><td>${htmlEscape(scoreInfo["name"])}</td><td>${scoreInfo["score"]}</td></tr>\n`;
    }

    result += '</table>';
    return result;
}
