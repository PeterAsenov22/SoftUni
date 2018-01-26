function emailValidation(email) {
    let pattern = /^[A-Za-z0-9]+@[a-z]+\.[a-z]+$/g;
    return pattern.test(email) ? 'Valid' : 'Invalid';
}
