/*
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */
console.log('Problem 1. Planar coordinates');

var p1,
    p2,
    p3,
    p4,
    p5,
    p6,
    line1,
    line2,
    line3;

function createPoint(x, y) {
    return {
        x: x,
        y: y
    };
}

function createLine(point1, point2) {
    return {
        startPoint: point1,
        endPoint: point2,
        length: calculateDistance(point1, point2)
    };
}

function calculateDistance(point1, point2) {
    var distance = Math.sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
    return distance;
}

function canFormTriangle(line1, line2, line3) {
    if ((line1.length + line2.length > line3.length) &&
        (line1.length + line3.length > line2.length) &&
        (line2.length + line3.length > line1.length)) {
        return true;
    } else {
        return false;
    }
}
p1 = createPoint(1, 2);
p2 = createPoint(2, 10);
p3 = createPoint(5, 11);
p4 = createPoint(6, 16);
p5 = createPoint(7, 17);
p6 = createPoint(8, 15);

var pointsArr=[p1,p2,p3,p4,p5,p6];

pointsArr.forEach(function(p,index){
    console.log('p'+index+' ('+ p.x+', '+p.y+')');

})

line1 = createLine(p1, p2);
line2 = createLine(p3, p4);
line3 = createLine(p5, p6);

console.log('line1' +'(('+p1.x+','+p1.y+'),('+p2.x+','+p2.y+'))');
console.log('line2' +'(('+p3.x+','+p3.y+'),('+p4.x+','+p4.y+'))');
console.log('line3' +'(('+p5.x+','+p5.y+'),('+p6.x+','+p6.y+'))');
formTriangle = canFormTriangle(line1, line2, line3);
console.log('Can form a triangle -> ' + formTriangle);
console.log('\n')