function solve(array, sortMethod) {
    let ascendingComparator = function (a,b) {
        return a-b;
    };

    let descendingComparator = function (a,b) {
        return b-a;
    };

    let sortingStrategies = {
        asc: ascendingComparator,
        desc: descendingComparator
    };

    return array.sort(sortingStrategies[sortMethod]);
}
