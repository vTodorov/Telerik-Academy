/*
 Problem 1. Make person

 Write a function for creating persons.
 Each person must have firstname, lastname, age and gender (true is female, false is male)
 Generate an array with ten person with different names, ages and genders
 */

console.log('Problem 1. Make person');

var person,
    female;

function makePerson(firstName, lastName, age, gender) {

    var isMale = '';

    if (gender == false) {
        isMale = 'male';
    }
    else(
        isMale = 'female'
    )
    return {
        firstName: firstName,
        lastName: lastName,
        age: age,
        gender: isMale
    };
}


var maleFirstNames = ['Pesho', 'Gosho', 'Tosho', 'Atanas', 'John', 'Stamat'];
var maleLastNames = ['Peshov', 'Goshov', 'Toshov', 'Atanasov', 'Stamatov'];
var femaleFirstNames = ['Penka', 'Genka', 'Atanaska', 'Mariq', 'Jennifer'];
var femaleLastNames = ['Peshova', 'Atanasova', 'Georgieva', 'Todorova'];

var maleArr = [],
    femaleArr = [],
    allPersonsArr = [];

for (var i = 0; i < 5; i += 1) {

    person = makePerson(maleFirstNames[(Math.random() * maleFirstNames.length) | 0], maleLastNames[(Math.random() * maleLastNames.length) | 0], (Math.random(5, 10) * 100 | 0), false);
    maleArr.push(person);

}

for (var i = 0; i < 5; i += 1) {

    female = makePerson(femaleFirstNames[(Math.random() * femaleFirstNames.length) | 0], femaleLastNames[(Math.random() * femaleLastNames.length) | 0], (Math.random(5, 10) * 100 | 0), true);
    femaleArr.push(female);
}

allPersonsArr = maleArr.concat(femaleArr);


for (var i = 0, len = allPersonsArr.length; i < len; i += 1) {
    console.log(allPersonsArr[i]);
}
console.log('\n');

/*
 Problem 2. People of age

 Write a function that checks if an array of person contains only people of age (with age 18 or greater)
 Use only array methods and no regular loops (for, while)
 */

console.log('Problem 2. People of age');

var adults = allPersonsArr.every(function (person) {

        return person.age > 18;
    }
)

console.log('All persons has age 18+: ' + adults);
console.log('\n');
/*
 Problem 3. Underage people

 Write a function that prints all underaged persons of an array of person
 Use Array#filter and Array#forEach
 Use only array methods and no regular loops (for, while)
 */

console.log('Problem 3. Underage people');

var underage = allPersonsArr.filter(function (person) {
        return person.age < 18;
    }
)
underage.forEach(function (person) {
    console.log('First name: ' + person.firstName + '  Last name: ' + person.lastName + '  Age: ' + person.age);

})
console.log('\n');

/*
 Problem 4. Average age of females

 Write a function that calculates the average age of all females, extracted from an array of persons
 Use Array#filter
 Use only array methods and no regular loops (for, while)
 */

console.log('Problem 4. Average age of females');



var femalesOnly = allPersonsArr.filter(function(person){

    return person.gender=='female';
})
var sumAgeFemales=femalesOnly.reduce(function(sum,person){
    return sum+person.age;
},0)
var avgAgeFemales = sumAgeFemales/femalesOnly.length;

console.log('Average age of females: '+avgAgeFemales);
console.log('\n');


/*
 Problem 5. Youngest person

 Write a function that finds the youngest male person in a given array of people and prints his full name
 Use only array methods and no regular loops (for, while)
 Use Array#find
 */
console.log('Problem 5. Youngest person');

var min= Number.MAX_VALUE,
    number;
var males=allPersonsArr.filter(function(person){return (person.gender=='male')});
males.forEach(function(person){if(person.age<min){min=person.age;}});

if(!Array.prototype.find){
    Array.prototype.find=function(callback){
        var i,
            len;
        for(i=0;len=this.length, i<len;i+=1){
            if(callback(this[i],i,this)){
                return this[i];
            }
        }
        return undefined;
    };
}

youngestMale=males.find(function(person){return person.age==min;});
console.log('Youngest male: '+youngestMale.firstName+' '+youngestMale.lastName);
console.log('\n');
/*
 Problem 6. Group people

 Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
 Use Array#reduce
 Use only array methods and no regular loops (for, while)

 */
console.log('Problem 6. Group people');
groupByname = allPersonsArr.reduce(function(grouped,person){
    if(grouped[person.firstName[0]]){
        grouped[person.firstName[0]].push(person);
    }else{
        grouped[person.firstName[0]]=[person];
    }
    return grouped;},{});
console.log('People grouped by name:');
console.log(groupByname);






