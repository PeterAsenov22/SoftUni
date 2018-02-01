function systemComponents(inputLines) {
    let database = new Map();

    for (let line of inputLines) {
        let [systemName,componentName,subcomponentName] = line.split(' | ');

        if(!database.has(systemName)){
            database.set(systemName, new Map());
        }

        if(!database.get(systemName).has(componentName)){
            database.get(systemName).set(componentName,[]);
        }

        database.get(systemName).get(componentName).push(subcomponentName);
    }

    function sortSystemComparator(sysA, sysB, catalogue) {
        let aComponents = catalogue.get(sysA).size;
        let bComponents = catalogue.get(sysB).size;
        if (aComponents > bComponents) return -1;
        if (aComponents < bComponents) return 1;

        return sysA.toLowerCase().localeCompare(sysB.toLocaleLowerCase());
    }

    let keys = Array.from(database.keys()).sort((a,b) => sortSystemComparator(a,b,database));
    for (let key of keys) {
        console.log(key);
        let componentsKeys = Array.from(database.get(key).keys()).sort((a,b) => database.get(key).get(b).length - database.get(key).get(a).length);
        for (let componentKey of componentsKeys) {
            console.log(`|||${componentKey}`);
            for (let subComponent of database.get(key).get(componentKey)) {
                console.log(`||||||${subComponent}`);
            }
        }
    }
}
