function sumByTown(array) {
    let obj = {};

    for (let i = 0; i < array.length; i+=2) {
        let key = array[i];
        let value = Number(array[i + 1]);

        if (!obj.hasOwnProperty(array[i])) {
            obj[array[i]] = 0;
        }

        obj[array[i]] += Number(array[i + 1]);
    }

    return JSON.stringify(obj);
}
