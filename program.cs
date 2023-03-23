using System;
using System.IO;

namespace ConsoleApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string topPath=@"/Users/fabianlaw/code/C#/Csharp/program";
      Directory.CreateDirectory(topPath+@"/testEduGroupe");

      bool directoryExists=Directory.Exists(topPath+@"/testEduGroupe");

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
    }
  }
}
