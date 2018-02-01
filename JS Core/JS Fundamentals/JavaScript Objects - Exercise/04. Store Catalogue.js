function storeCatalogue(inputLines) {
    let catalogue = {};

    for (let line of inputLines) {
        line = line.split(' : ');
        let productName = line[0];
        let price = line[1];

        let key = productName[0];
        if(!catalogue.hasOwnProperty(key)){
            catalogue[key] = [];
        }

        catalogue[key].push(`${productName}: ${price}`);
    }

    let catalogueKeys = Object.keys(catalogue).sort();
    for (let catalogueKey of catalogueKeys) {
        console.log(catalogueKey);
        let products = catalogue[catalogueKey].sort();
        for (let product of products) {
            console.log(`  ${product}`)
        }
    }
}
