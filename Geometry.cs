static class Geometry
{
    public static double CalcCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double CalcCirclePerimeter(double radius)
    {
        return 2 * Math.PI * radius;
    }

    public static double CalcRectangleArea(double length, double width)
    {
        return length * width;
    }

    public static double CalcRectanglePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }

    public static double CalcTriangleArea(double baseSide, double height)
    {
        return 0.5 * baseSide * height;
    }

    public static double CalcTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }
}