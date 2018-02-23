function solution() {
    let microElements = {
        fat: 0,
        flavour: 0,
        carbohydrate: 0,
        protein: 0
    };

    return function (commandString) {
        let cmdArgs = commandString.split(' ');
        let command = cmdArgs[0];

        if(command == 'restock'){
           let microElement = cmdArgs[1];
           let quantity = Number(cmdArgs[2]);

           microElements[microElement] += quantity;
           return 'Success';
        }
        else if(command == 'prepare'){
            let recipe = cmdArgs[1];
            let quantity = Number(cmdArgs[2]);

            if(recipe == 'apple'){
                if(!manage('carbohydrate',1,quantity)){
                    return error('carbohydrate');
                }

                if(!manage('flavour',2,quantity)){
                    microElements.carbohydrate += 1*quantity;

                    return error('flavour');
                }

                return 'Success';
            }
            else if(recipe == 'coke'){
                if(!manage('carbohydrate',10,quantity)){
                    return error('carbohydrate');
                }

                if(!manage('flavour',20,quantity)){
                    microElements.carbohydrate += 10*quantity;

                    return error('flavour');
                }

                return 'Success';
            }
            else if(recipe == 'burger'){
                if(!manage('carbohydrate',5,quantity)){
                    return error('carbohydrate');
                }

                if(!manage('fat',7,quantity)){
                    microElements.carbohydrate += 5*quantity;

                    return error('fat');
                }

                if(!manage('flavour',3,quantity)){
                    microElements.carbohydrate += 5*quantity;
                    microElements.fat += 7*quantity;

                    return error('flavour');
                }

                return 'Success';
            }
            else if(recipe == 'omelet'){
                if(!manage('protein',5,quantity)){
                    return error('protein');
                }

                if(!manage('fat',1,quantity)){
                    microElements.protein += 5*quantity;

                    return error('fat');
                }

                if(!manage('flavour',1,quantity)){
                    microElements.protein += 5*quantity;
                    microElements.fat += 1*quantity;

                    return error('flavour');
                }

                return 'Success';
            }
            else if(recipe == 'cheverme'){
                if(!manage('protein',10,quantity)){
                    return error('protein');
                }

                if(!manage('carbohydrate',10,quantity)){
                    microElements.protein += 10*quantity;

                    return error('carbohydrate');
                }

                if(!manage('fat',10,quantity)){
                    microElements.protein += 10*quantity;
                    microElements.carbohydrate += 10*quantity;

                    return error('fat');
                }

                if(!manage('flavour',10,quantity)){
                    microElements.protein += 10*quantity;
                    microElements.carbohydrate += 10*quantity;
                    microElements.fat += 10*quantity;

                    return error('flavour');
                }

                return 'Success';
            }
        }
        else if(command == 'report'){
            return `protein=${microElements.protein} carbohydrate=${microElements.carbohydrate} fat=${microElements.fat} flavour=${microElements.flavour}`;
        }

        function error(ingredient) {
            return `Error: not enough ${ingredient} in stock`;
        }

        function manage(ingredient,ingredientQuantity,recipeQuantity) {
            let needed = ingredientQuantity*recipeQuantity;
            if(microElements[ingredient] < needed){
                return false;
            }
            microElements[ingredient] -= needed;
            return true;
        }
    }
};
