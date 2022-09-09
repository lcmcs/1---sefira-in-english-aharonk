using System;
using System.IO;
using EnglishSefirah;

namespace ConsoleAppTemplate
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var projectDir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\.."));
            File.WriteAllLines(projectDir + "/SefirahEnglish.txt", Sefirah.GetFullEnglishSefira());
        }
    }
}