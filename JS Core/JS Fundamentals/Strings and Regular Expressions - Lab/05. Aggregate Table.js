function aggregateTable(table) {
    let towns = [];
    let sum = 0;
    for (let line of table) {
        line = line.split('|').filter(e => e != '').map(e => e.trim());
        towns.push(line[0]);
        sum += Number(line[1]);
    }

    console.log(towns.join(', '));
    console.log(sum);
}
