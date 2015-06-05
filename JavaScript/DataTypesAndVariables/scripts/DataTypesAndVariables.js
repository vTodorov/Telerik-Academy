
// 01.JavaScript literals

var intNumber= 1,
    floatNumber=1.1,
    string = 'pesho',
    bool=true,
    object = {
        name: 'doge',
        type:'celebrity'
    },
    arr=[1,'a',2,3,6,'65'],
    functionLit= function(){
     var someFunction='Some Function';
    };

//02. Quoted text
console.log('Task 2: ');

var quotedText='"How you doin?" , Joey said';

console.log(quotedText);


//03. Typeof variables
console.log('Task 3: ');

var typeOfArr=[
    intNumber,
    floatNumber,
    string,
    bool,
    object,
    arr,
    quotedText
];
for(var i = 0;i<typeOfArr.length;i++){
    console.log("The type of "+typeOfArr[i]+" is "+typeof(typeOfArr[i]));
}

//04.Typeof null
console.log('Task 4: ');
var nullVar=null,
    unidVar=undefined;

console.log('The type of null variable is: '+typeof(nullVar)+"\n"+"The type of undefined variable is: "+typeof(unidVar));

//p