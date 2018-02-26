(function () {
    String.prototype.ensureStart = function (str) {
       if(!this.startsWith(str)){
           return str+this.toString();
       }

       return this.toString();
    };

    String.prototype.ensureEnd = function (str) {
        if(!this.endsWith(str)){
            return this.toString()+str;
        }

        return this.toString();
    };

    String.prototype.isEmpty = function () {
        if(this.length==0){
            return true;
        }

        return false;
    };

    String.prototype.truncate = function (n) {
        if(this.length<n){
            return this.toString();
        }

        if(this.length>n){
            let arr = this.split(' ');
            if(arr.length == 1){
                if(arr[0].length <= 4){
                    return '.'.repeat(n);
                }
                else{
                    arr = arr[0].split('');
                    return arr.splice(0,n-3).join('')+'...';
                }
            }
            else {
                let removed = arr.pop().toString().length+1;
                while (this.length-removed+3>n){
                    removed += arr.pop().toString().length+1;
                }

                return arr.join(' ')+'.'.repeat(3);
            }
        }
    };

    String.format = function () {
        let string = arguments[0];

        for (let i = 1; i < arguments.length; i++) {
           let param = arguments[i];
           string = string.replace(`{${i-1}}`,param);
        }

        return string;
    };
})()
