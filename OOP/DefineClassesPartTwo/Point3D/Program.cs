using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    class Program
    {
        static void Main()
        {
            Path path = new Path();
            Point3D currPoint = new Point3D(2, 3, 4);
            Point3D secPoint = new Point3D(15, 12, 14);
            path.AddPath(currPoint);
            path.AddPath(secPoint);
            Console.Write("Enter path of the file where the coordinates will be saved: ");
            string saveFilePath = Console.ReadLine();
            PathStorage.SavePath(path, saveFilePath);
            Console.Write("Enter path of file to load: ");
            string loadFile = Console.ReadLine();
            Path loaded = PathStorage.LoadPath(loadFile);
            foreach (var item in loaded.PathList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
