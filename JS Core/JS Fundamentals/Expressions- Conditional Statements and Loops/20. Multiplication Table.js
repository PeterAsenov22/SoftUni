function multiplicationTable(n) {
    let result = '<table border="1">\n';
    let firstLine = '<tr><th>x</th>';
    for (let i = 1; i <=n; i++) {
         firstLine += `<th>${i}</th>`;
    }
    firstLine += '</tr>\n';
    result += firstLine;

    let middleLines = '';
    for (let i = 1; i <=n; i++) {
        middleLines +=`<tr><th>${i}</th>`;

        for (let j = 1; j <= n; j++) {
            middleLines += `<td>${j*i}</td>`;
        }

        middleLines += '</tr>\n';
    }

    result+=middleLines;
    result+='</table>'

    return result;
}
