function capitalizeWords(text) {
    text = text.toLowerCase().split('');
    text[0] = text[0].toUpperCase();
    for (let i = 0; i < text.length - 1; i++) {
        if(text[i] == ' '){
            text[i+1] = text[i+1].toUpperCase();
        }
    }

    return text.join('');
}
