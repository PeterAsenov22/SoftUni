function townToJson(arr){
    arr.shift();

    let towns = [];
    for (let line of arr) {
        line = line.split('|').filter(e => e!='').map(e=>e.trim());
        let town = {
            Town : line[0],
            Latitude : Number(line[1]),
            Longitude : Number(line[2])
        }

        towns.push(town);
    }

    return JSON.stringify(towns);
}
