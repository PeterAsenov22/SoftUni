function occurrencesOfWord(sentence,word) {
    let regex = new RegExp(`\\b${word}\\b`,'gi');

    let occurrences = sentence.match(regex);
    return occurrences ? occurrences.length : 0;
}
