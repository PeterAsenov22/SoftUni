function heroicInventory(inputLines) {
    let register = [];

    for (let line of inputLines) {
        line = line.split('/').filter(e => e!='').map(e => e.trim());
        let name = line[0];
        let level = Number(line[1]);

        let heroItem = {
            name: name,
            level: level,
            items: []
        }

        if(line.length>2){
            let items = line[2].split(', ').filter(e => e!='');

            heroItem["items"] = items;
        }

        register.push(heroItem);
    }

    return JSON.stringify(register);
}
