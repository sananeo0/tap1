using tap1;

namespace HomeTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal triangle = GeometryHelper.Triangle(3, 4, 5);
            Console.WriteLine(triangle);
            decimal circlePerimeter = GeometryHelper.CirclePerimeter(5.0m);
            Console.WriteLine(circlePerimeter);
            decimal Quadrilateral = GeometryHelper.QuadrilateralArea(2, 2, 3, 3);
            Console.WriteLine(Quadrilateral);

        }
    }
}