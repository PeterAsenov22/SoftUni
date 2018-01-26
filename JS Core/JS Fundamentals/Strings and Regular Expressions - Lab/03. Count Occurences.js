function countOccurrences(string,text) {
    let occurrencesCount = 0;

    let index = text.indexOf(string);
    while(index > -1){
        occurrencesCount++;
        index = text.indexOf(string,index+1);
    }

    return occurrencesCount;
}
