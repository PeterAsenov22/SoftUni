function restaurantBill(input) {
    let products = input.filter((e,i) => i%2==0);
    let sum = input.filter((e,i) => i%2!=0).map(Number).reduce((a,b) => a+b);

    return `You purchased ${products.join(', ')} for a total sum of ${sum}`
}
