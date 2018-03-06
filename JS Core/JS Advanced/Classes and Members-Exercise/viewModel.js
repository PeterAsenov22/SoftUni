class Textbox{
    constructor(selector,regex){
        this._elements = $(selector);
        this.value = $(this.elements[0]).val();
        this._invalidSymbols = regex;
        this.onInput();
    }

    onInput(){
        this.elements.on('input', (event)=>{
            let text = $(event.target).val();
            this.value = text;
        });
    }

    get value(){
        return this._value;
    }

    set value(value){
        this._value = value;
        for (let elem of this._elements) {
            $(elem).val(value);
        }
    }

    get elements(){
        return this._elements;
    }

    isValid(){
        if(this._value.match(this._invalidSymbols)){
            return false;
        }

        return true;
    }
}

let textbox = new Textbox(".textbox",/[^a-zA-Z0-9]/);
let inputs = $('.textbox');

inputs.on('input',function(){console.log(textbox.value);});
