class Rat{
    constructor(name){
        this.name = name;
        this.unitedRats = [];
    }

    getRats(){
        return this.unitedRats;
    }

    unite(rat){
        if(rat instanceof Rat) {
            this.unitedRats.push(rat);
        }
    }

    toString(){
        let result = '';
        result += this.name + '\n';

        for (let rat of this.unitedRats) {
            result += `##${rat.name}\n`;
        }

        return result.trim();
    }
}
