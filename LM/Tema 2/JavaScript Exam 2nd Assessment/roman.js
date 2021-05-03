function convertToRoman(num) {
    if (num == 0 ) {
        return str = 'NUMBER TOO LOW';
    }
    if (num >= 5000) {
        return str = 'NUMBER TOO HIGH';
    }
    var roman = {
        M: 1000,
        CM: 900,
        D: 500,
        CD: 400,
        C: 100,
        XC: 90,
        L: 50,
        XL: 40,
        X: 10,
        IX: 9,
        V: 5,
        IV: 4,
        I: 1
        
      };
      var str = '';
    
      for (var i of Object.keys(roman)) {
        var q = Math.floor(num / roman[i]);
        num -= q * roman[i];
        str += i.repeat(q);
      }
      

      return str;

}



// to check the operation of the function
const corpusRoman = {
    0: 'NUMBER TOO LOW',
    2: "II",
    3: "III",
    4: "IV",
    5: "V",
    6: "VI",
    7: "VII",
    8: "VIII",
    9: "IX",
    10: "X",
    12: "XII",
    16: "XVI",
    29: "XXIX",
    44: "XLIV",
    45: "XLV",
    68: "LXVIII",
    83: "LXXXIII",
    97: "XCVII",
    99: "XCIX",
    400: "CD",
    500: "D",
    501: "DI",
    649: "DCXLIX",
    798: "DCCXCVIII",
    891: "DCCCXCI",
    1000: "M",
    1004: "MIV",
    1006: "MVI",
    1023: "MXXIII",
    2014: "MMXIV",
    2021: "MMXXI",
    3001: "MMMI",
    3999: "MMMCMXCIX",
    5000: "NUMBER TOO HIGH"
};

function checkNumsToRoman() {
    let result = true;
    for (let c in corpusRoman) {
        // comment on the next line when you hand in the test
        //console.log(`convertToRoman("${c}") should return '${corpusRoman[c]}' and return '${convertToRoman(c)}' -> ${(corpusRoman[c] === convertToRoman(c)) ? 'RIGHT' : 'ERROR'}`);
        if (corpusRoman[c] !== convertToRoman(c)) result = false;
    }
    return result;
}

console.log(`***** ROMAN NUMERAL CONVERTER ${checkNumsToRoman() ? 'PASSED' : 'FAILED'} *****`);
