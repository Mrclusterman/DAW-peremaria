//console.log(countries)
//alert('Open the console and check if the countries has been loaded')
//Exersice Level 1
//1
[
    function fullName() {
        console.log('Gabriel Miralles Alvarez');
    }
]
//2
[
    function fullName() {
        let firstName = prompt("Please enter your First name","Paquito");
        let lastName = prompt("Please enter your Second name", "El Chocolatero")
        const space = " ";
        let fullName = firstName + space + lastName;
        console.log(fullName);
    }
]
//3
[
    function addNumbers(numOne, numTwo) {
        let sum = numOne + numTwo;
        return sum;
    }
]
//4
[
    function areaOfRectangle(length, width) {
        let area = length * width;
        return area;
    }
]
//5
[
    function perimeterOfRectangle(length, width) {
        let perimeter = 2 * (length + width);
        return perimeter;
    }
]
//6
[
    function volumeOfRectPrism(length, width, height) {
        let volume = length * width * height;
        return volume;
    }
]
//7
[
    function areaOfCircle(r) {
        let area = Math.PI * r * r;
        return area; 
    }
]
//8
[
    function circumOfCircle(r) {
        let circumference = 2 * Math.PI * r;
        return circumference;
    }
]
//9
[
    function densityOf(mass, volume) {
        let density = mass / volume;
        return density;
    }
]
//10
[
    function speedOf(distance, time) {
        let speed = distance / time;
        return speed;
    }
]
//11
[
    function weightOf(mass, gravity){
        let weight = mass * gravity;
        return weight;
    }
]
//12
[
    function convertCelciusToFahrenheit(c) {
        let fahrenheit = (c * 9 / 5) + 32;
        return fahrenheit;
    }
]
//13
[
    function bmiOf(weight, height) {
        let bmi = weight / (height * height);
        let bodygroup = bmi < 18.5  ? "Underweight" : bmi < 24.9 ?  "Normal" : bmi < 29.9 ?  "Overweight" :  "Obese";
        return bodygroup;
    } 
]
//14
[
    function chechSeason(month) {
        let summer = ["June", "July", "August"];
        let winter = ["DecemBer","February","January"];
        let spring = ["March", "April", "May"];
        let autumn = ["September", "October", "November"];
        let season = summer.includes(month) ? "Summer" : winter.includes(month) ? "Winter" : spring.includes(month) ? "Spring" : autumn.includes(month) ? "Autumn" : "Error";
        return season;
    }
]
//15
[
    function findMax(arg1, arg2, arg3) {
        let max = (arg1 >= arg2 && arg1 >= arg3) ? arg1 : (arg2 >= arg1 && arg2 >= arg1) ? arg2 : (arg3 >= arg1 && arg3 >= arg2) ? arg3 : "Error";
        return max;
    }
]
//Exercise: Level 2
//1
[
    function solveLinEquation(equation) {
        let eq1 = equation.split('=');
        let solution = eq1[0].split(" ");
        
    }
]
//2
[
    function solveQuadEquation(equation) {

    }
]
//3
[
    function printArr(arr) {
        arr.forEach(function (ar) {
            console.log(ar);
        })
    }
]
//4
[
    function showDateTime() {
        let date = new Date();
        let datee = date.getDate();
        let month = date.getUTCMonth();
        let year = date.getFullYear();
        let hour = date.getHours();
        let minutes = date.getMinutes();
        return `${datee}/${month + 1}/${year} ${hour}:${minutes} `
    }
]
//5
[
    function swapValues(a, b) {
        let x = b;
        let y = a;
        console.log(x, y)
    }
]
//6
[
    function reverseArr(arr) {
        let newArr = [];
        for (let i = 0; i < arr.length; i++) {
            newArr.unshift(arr[i]);
        }
        console.log(newArr);
    }
]
//7
[
    function capitalizeArr(arr) {
        let newArr = [];
        arr.forEach(function (ar) {
            newArr.push(ar.toUpperCase());
        })
        return newArr;
    }
]
//8
[

]
//9
[
    function removeitem(index) {
        let names = ["Gabriel", "Miralles"]
        names.splice(index);
        return names
    }
]
//10
[
    function sumOfNumbers(...values) {
        let sum = 0;
        values.forEach(function (arg) {
            sum += arg
        })
        return sum;
    }
]
//11
[
    function sumOfEven(...values) {
        let evenSum = 0;
        values.forEach(function (arg) {
            if (arg % 2 === 0) {
                evenSum += arg
            }
        })
        return evenSum;
    }
]
//12
[
    function sumOfOdd(...values) {
        let oddSum = 0;
        values.forEach(function (arg) {
            if (arg % 2 === 0) {
                oddSum += arg
            }
        })
        return oddSum;
    }
]
//13
[
    function evenAndOdds(num) {
        let odd = 0;
        let even = 0;
        for (let i = 0; i <= num; i++) {
            if (i % 2 === 0) {
                even++
            } else if (i % 2 !== 0) {
                odd++
            }
        }
        return `The number of odds are ${odd} \n The number of even are ${even}`
    }
]
//14
[
    function sum(...args) {
        let sum = 0;
        args.forEach(function (num) {
            sum += num;
        })
    }
]
//15
[
    function randomUserIp() {
        let one = Math.floor(Math.random() * 255);
        let two = Math.floor(Math.random() * 255);
        let three = Math.floor(Math.random() * 255);
        let four = Math.floor(Math.random() * 255);
        return `IP: ${one}:${two}:${three}:${four}`
    }
]
//16
[
    function randomMacAddress() {

    }
]
//17
[
    function randomHexaNumberGenerator() {
        let chars = "0123456789ABCDEF";
        let hex = "";
        for (let i = 0; i <= 6; i++) {
            hex += chars[Math.floor(Math.random() * chars.length)];
        }
    
        return `#${hex}`
    }
]
//18
[
    function userIdGenerator() {
        let chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZabcdefghiklmnopqrstuvwxyz";
        let userId = "";
        for (let i = 0; i <= 7; i++) {
            userId += chars[Math.floor(Math.random() * chars.length)];
        }
        return userId;
    }
]
//Exercises: Level 3
//1
[
    function userIdGeneratedByUser() {
        let chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZabcdefghiklmnopqrstuvwxyz";
        let noId = Number(prompt("how many id do you want to generate"));
        let noChars = Number(prompt("in how many chars"));
        let ids = [];
        for (i = 0; i < noId; i++) {
            ids[i] = "";
            for (k = 0; k < noChars; k++) {
                ids[i] += chars[Math.floor(Math.random() * chars.length)];
            }
        }
        console.log(ids)
        ids.forEach(function (id) {
            console.log(id);
        })
    }
]
//2
[
    function rgbColorGnerator() {
        let one = Math.floor(Math.random() * 255);
        let two = Math.floor(Math.random() * 255);
        let three = Math.floor(Math.random() * 255);
        return `rgb(${one},${two},${three})`;
    }
]
//3
[
    function arrayOfHexaColors() {
        let chars = "0123456789ABCDEF";
        let hex = [];
        for (let k = 0; k < 3; k++) {
            hex[k] = "#";
            for (let i = 0; i < 6; i++) {
                hex[k] += chars[Math.floor(Math.random() * chars.length)];
            }
        }
    
        return hex;
    }
]
//4
[

]
//5
[

]
//6
[

]
//7
[
    function generateColors(type, arrLength) {
        let chars = "0123456789ABCDEF";
        let colors = [];
        if (type === "rgb") {
            for (i = 0; i < arrLength; i++) {
                colors[i] = "rgb";
                colors[i] += `(${ Math.floor(Math.random() * 255) },`;
                colors[i] += `${ Math.floor(Math.random() * 255) },`
                colors[i] += `${ Math.floor(Math.random() * 255) },)`
            }
        } else if (type === "hex") {
            for (let i = 0; i < arrLength; i++) {
                colors[i] = "#";
                for (k = 0; k < 6; k++) {
                    colors[i] += chars[Math.floor(Math.random() * chars.length)];
                }
            }
        }
        return colors;
    }
]
//8
[
    function shuffleArray(arr) {
        let newArr = [];
        for (let i = 0; i < arr.length; i++) {
            let rand = Math.floor(Math.random() * arr.length - 1);
            if (arr.indexOf(rand) !== -1 && !newArr.includes(arr[rand])) {
                newArr.push(arr[rand]);
            }
        }
        return newArr
    }
]
//9
[
    function factorial(num) {
        let factorial = 1;
        for (let i = num; i > 0; i--) {
            factorial *= i;
        }
        return factorial;
    }
]
//10
[
    function isEmpty(val) {
        if (val === undefined) {
            return `it's empty`
        } else {
            return `not empty`
        }
    }
]
//11
[
    function sum(...args) {
        let sum = 0;
        args.forEach(function (arg) {
            sum += arg
        })
        return sum;
    }
]
//12
[
    function sumOfArrayItems(arr) {
        let sum = 0;
        arr.forEach(function (ar) {
            if (typeof ar === "number") {
                sum += ar
            } else {
                sum = `it's a string`
            }
        })
        return sum;
    }
]
//13
[
    function average(arr) {
        let sum = 0;
        arr.forEach(function (ar) {
            if (typeof ar === "number") {
                sum += ar;
                sum = arr.length / sum;
            } else {
                sum = `it's a string`;
            }
        })
        return sum;
    }
]
//14
[
    function modifyArray(arr) {
        if (arr.length >= 6) {
            for (let i = 0; i < arr.length; i++) {
                if (i = 5) {
                    arr.splice(5)
                }
            }
            return arr
        } else {
            return `item not found`
        }
    }
]
//15
[
    function isPrime(num) {
        for (let i = 2; i < num; i++) {
            if (num % i === 0 && num > 1) {
                return `${num} is a prime number`;
            } else {
                return `not prime`
            }
        }
    }
]
//16
[

]
//17
[

]
//18
[

]
//19
[

]
//20
[

]
//21
[
    function reverseCountries() {
        let countries = ["Spain", "U.S.A", "France", "Canada", "Italy"];
        return countries.reverse();
    }
]