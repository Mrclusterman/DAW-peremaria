function rot13(str) {
    return str.toUpperCase().replace(/[A-Z]/gi, c =>
        "NOPQRSTUVWXYZABCDEFGHIJKLMnopqrstuvwxyzabcdefghijklm"[
        "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".indexOf(c) ] )
}



// to check the operation of the function
const corpusRot13 = {
    "qbt": "DOG",
    "DOG": "QBT",
    "JRNGURE-JVFR": "WEATHER-WISE",
    "WEATHER-WISE": "JRNGURE-JVFR",
    "ZL GNVYBE VF EVPU": "MY TAILOR IS RICH",
    "MY TAILOR IS RICH": "ZL GNVYBE VF EVPU",
    "GURER NER 100 CVTRBAF NG FRN": "THERE ARE 100 PIGEONS AT SEA",
    "THERE ARE 100 PIGEONS AT SEA": "GURER NER 100 CVTRBAF NG FRN",
    "Jr jrer bhgentrq gung gur nhgubevgvrf qvqa'g erfcbaq.": "WE WERE OUTRAGED THAT THE AUTHORITIES DIDN'T RESPOND.",
    "WE WERE OUTRAGED THAT THE AUTHORITIES DIDN'T RESPOND.": "JR JRER BHGENTRQ GUNG GUR NHGUBEVGVRF QVQA'G ERFCBAQ.",
    "GUR DHVPX OEBJA SBK WHZCF BIRE GUR YNML QBT.": "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG.",
    "The quick brown Fox jumps over the lazy dog.": "GUR DHVPX OEBJA SBK WHZCF BIRE GUR YNML QBT.",
    "Gur Pbheglneq Bs zL Ubhfr Vf ceviNgr, juRa vg Envaf vg Trgf jrG yVxr guR bgureF.": "THE COURTYARD OF MY HOUSE IS PRIVATE, WHEN IT RAINS IT GETS WET LIKE THE OTHERS.",
    "THE COURTYARD OF MY HOUSE IS Private, WHEN IT Rains IT GETS WET LIKE THE OTHERS.": "GUR PBHEGLNEQ BS ZL UBHFR VF CEVINGR, JURA VG ENVAF VG TRGF JRG YVXR GUR BGUREF.",
    "Jung n ohapu bs ehyref (#vs lbh pna pnyy gurz gung#) jr unir va FCNVA :((": "WHAT A BUNCH OF RULERS (#IF YOU CAN CALL THEM THAT#) WE HAVE IN SPAIN :((",
    "what a BUNCH OF RULERS (#if you can call them that#) we have in SPAIN :((": "JUNG N OHAPU BS EHYREF (#VS LBH PNA PNYY GURZ GUNG#) JR UNIR VA FCNVA :(("
};

function checkRot13() {
    let result = true;
    for (let c in corpusRot13) {
        // comment on the next line when you hand in the test
        //console.log(`rot13("${c}") should return '${corpusRot13[c]}' and return '${rot13(c)}' -> ${(corpusRot13[c] === rot13(c)) ? 'RIGHT' : 'ERROR'}`);
        if (corpusRot13[c] !== rot13(c)) result = false;
    }
    return result;
}

console.log(`***** CAESAR CIPHER ${checkRot13() ? 'PASSED' : 'FAILED'} *****`);
