function extractText(text) {
    let array = [];
    let open = text.indexOf('(');
    let close = text.indexOf(')',open);

    while (open >-1 && close > -1){
        let string = text.substring(open+1,close);
        array.push(string);

        open = text.indexOf('(',close);
        close = text.indexOf(')',open);
    }

    console.log(array.join(', '));
}
