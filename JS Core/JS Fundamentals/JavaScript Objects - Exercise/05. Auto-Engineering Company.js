function carCompany(inputLines) {
    let register = new Map();

    for (let line of inputLines) {
        line = line.split(' | ');
        let brand = line[0];
        let model = line[1];
        let producedCars = Number(line[2]);

        if(!register.has(brand)){
            register.set(brand, new Map());
        }

        if(!register.get(brand).has(model)){
            register.get(brand).set(model, 0);
        }

        let currentProducedCarsCount = register.get(brand).get(model);
        register.get(brand).set(model, currentProducedCarsCount + producedCars);
    }
    
    let registerKeys = Array.from(register.keys());
    for (let key of registerKeys) {
        console.log(key);
        let modelsKeys = Array.from(register.get(key).keys());

        for (let modelKey of modelsKeys) {
            console.log(`###${modelKey} -> ${register.get(key).get(modelKey)}`);
        }
    }
}
