function myFunc() {
    let summary = [];

    for (let i = 0; i < arguments.length; i++) {
        let obj = arguments[i];
        let type = typeof obj;
        console.log(`${type}: ${obj}`);

        if(!summary.find(e => e['type'] == type)){
            let obj = {type: type, count:1};
            summary.push(obj);
        }
        else{
            summary.find(e => e['type'] == type).count++;
        }
    }

    for (let elem of summary.sort((a,b) => b.count - a.count)) {
        console.log(`${elem.type} = ${elem.count}`);
    }
}
