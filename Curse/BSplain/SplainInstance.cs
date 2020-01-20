using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSplain
{
    public class SplainInstance
    {
        public double Multiplier; 
        public double[,] MatrixForm;
        public string Name;
        public Func<double[,], Func<double, int, int>> DelegateForm; // delegate form of bsplain: we take matrix of image as input an return delegate which implements this splain on current matrix

        public SplainInstance()
        {
            Multiplier = 1;
            MatrixForm = new double [,] { { 1 } };
            Name = "Unspecified name";
            DelegateForm = x => { throw new Exception("Using of unspecified splain is not allowed"); };
        }

        public SplainInstance(double InputMultiplier, double[,] InputMatrixForm, string InputName)
        {
            MatrixForm = InputMatrixForm;
            Name = InputName;
            Multiplier = InputMultiplier;
            DelegateForm = WorkFiled =>
            {
                throw new Exception("Using of unspecified splain is not allowed");
            };
        }
    }
}
