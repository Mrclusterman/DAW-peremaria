function palindrome(str) {
    str = str.toLowerCase().replace(/[^a-zA-Z0-9]/g,'');
    return str == str.split('').reverse().join('');

}



// to check the operation of the function
const corpusPal = {
    "eye": true,
    "_eye": true,
    "race car": true,
    "not a palindrome": false,
    "A man, a plan, a canal. Panama": true,
    "never odd or even": true,
    "Dabale arroz a la zorra el Abad": true,
    "nope": false,
    "Polop": true,
    "almostomla": false,
    "My age is 0, 0 si ega ym.": true,
    "1 eye for of 1 eye.": false,
    "0_0 (: /-\ :) 0-0": true,
    "five|\_/|four": false,
    "2_A3*3#a2": true
};

function checkPalindromes() {
    let result = true;
    for (let c in corpusPal) {
        // comment on the next line when you hand in the test
        //console.log(`palindrome("${c}") should return '${corpusPal[c]}' and return '${palindrome(c)}' -> ${(corpusPal[c] === palindrome(c)) ? 'RIGHT' : 'ERROR'}`);
        if (corpusPal[c] !== palindrome(c)) result = false;
    }
    return result;
}

console.log(`***** PALINDROME CHECKER ${checkPalindromes() ? 'PASSED' : 'FAILED'} *****`);
