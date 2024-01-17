using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResults.Services
{
    internal class OperationManager
    {
        private readonly FileManager fileManager;
        public OperationManager()
        {
            fileManager = new FileManager();
        }

        public void DisplayData()
        {
            int[][] X = fileManager.MatrixFromFile();
            Console.WriteLine();
            foreach (var row in X)
            {
                foreach (var mark in row)
                {
                    Console.Write($"  {mark}");
                }
                Console.WriteLine();
            }
        }
        //public void AveBySubject()
        //{

        //    double ave1 = 0;
        //    double ave2 = 0;
        //    double ave3 = 0;
        //    double ave4 = 0;
        //    int[][] X = fileManager.MatrixFromFile();
            
        //    for (int i = 0; i < X.Length; i++)
        //    {
        //            ave1 += X[i][0];
        //            ave2 += X[i][1];
        //            ave3 += X[i][2];
        //            ave4 += X[i][3];
        //    }
        //    Console.WriteLine($" {ave1 / X.Length}, {ave2 / X.Length}, {ave3 / X.Length}, {ave4 / X.Length}");
            
        //}

        public void AveSubject()
        {                     
            int[][] X = fileManager.MatrixFromFile();
            double[] ave = new double[X.Length];
            for (int i = 0; i < X.Length; i++)
            {    
                for (int j = 0; j < X[i].Length; j++)
                    ave[i] += X[j][i];              
            }
            foreach (var item in ave)
                Console.Write($" {item / X.Length}");
        }

        public void DisplaySubjStud(string[] S)
        {
           foreach(var item in S)
            {
                Console.WriteLine(item);
            }
         
        }

        public void AveMarks()
        {
            int[][] X = fileManager.MatrixFromFile();
            int[] sumMarks = new int[X.Length];
            double counter = 0.0;
            for (int i = 0; i < X.Length; i++)
            {
                for (int j = 0; j < X[i].Length; j++)
                {
                    sumMarks[i] += X[i][j];
                    
                }
                counter++;
            }
            foreach (var item in sumMarks)
                Console.WriteLine($" {item / counter}");
        }

    }
}
