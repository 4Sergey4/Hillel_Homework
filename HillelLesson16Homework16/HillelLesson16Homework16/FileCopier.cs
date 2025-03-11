using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson16Homework16
{
    public class FileCopier
    {
        public string inputPath { get; set; }
        public string outputPath { get; set; }

        public FileCopier(string inPath, string outPath)
        {
            inputPath = inPath;
            outputPath = outPath;
        }

        public void CopyFile()
        {
            try
            {
                if(File.Exists(inputPath))
                {
                    File.Copy(inputPath, outputPath);
                    Console.WriteLine("Інформацію скопійовано");
                }
                else
                {
                    Console.WriteLine("Файл не знайдено");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }
        }
        public string GetInputPath(string input)
        {
            inputPath = input;
            return inputPath;
        }

        public string GetOutputPath(string output)
        {
            outputPath = output;
            return outputPath;
        }
    }
}
