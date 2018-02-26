function generateLinkedList() {
    return (function () {
        let storage = [];

        function add(element) {
            storage.push(element);
            reSort();
        }

        function remove(index) {
            if(isValidIndex(index)){
                storage.splice(index,1);
                reSort();
            }
            else{
               throw new Error;
            }
        }

        function get(index) {
            if(isValidIndex(index)){
                return storage[index];
            }
            else{
                throw new Error;
            }
        }

        function size() {
            return storage.length;
        }

        function isValidIndex(index) {
            return index >= 0 && index < storage.length;
        }

        function reSort() {
            storage.sort((a,b) => a-b);
        }

        let a = {add,remove,get};
        a.__defineGetter__("size",size);
        return a;
    })();
}
