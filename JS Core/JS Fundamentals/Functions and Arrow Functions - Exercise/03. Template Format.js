function templateFormat(input) {
    let result = '<?xml version="1.0" encoding="UTF-8"?>\n';
    result += '<quiz>\n';

    for (let i = 0; i < input.length; i+=2) {
        let question = input[i];
        let answer = input[i+1];

        result +='  <question>\n';
        result +=`    ${question}\n`;
        result +='  </question>\n';
        result +='  <answer>\n';
        result +=`    ${answer}\n`;
        result +='  </answer>\n';
    }

    result += '</quiz>';

    return result;
}
