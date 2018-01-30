function cityMarkets(inputLines) {
    let townsMarkets = new Map();

    for (let line of inputLines) {
        line = line.split(' -> ');
        let town = line[0];
        let product = line[1];
        let salesInfo = line[2].split(' : ').map(e => Number(e));
        let productIncome = salesInfo[0] * salesInfo[1];

        if(!townsMarkets.has(town)){
            townsMarkets.set(town, new Map());
        }

        let oldIncome = townsMarkets.get(town).get(product);
        if(oldIncome){
            productIncome += oldIncome;
        }

        townsMarkets.get(town).set(product, productIncome);
    }
    
    let towns = Array.from(townsMarkets.keys());

    for (let town of towns) {
        let products = Array.from(townsMarkets.get(town).keys());

        console.log(`Town - ${town}`);
        for (let product of products) {
            console.log(`$$$${product} : ${townsMarkets.get(town).get(product)}`);
        }
    }
}
