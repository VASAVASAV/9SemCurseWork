using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProcessor
{
    static partial class Matrixes
    {
        public static double[,] TensorProduct(double[,] Target1, double [,] Target2, bool MixFirstDimension, bool MixSecondDimension)
        {
            int Size11 = Target1.GetUpperBound(0) + 1;
            int Size21 = Target2.GetUpperBound(0) + 1;
            int Size12 = Target1.GetUpperBound(1) + 1;
            int Size22 = Target2.GetUpperBound(1) + 1;
            return new double[,] { { 1 } };
        }
    }
}
