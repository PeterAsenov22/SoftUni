function compoundInterest([P,interest,compoundPeriod,t]) {
let n = 12/compoundPeriod;
let i = interest/100;
let result = P*(Math.pow(1+(i/n),n*t));

return result.toFixed(2);
}
