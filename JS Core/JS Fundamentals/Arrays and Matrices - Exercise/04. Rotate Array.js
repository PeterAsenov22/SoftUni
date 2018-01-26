function rotate(input) {
    let k = Number(input.pop());
    let length = input.length;

    for (let i = 0; i < k%length; i++) {
        let num = input.pop();
        input.unshift(num);
    }

    console.log(input.join(' '));
}
