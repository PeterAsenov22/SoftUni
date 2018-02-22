function solve(arr) {

    let process = (function () {
        let text = '';
        return function (command,value) {
            switch (command) {
                case 'print':
                    console.log(text);
                case 'append':
                    text += value;
                    break;
                case 'removeStart':
                    text = text.slice(value);
                    break;
                case 'removeEnd':
                    text = text.slice(0, text.length - Number(value));
                    break;
            }
        }
    })();

    for (let line of arr) {
        let cmdArgs = line.split(' ');
        process(cmdArgs[0],cmdArgs[1]);
    }
}
