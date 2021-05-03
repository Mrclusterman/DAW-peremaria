 // this is your main.js script
 let age = Number(prompt("Enter your age"));
if (age > 18) {
    console.log("You are old enough to drive.");
} else {
    console.log(`You are left with ${18-age} years to drive.`);
}

let yourAge = 30;
if (age > yourAge) {
    console.log(`I'm older than you with ${age - yourAge}.`);
} else {
    console.log(`You are ${yourAge - age} years older than me.`);
}

let a = 4;
let b = 3;
if (a > b) {
    console.log("A is greater than b.");
} else {
    console.log("B is less than b.");

}
//ternary
(a > b) ? console.log("A is greater than b"): console.log("A is less than b");

let score = Number(prompt("Enter your score:"));
switch (true) {
    case score > 80:
        console.log("A");
        break;
    case score > 70:
        console.log("B");
        break;
    case score > 60:
        console.log("C");
        break;
    case score > 50:
        console.log("D");
        break;
    case (score < 50):
        console.log("F");
        break;
    default:
        console.log("No score assigned.");
}


//seasons
let month = prompt("Enter month to check seasons:");
switch (month) {
    case "september":
    case "october":
    case "November":
        console.log("The season is Autumn.");
        break;
    case "december":
    case "january":
    case "febuary":
        console.log("The season is Winter.");
        break;
    case "march":
    case "april":
    case "may":
        console.log("The season is Spring.");
        break;
    case "june":
    case "july":
    case "august":
        console.log("The season is Summer.");
        break;
    default:
        console.log("Invalid Month.");
}

//even and odd
let num = Number(prompt("Enter number to know if it's even/odd:"));
if (num % 2 === 0) {
    console.log(`${num} is an even number.`);
} else if (num % 2 !== 0) {
    console.log(`${num} is an odd number.`);
}

//check weekend
let weekDay = prompt("Enter weekDay to check if it's a weekend:");
if (weekDay == "saturday" || weekDay == "sunday") {
    console.log(`${weekDay} is a weekend day`);
} else if (weekDay == "monday" || weekDay == "tuesday" || weekDay == "wednesday" || weekDay == "thursday" || weekDay == "friday") {
    console.log(`${weekDay} is a work day.`);
} else {
    console.log("Invalid weekDay.");
}

//checkDays in month
let month2 = prompt("Enter month to check number of days:");
switch (month2) {
    case "january":
    case "march":
    case "may":
    case "july":
    case "august":
    case "october":
    case "december":
        console.log(`${month2} has 31 days`);
        break;
    case "april":
    case "june":
    case "september":
    case "november":
        console.log(`${month2} has 30 days`);
        break;
    case "febuary":
        console.log(`${month2} has 29 days`);
        break;
    default:
        console.log("Invalid month entered.");
}

//checkDays in month with leap year
let month3 = prompt("Enter month to check number of days:");
switch (month3) {
    case "january":
    case "march":
    case "may":
    case "july":
    case "august":
    case "october":
    case "december":
        console.log(`${month3} has 31 days`);
        break;
    case "april":
    case "june":
    case "september":
    case "november":
        console.log(`${month3} has 30 days`);
        break;
    case "febuary":
        let year = prompt("Enter year to check leap year");
        const isLeapYear = (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        const days = isLeapYear? 29 : 28;
        console.log(`${month3} has ${days} days.`);
        break;
    default:
        console.log("Invalid month entered.");
}