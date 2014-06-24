using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Point3D
{
    public static class PathStorage
    {
        public static void SavePath(Path currentPath,string saveFilePath)
        {
            StreamWriter writer = new StreamWriter(saveFilePath);
            
            using (writer)
            {
                foreach (var item in currentPath.PathList)
                {
                    writer.WriteLine(item);
                }
            }
        }
        public static Path LoadPath(string filePath)
        {
            Path path = new Path();
            if (!(File.Exists(filePath)))
            {
                throw new FileNotFoundException("The file does not exist!");
            }
            StreamReader reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            while (line != null || (!(String.IsNullOrWhiteSpace(line))))
            {
                string[] coordinates = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                
                Point3D point = new Point3D();
                point.PointX = int.Parse(coordinates[0]);
                point.PointY = int.Parse(coordinates[1]);
                point.PointZ = int.Parse(coordinates[2]);
                path.AddPath(point);

                line = reader.ReadLine();
            }
            return path;
        }
    }
}
