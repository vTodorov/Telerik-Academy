/*
Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */


using System;
class Rectangle
{
    static void Main()
    {
        Console.WriteLine("Enter width of the rectangle");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height of the rectangle");
        double height = double.Parse(Console.ReadLine());
        double perimeter = (2 * width) + (2 * height);
        double area = width * height;
        Console.WriteLine("The perimeter of the rectangle is : " + perimeter);
        Console.WriteLine("The area of the rectangle is : " + area);
    }
}

