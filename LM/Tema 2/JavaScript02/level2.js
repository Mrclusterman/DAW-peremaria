let quote = "The quote 'There is no exercise better for the heart than reaching down andlifting people up.' by John Holmes teaches us to help one another.";
console.log(quote);
let parapragh = "Love is not patronizing and charity isn't about pity, it is about love. Charity and love are the same -- with charity you give love, so don't just give money but reach out your hand instead.";
console.log(parapragh);
let int = 10;
let string = '10';
//int and string are not equals to make it equals just parse anyone to the other data type
//parse('9.8') and 10 are not equals to make it equals just pase to int 9,8 round out
let py = 'python';
let jar = 'jargon';
let pyTrue = py.search('on');
let jarTrue = jar.search('on');
//that proove in witch position is 'on' in py and jar and return the position in the string
let sentence = 'I hope this course is not full of jargon';
let exercise6 = sentence.search('jargon');
if (exercise6 > 0){
    console.log('true');
}
const randNum = Math.floor((Math.random() * 100) + 1);
console.log(randNum);
const randomNum = Math.floor((Math.random() * 51) + 50);
console.log(randomNum);
const randomNum2 = Math.floor((Math.random() * 255) + 1);
console.log(randomNum2);
const num = Math.floor(Math.random () * 11);
console.log(num);
let js = 'JavaScript';
console.log(js.charAt(num));
console.log('1 1 1 1 1\n2 1 2 4 8\n3 1 3 9 27\n4 1 4 16 64\n5 1 5 25 125');
let exercise12 = 'You cannot end a sentence with because because because is a conjunction';
let subexercise12 = exercise12.substr(exercise12.indexOf('because'), 23);
console.log(subexercise12);