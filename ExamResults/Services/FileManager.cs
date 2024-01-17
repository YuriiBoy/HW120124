using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExamResults.Services
{
    internal class FileManager
    {
        private readonly string path;

        public FileManager()
        {
            path = @"..\..\Data\Matrix.txt";
        }
        public int[][] MatrixFromFile()
        {
            string text = string.Empty;
            using (var fs = new FileStream(path, FileMode.Open))
            using (var sr = new StreamReader(fs))
                text = sr.ReadToEnd();

            string[] rowMarks = text.Split('\n');
            Array.Resize(ref rowMarks, rowMarks.Length - 1);
            int rows = rowMarks.Length;
            int [][] matrix = new int[rows][];
            int cols = 0;
            for (int i = 0; i < rows; i++)
            {
                string[] marks = rowMarks[i].Split(' ');
                if(i == 0)
                    cols = marks.Length;

                matrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = Convert.ToInt32(marks[j]);
                }
            }
            return matrix;
        }
        public string[] ReadData(string fileName)
        {
            string text = string.Empty;
            using(var fs = new FileStream(fileName, FileMode.Open))
                using (var sr = new StreamReader(fs))
                text = sr.ReadToEnd();

            string[] parts = text.Trim().Split('\n'); 
            
           return parts;
        }
    }
}
