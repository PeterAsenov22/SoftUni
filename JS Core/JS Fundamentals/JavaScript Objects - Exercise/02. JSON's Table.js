function jsonTable(inputLines) {
    function htmlEscape(text) {
        let map = { '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;' };

        return text.toString().replace(/[\"&'<>]/g, ch => map[ch]);
    }

    let result = '<table>\n';

    for (let line of inputLines) {
        let obj = JSON.parse(line);
        result += '  <tr>\n';
        result += `     <td>${htmlEscape(obj["name"])}</td>\n`;
        result += `     <td>${htmlEscape(obj["position"])}</td>\n`;
        result += `     <td>${htmlEscape(obj["salary"])}</td>\n`;
        result += '  <tr>\n';
    }

    result += '</table>';
    return result;
}
