function cappyJuice(inputLines) {
    let juice = {};
    let bottles = {};

    for (let line of inputLines) {
        line = line.split(' => ');
        let juiceName = line[0];
        let juiceQuantity = Number(line[1]);

        if(!juice.hasOwnProperty(juiceName)){
            juice[juiceName] = 0;
        }

        juice[juiceName] += juiceQuantity;

        if(juice[juiceName] >= 1000){
            let bottlesCount = Math.floor(juice[juiceName]/1000);
            juice[juiceName] -= bottlesCount * 1000;

            if(!bottles.hasOwnProperty(juiceName)){
                bottles[juiceName] = 0;
            }

            bottles[juiceName] += bottlesCount;
        }
    }

    let bottlesKeys = Object.keys(bottles);

    for (let key of bottlesKeys) {
        console.log(`${key} => ${bottles[key]}`);
    }
}
