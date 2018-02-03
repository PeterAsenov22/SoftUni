function usernames(inputLines) {
    let catalogue = new Set();

    for (let line of inputLines) {
        catalogue.add(line);
    }

    function sortAlgorithm(a,b) {
        let firstCriteria = a.length - b.length;
        if(firstCriteria != 0){
            return firstCriteria;
        }
        else {
            return a.localeCompare(b);
        }
    }
    
    let catalogueArray = Array.from(catalogue).sort(sortAlgorithm);
    for (let username of catalogueArray) {
        console.log(username);
    }
}
