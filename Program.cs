using System;
using System.IO;

namespace studentData
{
    internal class Program
    {
        private static string FilePath = "E:\\Visual studio 2022 Env\\StudentData\\StudentData\\student_data.txt";

        private static void ManageStudentData()
        {
            if (File.Exists(FilePath))
            {
                ReadFileContent();
            }
            else
            {
                CreateFileWithDefaultContent();
            }
        }

        private static void ReadFileContent()
        {
            try
            {
                string fileContent = File.ReadAllText(FilePath);
                Console.WriteLine("File exists, content:\n" + fileContent);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error reading the file: " + e.Message);
            }
        }

        private static void CreateFileWithDefaultContent()
        {
            try
            {
                using (StreamWriter sw = File.CreateText(FilePath))
                {
                    sw.WriteLine("Student Data\nRoll Number\tStudent Name");
                    Console.WriteLine("File did not exist, created with default content.");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error creating the file: " + e.Message);
            }
        }

        private static void Main(string[] args)
        {
            ManageStudentData();
        }
    }
}
