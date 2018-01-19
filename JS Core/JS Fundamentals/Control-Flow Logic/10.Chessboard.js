function getChessBoard(n) {
    let htmlString = '<div class="chessboard">\n';

    for(let row = 0; row < n; row++){
        htmlString += '  <div>\n'
        let startColor = row%2==0 ? 'black' : 'white';

        for(let col = 0; col < n; col++){
            let colorString = '';
            if((startColor == 'black' && col%2==0) || (startColor == 'white' && col%2!=0)) {
                colorString = 'black';
            }
            else {
                colorString = 'white';
            }

             htmlString += `    <span class="${colorString}"></span>\n`;
        }

        htmlString += '  </div>\n'
    }

    htmlString += '</div>'
    return htmlString;
}
