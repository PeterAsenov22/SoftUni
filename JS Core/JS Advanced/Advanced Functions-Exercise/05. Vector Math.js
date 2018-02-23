let solution = (function () {

    function addFunction(vec1,vec2) {
        let newVec = [];
        newVec.push(vec1[0] + vec2[0]);
        newVec.push(vec1[1] + vec2[1]);

        return newVec;
    }

    function multiplyFunction(vec1,scalar) {
        let newVec = [];
        newVec.push(vec1[0]*scalar);
        newVec.push(vec1[1]*scalar);

        return newVec;
    }
    
    function lengthFunction(vec1) {
        return Math.sqrt(Math.pow(vec1[0],2) + Math.pow(vec1[1],2));
    }

    function dotFunction(vec1,vec2) {
        return vec1[0]*vec2[0] + vec1[1]*vec2[1];
    }
    
    function crossFunction(vec1,vec2) {
        return vec1[0]*vec2[1] - vec1[1]*vec2[0];
    }

    let obj = {
        add: addFunction,
        multiply: multiplyFunction,
        length: lengthFunction,
        dot: dotFunction,
        cross: crossFunction
    };
    
    return obj;
})();
