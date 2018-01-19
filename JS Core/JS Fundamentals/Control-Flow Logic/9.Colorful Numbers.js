function colorfulNumbers(n) {
    let htmlString = '<ul>\n';
    for(let i=1; i<=n; i++){
        let colorString = i%2==0 ? 'blue' : 'green';
        htmlString += `  <li><span style='color:${colorString}'>${i}</span></li>\n`;
    }

    htmlString += '</ul>';
    return htmlString;
}
