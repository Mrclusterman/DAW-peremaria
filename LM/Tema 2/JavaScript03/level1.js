const firstName = "Gabriel"
const lastName = "Miralles"
const country = "Spain"
const city = "Alfaz"
const age = 20;
const isMarried = false;
const year = new Date().getFullYear();

let vars = [firstName, lastName, country, city, age, isMarried, year];
vars.forEach(function (element) {
    console.log(typeof element);
});

console.log("10" === 10)
console.log(parseInt(9.8) === 10);

let sunny,windy,rain = true;
let fail,unsuccessful,bored = false;
/*
i. 4 > 3        true
ii. 4 >= 3      true
iii. 4 < 3      false
iv. 4 <= 3       false
v. 4 == 4       true
vi. 4 === 4     true
vii. 4 != 4     false
viii. 4 !== 4   false
ix. 4 != '4'    false
x. 4 == '4'     false
xi. 4 === '4'   true
xii. Find the length of python and jargon and make a falsy comparison statement. py < jar false
*/

// To proove this code uncomment this part and comment the next exercise
// let i = 4 > 3;
// let ii = 4 >= 3;
// let iii = 4 < 3;
// let iv = 4 <= 3;
// let v = 4 == 4;
// let vi = 4 === 4;
// let vii = 4 != 4;
// let viii = 4 !== 4;
// let ix = 4 != '4';
// let x = 4 == '4';
// let xi = 4 === '4';
// let xii = 'python'.length < 'jarson'.length;

// let vars2 = [i,ii,iii,iv,v,vi,vii,viii,ix,x,xi,xii];
// vars2.forEach(function (element) {
//     console.log(element);
// });

/*
i. 4 > 3 && 10 < 12     true
ii. 4 > 3 && 10 > 12    dalse
iii. 4 > 3 || 10 < 12   true
iv. 4 > 3 || 10 > 12    true
v. !(4 > 3)             false
vi. !(4 < 3)            true
vii. !(false)           true
viii. !(4 > 3 && 10 < 12)   false
ix. !(4 > 3 && 10 > 12)     true
x. !(4 === '4')             true
xi. There is no 'on' in both dragon and python  false

*/
let i = 4 > 3 && 10 < 12;
let ii = 4 > 3 && 10 > 12;
let iii = 4 > 3 || 10 < 12;
let iv = 4 > 3 || 10 > 12;
let v = !(4 > 3);
let vi = !(4 < 3);
let vii = !(false);
let viii = !(4 > 3 && 10 < 12);
let ix = !(4 > 3 && 10 > 12);
let x = !(4 === '4');
let xi = !('python'.match(/on/) < 'dragon'.match(/on/));


let vars3 = [i,ii,iii,iv,v,vi,vii,viii,ix,x,xi];
vars3.forEach(function (element) {
    console.log(element);
});
/*
i. What is the year today?
ii. What is the month today as a number?
iii. What is the date today?
iv. What is the day today as a number?
v. What is the hours now?
vi. What is the minutes now?
vii. Find out the numbers of seconds elapsed from January 1, 1970 to now.
*/

console.log(year);
let date = new Date();
let month = date.getMonth();
console.log(month);
console.log(date);
const numDate = date.getDay();
console.log(numDate);
const hours = date.getHours();
console.log(hours);
const minutes = date.getMinutes();
console.log(minutes);
const now = new Date() 
console.log(now.getTime())
