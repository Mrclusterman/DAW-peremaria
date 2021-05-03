let sentence1 = 'Love is the best thing in this world. Some found their love and some are still looking for their love.';
let loveCount = sentence1.match(/love/g);
console.log(loveCount.length);
let sentence2 =  'You cannot end a sentence with because because because is a conjunction';
let becauseCount = sentence2.match(/because/g);
console.log(becauseCount.length);
const sentence = '%I $am@% a %tea@cher%, &and& I lo%#ve %te@a@ching%;. The@re $is no@th@ing; &as& mo@re rewarding as educa@ting &and& @emp%o@weri@ng peo@ple.; I found tea@ching m%o@re interesting tha@n any ot#her %jo@bs. %Do@es thi%s mo@tiv#ate yo@u to be a tea@cher!? %Th#is Beautiful#Days&OfJavaScript &is al@so $the $resu@lt of &love& of tea&ching'
let sentenceAux = sentence.replace(/%/g,'');
sentenceAux = sentenceAux.replace(/@/g,'');
sentenceAux = sentenceAux.replace(/#/g,'');
sentenceAux = sentenceAux.replace(/;/g,'');
sentenceAux = sentenceAux.replace(/&/g,'');
let dollarAux = '$';
sentenceAux = sentenceAux.replace(/dollarAux/g, '');
console.log(sentenceAux);
let exercise4 = 'He earns 5000 euro from salary per month, 10000 euro annual bonus, 15000 euro online courses per month.' 
let arr = exercise4.match(/\d+/g) 
let sum = 0 
for(let index=0 ;index<arr.length;index++){
   sum=sum+parseInt(arr[index])
} 
console.log(sum)