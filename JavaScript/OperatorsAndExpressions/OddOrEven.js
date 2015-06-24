//01. Odd or Even
console.log('01. Odd or Even');

var numberToChek= [3,2,-2,-1,0]; // <-replace your numbers here

for(var i =0;i<numberToChek.length;i++){
    if(numberToChek[i]%2==0){

        console.log("number: "+numberToChek[i]+" is even")
    }
    else{

        console.log("number: "+numberToChek[i]+ " is odd")
    }
}
console.log('\n');
//02. Divisible by 7 and 5
console.log('02. Divisible by 7 and 5');

var divBy7and5 = [3,0,5,7,35,140]; // <-replace your numbers here

for (var i = 0; i < divBy7and5.length; i++) {

    if ((divBy7and5[i]%5==0)&&(divBy7and5[i]%7==0) ) {
    
    console.log("YES! Number: "+divBy7and5[i]+ " can be divided (without remainder) by 7 and 5 in the same time.");
    }
    else{

        console.log("NO! Number: "+divBy7and5[i]+ " can't be divided (without remainder) by 7 and 5 in the same time.");
    }
}
console.log('\n');
//03. Rectangle area

console.log('03. Rectangle area');

var widths=[3,2.5,5]; // <-replace your numbers here

var heights=[4,3,5]; // <-replace your numbers here

if (widths.length!=heights.length) { 
console.log('Please enter the same count of values for width and height');
} 

for (var i = 0;i <widths.length ; i++) {

    var rectangeArea= widths[i]*heights[i];
    console.log("Area of the rectange with width: "+widths[i]+" and height: "+heights[i]+" is: "+rectangeArea);
}
console.log('\n\n');

//04. Third digit

console.log('04. Third digit');

var thirdDigitNuber=[5,701,1732,9703,877,777877,9999799]; // <-replace your numbers here

for (var i = 0; i < thirdDigitNuber.length; i++) {

    var currentNumber=thirdDigitNuber[i];

    thirdDigitNuber[i]/=100;
    if ((thirdDigitNuber[i]%10|0)==7) {
    console.log('Third digit (right-to-left) of the number '+currentNumber+' is 7: '+true);
    }
    else{
        console.log('Third digit (right-to-left) of the number '+currentNumber+' is 7: '+false);
    }
}
console.log('\n\n');

//05. Third bit

console.log('05. Third bit');
var num = [5,8,0,15,5343,62241]; // <-replace your numbers here

for (var i = 0;i <num.length; i++) {
var currentNumber=num[i];
    var p =3;
    var n = num[i];
    var mask=1<<p;
    var nAndMask=n&mask;
    var bit= nAndMask>>p;
    console.log('Third bit of the number: '+currentNumber+' is: '+bit);
}

console.log('\n\n');

//06. Point in Circle

console.log('06. Point in Circle');

var x=[0,-5,-4,1.5,-4,100,0,0.2,0.9,2] // <-replace your numbers here
var y=[1,0,5,-3,-3.5,-30,0,-0.8,-4.93,2.655] // <-replace your numbers here
 var r=5;

for (var i = 0; i < x.length; i++) {
    var isInCircle = (Math.pow(x[i], 2) + Math.pow(y[i], 2)) <= r*r;
    console.log('Point with coordinates x: '+x[i]+' and y: '+y[i]+' is in the circle: '+isInCircle);
}

console.log('\n\n');

//07.Is prime

console.log('07. Is prime');

var number=[1,2,3,4,9,37,97,51,-3,0]; // <-replace your numbers here
for (var i = 0; i <number.length ; i++) {

    if (number[i] <= 1 || number[i] > 100) {
        console.log('number: ' + number[i] + ' is prime ' + false);
    }
    else {
        if (( number[i] == 2 || number[i] == 3 || number[i] == 5 || number[i] == 7) ||
            (number[i] % 2 != 0 && number[i] % 3 != 0 && number[i] % 5 != 0 && number[i] % 7 != 0)) {
            console.log('number: ' + number[i] + ' is prime ' + true);
        }
        else {
            console.log('number: ' + number[i] + ' is prime ' + false);
        }
    }
}

console.log('\n\n');

//08. Trapezoid area

console.log('08. Trapezoid area');

var a = [5,2,8.5,100,0.222]; // <-replace your numbers here
var b = [7,1,4.3,200,0.333]; // <-replace your numbers here
var h = [12,33,2.7,300,0.555]; // <-replace your numbers here

for (var i = 0; i < a.length ; i++) {

    var area=((a[i]+b[i])/2)*h[i];
    console.log("trapezoid's area with side a="+a[i]+" side b="+b[i]+" and height h="+h[i]+" is: "+area);
}

console.log('\n\n');



//09. Point in Circle and outside Rectangle

console.log('09. Point in Circle and outside Rectangle');

var XY = 1.0;
var radius = 3;
var horizontal = [1,3,0,4,2,4,2.5,3.5,-100];
var vertical = [4,2,1,1,0,0,1.5,1.5,-100];

for (var i = 0; i < horizontal.length ; i++) {

    for (var j = 0; j < horizontal.length ; j++) {
        XY=1.0;
        radius=3;
        var isInsideCircle = (Math.pow((horizontal[i] - XY), 2) + Math.pow((vertical[i] - XY), 2)) <= radius * radius;
    }

    var topV = 1.0;
    var leftH = -1.0;
    var bottomV = -1.0;
    var rightH = 5.0;

var isOutsideRectangle;

if (!((horizontal[i] >= leftH && horizontal[i] <= rightH) && (vertical[i] <= topV && vertical[i] >= bottomV))){
    isOutsideRectangle = true;
}
else{
    isOutsideRectangle = false;
}

if (isInsideCircle && isOutsideRectangle){
    console.log('x: '+horizontal[i]+' y: '+vertical[i]+' inside K & outside of R: Yes');
}
else{
    console.log('x: '+horizontal[i]+' y: '+vertical[i]+' inside K & outside of R: NO');
}
}


