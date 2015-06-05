using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;


class ReadFileContents
{
    static void Main()
    {
        try
        {
            string path = @"c:\test.txt"; // Your path and file here!
            StreamReader reader = new StreamReader(path);
            string fileContents = reader.ReadToEnd();
            Console.WriteLine(fileContents);
            reader.Close();
        }
        catch (FileLoadException)
        {
            Console.WriteLine("File can not be loaded.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found!");
        }
        catch (DriveNotFoundException)
        {
            Console.WriteLine("Drive not found!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Directory not found!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access error");
        }
        
    }
}

