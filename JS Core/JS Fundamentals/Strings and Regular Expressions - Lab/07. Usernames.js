function usernames(arr) {
    let usernamesArray = [];

    for (let el of arr) {
        el = el.split('@');
        let firstPart = el[0];
        let secondPart = el[1].split('.').map(e => e[0]).join('');
        let username = `${firstPart}.${secondPart}`;
        usernamesArray.push(username);
    }

    return usernamesArray.join(', ');
}
