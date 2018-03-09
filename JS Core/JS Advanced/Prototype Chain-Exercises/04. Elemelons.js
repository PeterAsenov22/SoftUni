function elemelons() {
    class Melon{
        constructor(weight, melonSort){
            if(new.target === Melon){
                throw new Error('Melon cannot be initialized!');
            }

            this.weight = weight;
            this.melonSort = melonSort;
        }


        get elementIndex(){
            return this.weight * this.melonSort.length;
        }

        toString(){
            return `Element: ${this.getElementName()}\n` +
                `Sort: ${this.melonSort}\n` +
                `Element Index: ${this.elementIndex}`
        }

        getElementName(){
            let name = this.constructor.name;
            return name.substring(0,name.length-5);
        }
    }

    class Watermelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
        }
    }

    class Firemelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
        }
    }

    class Earthmelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
        }
    }

    class Airmelon extends Melon{
        constructor(weight, melonSort){
            super(weight, melonSort);
        }
    }

    class Melolemonmelon extends Watermelon{
        constructor(weight, melonSort){
            super(weight,melonSort);
            this._elements = ['Water','Fire','Earth','Air'];
            this._index = 0;
        }

        getElementName(){
            return this._elements[this._index%this._elements.length];
        }

        morph(){
            this._index++;
        }
    }

    return{
        Melon,
        Watermelon,
        Earthmelon,
        Airmelon,
        Firemelon,
        Melolemonmelon
    }
}
