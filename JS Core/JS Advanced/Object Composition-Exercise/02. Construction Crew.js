function modify(obj) {
    if(obj.handsShaking == true){
        obj.bloodAlcoholLevel += (obj.weight * 0.1)*obj.experience;
        obj.handsShaking = false;
    }

    return obj;
}
