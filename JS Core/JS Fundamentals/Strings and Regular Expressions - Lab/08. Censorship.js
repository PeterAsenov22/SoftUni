function censorship(text, words) {
    for (let word of words) {
        let replaceString = '-'.repeat(word.length);

        while(text.indexOf(word) > -1){
            text = text.replace(word,replaceString);
        }
    }

    return text;
}
