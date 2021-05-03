// this is your main.js script
console.log(countries)
console.log(webTechs)
alert('Open the browser console whenever you work on JavaScript');
alert('Open the console and check if the countries has been loaded');
let empty = [];
let food = ["chips", "rice", "tomatoe", "fish", "yogur"];
console.log(food.length);
let firstItem = console.log(food[0]);
let middleItem = console.log(food[2]);
let lastItem = console.log(food[food.length - 1]);
let mixedDataType = ["Gabriel", 20, true, null, {favoriteFood: ["chips", "fish", "stew"]}, undefined];
let itCompanies = ["Facebook", "Google", "Microsoft", "Apple", "IBM", "Oracle", "Amazon"];
console.log(itCompanies);
console.log(itCompanies.length);
console.log(itCompanies[0]);
console.log(itCompanies[3]);
console.log(itCompanies[itCompanies.length - 1]);
itCompanies.forEach(element => console.log(element));
itCompanies.forEach(element => console.log(element.toUpperCase()));
console.log(new Intl.ListFormat().format(itCompanies));
let searchitCompanies = prompt("enter company to search");
if (itCompanies.includes(searchitCompanies)) {
    console.log(searchitCompanies);
} else {
    console.log("company not found");
}
let oo = []
for (let i = 0; i < itCompanies.length; i++) {
    oo.push(itCompanies[i].includes("oo"));
}
itCompanies.sort();
itCompanies.reverse();
itCompanies.slice(0, 3);
itCompanies.slice(itCompanies.length - 1, 3)
itCompanies.slice(Math.floor(itCompanies.length / 2), 1);
itCompanies.shift();
itCompanies.splice(1,itCompanies.length -1);
itCompanies.pop();
for (let i = 0; i < itCompanies.length; i++) {
    itCompanies.pop();
}
let text = "I love teaching and empowering people. I teach HTML, CSS, JS, React, Python."
text.split("");
console.log(text.length);
let shoppingCart = ["milk", "coffee", "tea", "honey"]
shoppingCart.unshift("meat");
shoppingCart.push("sugar");
shoppingCart.splice(shoppingCart.length -2,shoppingCart.length -1);
shoppingCart[shoppingCart.indexOf("tea")] = "green tea";
const checkEthio = countries.includes("Ethiopia") ? console.log("Ethiopia is in Countries"): countries.unshift("Ethiopia");
const checkSass = webTechs.includes("Sass") ? console.log("Sass is in webTech"): webTechs.unshift("Sass") && console.log(webTechs);
let frontend = ['HTML', 'CSS', 'JS', 'React', 'Redux'];
let backend = ['Node', 'Express', 'MongoDB'];
console.log(frontend.concat(backend));
let ages = [19, 22, 19, 24, 20, 25, 26, 24, 25, 24];
let minAge = ages.sort()[0];
let maxAge = ages.sort()[ages.length - 1];
console.log(minAge);
console.log(maxAge);
let medianAge = ages[Math.floor(ages.length / 2)];
console.log(medianAge);

let avgAge;
let totalAge = 0;
for (i = 0; i < ages.length; i++) {
    totalAge += ages[i];
    avgAge = totalAge / ages.length;
}

console.log(avgAge);
let range = maxAge - minAge;
console.log(range);
let ma = Math.abs(minAge - avgAge);
let maa = Math.abs(maxAge - avgAge);
console.log(ma);
console.log(maa);
console.log(countries.slice(0,10));
console.log(countries[Math.floor(countries.length/2)]);
let parCountries = countries.length % 2 == 0;
if (parCountries == true){
    const half = countries.length % 2;
    const firstHalf = countries.splice(0,half);
    const secondHalf = countries.splice(-half);
    console.log(firstHalf);
    console.log(secondHalf);
}
else{
    const half = (countries.length % 2) + 1;
    const firstHalf = countries.splice(0,half);
    const secondHalf = countries.splice(-half);
    console.log(firstHalf);
    console.log(secondHalf);
}