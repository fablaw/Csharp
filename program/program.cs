using System;
using System.IO;

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string topPath="/Users/fabianlaw/code/C#/Csharp/program";
      Directory.CreateDirectory(topPath+"/testEduGroupe");

      bool directoryExists=Directory.Exists(topPath+"/testEduGroupe");
      /*
      if (directoryExists)
      {
        Console.WriteLine("The directory exists already");
      }

      for (int i=0;i<10;i++)
      {
        File.Create(topPath+$"/testEduGroupe/test{i}.txt");
      }

      string[] names=new string[]{"toto","tata","tutu"};
      for (int j=0;j<names.Length;j++)
      {
        File.Create(topPath+$"/testEduGroupe/{names[j]}.txt");
      }

      string[] arrFiles=Directory.GetFiles(topPath);
      string[] arrDirectory=Directory.GetDirectories(topPath);
      foreach (string file in arrFiles)
      {
        Console.WriteLine(file);
      }
      Console.WriteLine("==================================");
      foreach (string dk in arrDirectory)
      {
        Console.WriteLine(dk);
      }
      Console.WriteLine(arrDirectory.Length);
      Console.WriteLine(arrDirectory[0]);

      if (arrFiles.Length==0)
      {
        Console.WriteLine($"There are no files in {topPath}");
      }
      else
      {
        Console.WriteLine($"These files exist in {topPath}.");
        foreach (string filename in arrFiles)
        {
          if (filename.EndsWith(".txt"))
          {
            Console.WriteLine(Path.GetFileNameWithoutExtension(filename));
          }
        }
      }
      foreach (string dk in arrDirectory)
      {
        Console.WriteLine($"These files exist in {dk}.");
        string[] subfiles=Directory.GetFiles(dk);
        foreach (string subfile in subfiles)
        {
          if (subfile.EndsWith(".txt"))
          {
            Console.WriteLine(Path.GetFileNameWithoutExtension(subfile));
          }
        }
        string[] subdk=Directory.GetDirectories(dk);
        if (subdk.Length==0)
        {
          Console.WriteLine($"There are no subdirectories in {dk}.");
        }
      }*/
      foreach (string file in Directory.EnumerateFiles(topPath, "*.txt", SearchOption.AllDirectories))
      {
        Console.WriteLine(Path.GetFileNameWithoutExtension(file));
      }
    }
  }
}
