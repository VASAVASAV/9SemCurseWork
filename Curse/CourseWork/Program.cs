using BSplain;
using System;
using System.Collections.Generic;
using MatrixProcessor;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            BSplain.SplainInstance Test = new SplainInstance();
            //double[,] First = new double [,]{ { 1, 2, 3 }, { 3, 4, 5 } };
            //double[,] Second = new double[,] { { 1,2,3,4},{ 2,3,4,5,},{ 3,4,5,6},{ 4,5,6,7},{ 5,6,7,8} };
            //double[,] First = new double[,] { { 1,2,3}, { 2,3,4}, { 4,5,6} };
            //double[,] Second = new double[,] { { 1, 2, 3 }, { 2, 3, 4 }, { 4, 5, 6 } };
            //var lol = MatrixProcessor.Matrixes.TensorProduct(First, Second, true);
            MainForm MyApplication = new MainForm();
            Application.EnableVisualStyles();
            Application.Run(MyApplication);
        }
    }
}
