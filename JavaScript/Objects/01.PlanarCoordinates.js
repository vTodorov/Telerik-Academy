/*
 Problem 1. Planar coordinates

 Write functions for working with shapes in standard Planar coordinate system.
 Points are represented by coordinates P(X, Y)
 Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
 Calculate the distance between two points.
 Check if three segment lines can form a triangle.
 */

console.log('Problem 1. Planar coordinates');

function buildPoint(x, y) {
    return {
        x: x,
        y: y

    };

}

function buildLine(point1,point2){
    return{
        p1:point1,
        p2:point2,
        lenght:pointDistance(point1,point2)
    };

}