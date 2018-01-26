function matchAllWords(text) {
    return text.match(/\w+/g).join('|');
}
