function fromJsonToHtmlTable(jsonString) {
    function htmlEscape(text) {
        let map = { '"': '&quot;', '&': '&amp;',
            "'": '&#39;', '<': '&lt;', '>': '&gt;' };

        return text.toString().replace(/[\"&'<>]/g, ch => map[ch]);
    }

    let objectsArray = JSON.parse(jsonString);

    let keys = Object.keys(objectsArray[0]);
    let result = '<table>\n';
    result += '  <tr>';
    for (let key of keys) {
        result += `<th>${htmlEscape(key)}</th>`;
    }

    result += '</tr>\n';

    for (let object of objectsArray) {
        result += '  <tr>';

        for (let key of keys) {
            result += `<td>${htmlEscape(object[key])}</td>`;
        }
        result += '</tr>\n';
    }

    result += '</table>';
    return result;
}
