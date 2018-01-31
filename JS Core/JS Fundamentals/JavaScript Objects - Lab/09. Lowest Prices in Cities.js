function lowestPricesInCities(inputLines){
    let productsPrices = {};

    for (let line of inputLines) {
        line = line.split(' | ');
        let product = line[1];
        let town = line[0];
        let productPrice = Number(line[2]);

        if(!productsPrices.hasOwnProperty(product)){
            productsPrices[product] = {};
        }

        productsPrices[product][town] = productPrice;
    }
    
    let products = Object.keys(productsPrices);
    for (let product of products) {
        let townsPrices = productsPrices[product];
        let townsPricesKeys = Object.keys(townsPrices);
        let currentCheapestTown = townsPricesKeys[0];
        townsPricesKeys.shift();

        for (let town of townsPricesKeys) {
            if(townsPrices[town] < townsPrices[currentCheapestTown]){
                currentCheapestTown = town;
            }
        }

        console.log(`${product} -> ${townsPrices[currentCheapestTown]} (${currentCheapestTown})`);
    }
}
