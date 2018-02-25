function solve(input) {
    let cmdProcessor = (function () {
        let store = {};
        
        function create(args) {
            if(args.length == 1){
                store[args[0]] = {};
            }
            else{
                store[args[0]] = Object.create(store[args[2]]);
            }
        }

        function set(args) {
            let obj = store[args[0]];
            obj[args[1]] = args[2];
        }

        function print(args) {
            let result = [];
            let obj = store[args[0]];
            
            for (let key in obj) {
                result.push(`${key}:${obj[key]}`);
            }
            
            console.log(result.join(', '));
        }
        
        return {create,set,print};
    })();

    for (let str of input) {
        let cmdArgs = str.split(' ');
        let command = cmdArgs.shift();
        cmdProcessor[command](cmdArgs);
    }
}
