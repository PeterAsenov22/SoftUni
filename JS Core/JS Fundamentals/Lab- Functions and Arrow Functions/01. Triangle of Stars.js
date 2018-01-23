function triangleOfStars(n) {
    let result = '';
    for (let i = 1; i <= n; i++) {
       result += "*".repeat(i);
       result += '\n';
    }

    for (let i = n-1; i >= 1; i--) {
        result += "*".repeat(i);
        result += '\n';
    }

    return result;
}
