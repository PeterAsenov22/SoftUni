function personalBmi(name,age,weight,height) {
    let obj = {
        name: name,
        personalInfo: {
            age: age,
            weight: weight,
            height: height
        },
        BMI : (function () {
            let bmi = Math.round(weight/Math.pow(height/100,2));
            return bmi;
        })()
    };

    obj.status =  (function () {
        let bmi = obj.BMI;

            if (bmi < 18.5) {
                return 'underweight';
            }
            else if( bmi < 25) {
                return 'normal';
            }
            else if (bmi < 30){
                return 'overweight';
             }
            else{
                return 'obese';
            }
    })();

    if(obj.status == 'obese'){
        obj.recommendation = 'admission required';
    }

    return obj;
}
