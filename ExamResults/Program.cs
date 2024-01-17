using ExamResults.Services;
using StringsDemo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu("Exam Results", new string[] {
                "Матриця оцінок",
                "Середнья успішність групи",
                "Середній рейтинг студентів"
            });
            var fileManager = new FileManager();
            var operManager = new OperationManager();

            menu.StartProgram();
            bool stop = false;
            do
            {
                int[][] M;
                string[] S;
                
                menu.DisplayMenu();   
                switch(menu.GetChoice())
                {
                    case 1:
                        operManager.DisplayData();
                        break;
                    case 2:
                        const string path = @"..\..\Data\Subject.txt";
                        S = fileManager.ReadData(path);
                        operManager.DisplaySubjStud(S);
                        operManager.AveSubject();                                            
                        break;
                    case 3:
                        const string path1 = @"..\..\Data\Students.txt";
                        S = fileManager.ReadData(path1);
                        operManager.DisplaySubjStud(S);
                        operManager.AveMarks();
                        break;
                    case 4: stop = true;
                        break;
                    default: Console.WriteLine("\n Wrong choice.");
                        break;
                }
                if (stop)
                    break;

            } while (menu.AllowContinue()); 
        }
    }
}
