function gradsToDegrees(grads) {
    let degrees = (grads*0.9)%360;

    if(degrees < 0){
        return 360 + degrees;
    }

    return degrees;
}
