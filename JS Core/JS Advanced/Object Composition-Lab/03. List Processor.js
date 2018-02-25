function process(commands) {
    let cmdProcessor = (function () {
        let container = [];
        
        function add(str) {
            container.push(str);
        }

        function remove(str) {
            container = container.filter(e=>e!=str);
        }
        
        function print() {
            console.log(container.join(','));
        }
        
        return {add,remove,print};
    })();

    for (let command of commands) {
        let cmdArgs = command.split(' ');
        cmdProcessor[cmdArgs[0]](cmdArgs[1]);
    }
}
