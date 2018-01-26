function expressionSplit(expression) {
    return expression.split(/[(),;.\s]+/).filter(e => e!='').join('\n');
}
