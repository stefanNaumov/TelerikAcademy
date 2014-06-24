using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Security;

namespace TextFileStreamReader
{
    class TextStreamReader
    {
        static void Main()
        {
            try
            {
                string nfo = File.ReadAllText("NFO.txt");
                Console.WriteLine(nfo);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("null", ane.Message);
            }
            catch (SecurityException)
            {
            }
        }
    }
}
