//JavaScript10 Level 1
//1
{
    let set = new Set();
}
//2, 3 & 4
{
    let set = new Set();
    for (let i = 0; i <= 10; i++) {
        set.add(i);
    }
    console.log(set);
    set.delete(5);
    console.log(set);
    set.clear();
    console.log(set);
}
//5
{
    let names = ["Gabriel", "Joamba", "Pau", "Naim", "Alfonso"]
    let namesSet = new Set();
    names.forEach(name => {
        set.add(name)
    })
    console.log(set)
}
//6 
{
    let countries = ["nigeria", "U.S.A", "germany", "england", "italy"]
    let countriesLength = new Set();
    for (let i = 0; i < countries.length; i++){
            countriesLength.add(countries[i])
            countriesLength.add(countries[i].length);
    }
    console.log(countriesLength);
}
//Level 2
{
    let a = [ 4, 5, 8, 9]
    let b = [3, 4, 5, 7]
    let A = new Set(a);
    let B = new Set(b);

    let intersection = a.filter(num => {
        return B.has(num)
    })
    console.log(intersection)

    let union = [...a, ...b]
    console.log(union);

    let c = a.filter((num) => !B.has(num))
    let C = new Set(c)
    console.log(C)
}

//Level 3
