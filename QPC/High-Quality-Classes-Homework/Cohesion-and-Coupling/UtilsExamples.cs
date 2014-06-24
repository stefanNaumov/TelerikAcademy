using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            Console.WriteLine(UtilsFileExtension.GetFileExtension("example"));
            Console.WriteLine(UtilsFileExtension.GetFileExtension("example.pdf"));
            Console.WriteLine(UtilsFileExtension.GetFileExtension("example.new.pdf"));

            Console.WriteLine(UtilsFileName.GetFileName("example"));
            Console.WriteLine(UtilsFileName.GetFileName("example.pdf"));
            Console.WriteLine(UtilsFileName.GetFileName("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}",
                Utils2D.CalcDistance(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}",
                Utils3D.CalcDistance(5, 2, -1, 3, -6, 4));

            double width = 3;
            double height = 4;
            double depth = 5;
            Console.WriteLine("Volume = {0:f2}", UtilsVolume.CalcVolume(width,height,depth));
            Console.WriteLine("Diagonal XYZ = {0:f2}", Utils3D.CalcDiagonalXYZ(width, height, depth));
            Console.WriteLine("Diagonal XY = {0:f2}", Utils2D.CalcDiagonalXY(width, height));
            Console.WriteLine("Diagonal XZ = {0:f2}", Utils2D.CalcDiagonalXZ(width, height));
            Console.WriteLine("Diagonal YZ = {0:f2}", Utils2D.CalcDiagonalYZ(width, height));
        }
    }
}
