using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProcessor
{
    public static partial class Matrixes
    {
        public static double[,] TensorProduct(double[,] Target1, double [,] Target2, bool MixedDimensions)
        {
            int Size11 = Target1.GetUpperBound(0) + 1;
            int Size21 = Target2.GetUpperBound(0) + 1;
            int Size12 = Target1.GetUpperBound(1) + 1;
            int Size22 = Target2.GetUpperBound(1) + 1;
            int NewSizeFirst = (MixedDimensions) ? (Size21+ Size11-1) : (Size11 * Size21);
            int NewSizeSecond = (MixedDimensions) ? (Size22 + Size12 - 1) : (Size12 * Size22);
            double[,] result = new double[NewSizeFirst, NewSizeSecond];
            if (MixedDimensions)
            {
                int ShortSide1 = (int)((Size21 - 1d) / 2);
                int ShortSide2 = (int)((Size22 - 1d) / 2);
                int LongSide1 = (int)Math.Ceiling((Size21 - 1d) / 2);
                int LongSide2 = (int)Math.Ceiling((Size22 - 1d) / 2);
                for (int i = 0; i < Size11; i++)
                {
                    for (int j = 0; j < Size12; j++)
                    {
                        for (int k = -ShortSide1; k < LongSide1+1; k++)
                        {
                            for (int l = -ShortSide2; l < LongSide2+1; l++)
                            {
                                result[i+k+ ShortSide1,j+l+ ShortSide2] += Target1[i, j] * Target2[k + ShortSide1, l + ShortSide2];
                            }
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < Size11; i++)
                {
                    for (int j = 0; j < Size12; j++)
                    {
                        for (int k = 0; k < Size21; k++)
                        {
                            for (int l = 0; l < Size22; l++)
                            {
                                result[i * Size11 + k, j * Size12 + l] = Target1[i, j] * Target2[k, l];
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
