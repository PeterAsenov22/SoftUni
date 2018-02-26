function getCar(requirements) {

    let car = {
        model: requirements.model,
        engine: (function () {
            if(requirements.power<=90){
                return {power: 90, volume: 1800};
            }
            else if(requirements.power <=120){
                return {power: 120, volume: 2400};
            }
            else{
                return {power: 200, volume: 3500};
            }
        })(),
        carriage: {type: requirements.carriage, color: requirements.color},
        wheels: (function () {
            let size = Math.round(requirements.wheelsize);
            if(size%2==0){
                size--;
            }

            return [size,size,size,size];
        })()
    };

    return car;
}
