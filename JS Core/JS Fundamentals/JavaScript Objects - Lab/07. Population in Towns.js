function populationInTowns(inputLines) {
    let townsPopulation = {};

    for (let line of inputLines) {
        line = line.split(' <-> ');
        let townName = line[0];
        let population = Number(line[1]);

        if(!townsPopulation.hasOwnProperty(townName)){
            townsPopulation[townName] = 0;
        }

        townsPopulation[townName] += population;
    }

    let keys = Object.keys(townsPopulation);

    for (let key of keys) {
        console.log(`${key} : ${townsPopulation[key]}`)
    }
}
