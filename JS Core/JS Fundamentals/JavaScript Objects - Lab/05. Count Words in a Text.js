function countWords(array) {
    let text = array[0];
    text = text.split(/\W+/g).filter(e=>e!='');
    let wordsCount = {};

    for (let word of text) {
        if(!wordsCount.hasOwnProperty(word)){
            wordsCount[word] = 0;
        }

        wordsCount[word] +=1;
    }

    return JSON.stringify(wordsCount);
}
