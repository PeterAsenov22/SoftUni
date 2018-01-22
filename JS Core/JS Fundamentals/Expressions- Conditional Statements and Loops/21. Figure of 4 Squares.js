function squareFigures(n) {
    if(n==2){
        return '+++';
    }
    else{
        let result = `+${'-'.repeat(n-2)}+${'-'.repeat(n-2)}+\n`;

        for (let i = 0; i < Math.floor((n-3)/2); i++) {
            result += `|${' '.repeat(n-2)}|${' '.repeat(n-2)}|\n`;
        }

        result += `+${'-'.repeat(n-2)}+${'-'.repeat(n-2)}+\n`;

        for (let i = 0; i < Math.floor((n-3)/2); i++) {
            result += `|${' '.repeat(n-2)}|${' '.repeat(n-2)}|\n`;
        }

        result += `+${'-'.repeat(n-2)}+${'-'.repeat(n-2)}+`;

        return result;
    }
}
