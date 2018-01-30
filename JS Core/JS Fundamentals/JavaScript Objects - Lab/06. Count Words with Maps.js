function countWordsWithMap(array) {
    let text = array[0].toLowerCase();
    text = text.split(/\W+/g).filter(e=>e!='');
    let wordsCount = new Map();

    for (let word of text) {
        if(!wordsCount.has(word)){
            wordsCount.set(word,0);
        }

        wordsCount.set(word, wordsCount.get(word) + 1);
    }

    let allWords = Array.from(wordsCount.keys()).sort();
    allWords.forEach(e => console.log(`'${e}' -> ${wordsCount.get(e)} times`));
}
