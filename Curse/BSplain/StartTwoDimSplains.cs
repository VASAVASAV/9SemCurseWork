using MatrixProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSplain
{
    public static class StartTwoDimSplains
    {
        public static List<SplainInstance> TwoDimSplainStarterPack = new List<SplainInstance>();
        static StartTwoDimSplains()
        {
            TwoDimSplainStarterPack.Add
               (
                   new SplainInstance
                   (
                       1d / (8*8),
                       Matrixes.TensorProduct(
                       new double[,]
                       {
                            { 1,6,1}
                       },
                       Matrixes.GetTransp(new double[,]
                       {
                            { 1,6,1}
                       }),false),
                       "Двовим. Згладжуючий S(2,0)"
                   )
               );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (48*48),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,-4,-5,304,-5,-4,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,-4,-5,304,-5,-4,1}
                        }), false),
                        "Двовим. Згладжуючий S(2,1)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (288*288),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,-4,-5,304,-5,-4,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,-4,-5,304,-5,-4,1}
                        }), false),
                        "Двовим. Згладжуючий S(2,2)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 36,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,4,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,4,1}
                        }), false),
                        "Двовим. Згладжуючий S(3,0)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (144*144),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { -5,14,126,14,-5}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { -5,14,126,14,-5}
                        }), false),
                        "Двовим. Згладжуючий S(3,1)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (6912 * 6912),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 47,-240,249,6800,249,-240,47}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 47,-240,249,6800,249,-240,47}
                        }), false),
                        "Двовим. Згладжуючий S(3,2)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (384*384),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,76,230,76,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,76,230,76,1}
                        }), false),
                        "Двовим. Згладжуючий S(4,0)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (120*120),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,26,66,26,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                            { 1,26,66,26,1}
                        }), false),
                        "Двовим. Згладжуючий S(5,0)"
                    )
                );
            ///////
            TwoDimSplainStarterPack.Add
               (
                   new SplainInstance
                   (
                       1d / (8 * 8),
                       Matrixes.TensorProduct(
                       new double[,]
                       {
                            { 1,6,1}
                       },
                       Matrixes.GetTransp(new double[,]
                       {
                            { 1,6,1}
                       }), false),
                       "Двовим. Високочастотний S(2,0)"
                   )
               );
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[i,j] *= -1;
                }
            }
            TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[1, 1] = 28;
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 36,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,4,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,4,1}
                        }), false),
                        "Двовим. Високочастотний S(3,0)"
                    )
                );
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[i, j] *= -1;
                }
            }
            TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[1, 1] = 20;
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (144 * 144),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { -5,14,126,14,-5}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { -5,14,126,14,-5}
                        }), false),
                        "Двовим. Високочастотний S(3,1)"
                    )
                );
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[i, j] *= -1;
                }
            }
            TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[2, 2] = 4860;
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (6912 * 6912),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 47,-240,249,6800,249,-240,47}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 47,-240,249,6800,249,-240,47}
                        }), false),
                        "Двовим. Високочастотний S(3,2)"
                    )
                );
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[i, j] *= -1;
                }
            }
            TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[3, 3] = 1535744;
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (384 * 384),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,76,230,76,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,76,230,76,1}
                        }), false),
                        "Двовим. Високочастотний S(4,0)"
                    )
                );
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[i, j] *= -1;
                }
            }
            TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[2, 2] = 94556;
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (120 * 120),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,26,66,26,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                            { 1,26,66,26,1}
                        }), false),
                        "Двовим. Високочастотний S(5,0)"
                    )
                );
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[i, j] *= -1;
                }
            }
            TwoDimSplainStarterPack[TwoDimSplainStarterPack.Count - 1].MatrixForm[2, 2] = 10044;
            ////////////////
            TwoDimSplainStarterPack.Add
            (
                new SplainInstance
                (
                    1d / (1156),
                    Matrixes.TensorProduct(
                    new double[,]
                    {
                            { 1,-8,48,-8,1}
                    },
                    Matrixes.GetTransp(new double[,]
                    {
                            { 1,-8,48,-8,1}
                    }), false),
                    "Двовим. Контрастний S(2,0)"
                )
            );
           TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 196,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1,-6,24,-6,1}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1,-6,24,-6,1}
                        }), false),
                        "Двовим. Контрастний S(3,0)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { -0.00067154,-0.04892947,0.25787256,-0.80938034,2.20221768,-0.80938034,0.25787256,-0.04892947,-0.00067154}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { -0.00067154,-0.04892947,0.25787256,-0.80938034,2.20221768,-0.80938034,0.25787256,-0.04892947,-0.00067154}
                        }), false),
                        "Двовим. Контрастний S(4,0)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / (160574),
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { -609, -14144,73080,-202800,449520,-202800,73080,-14144,609}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { -609, -14144,73080,-202800,449520,-202800,73080,-14144,609}
                        }), false),
                        "Двовим. Контрастний S(5,0)"
                    )
                );
            //////
            TwoDimSplainStarterPack.Add
            (
                new SplainInstance
                (
                    1d / (3136),
                    Matrixes.TensorProduct(
                    new double[,]
                    {
                            { 1,8,-74,8,1}
                    },
                    Matrixes.GetTransp(new double[,]
                    {
                            { 1,8,-74,8,1}
                    }), false),
                    "Двовим. Стабілізуючий γ(0)"
                )
            );
            TwoDimSplainStarterPack.Add
                 (
                     new SplainInstance
                     (
                         1d ,
                         Matrixes.TensorProduct(
                         new double[,]
                         {
                             { 6.12745461019500331312e-5, 8.93587e-02/6.12745461019500331312, 5.40282e-01/6.12745461019500331312, -7.38748/6.12745461019500331312,5.40282e-01/6.12745461019500331312,8.93587e-02/6.12745461019500331312,6.12745461019500331312e-5}
                         },
                         Matrixes.GetTransp(new double[,]
                         {
                            { 6.12745461019500331312e-5, 8.93587e-02/6.12745461019500331312, 5.40282e-01/6.12745461019500331312, -7.38748/6.12745461019500331312,5.40282e-01/6.12745461019500331312,8.93587e-02/6.12745461019500331312,6.12745461019500331312e-5}
                         }), false),
                         "Двовим. Стабілізуючий γ(1)"
                     )
                 );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1.1160734742838394329222428846644e-4, 2.96456e-06/1.1160734742838394329222428846644e-4, 1.59314e-05/1.1160734742838394329222428846644e-4, -0.000149424/1.1160734742838394329222428846644e-4,1.59314e-05/1.1160734742838394329222428846644e-4, 2.96456e-06/1.1160734742838394329222428846644e-4,1.1160734742838394329222428846644e-4}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 1.1160734742838394329222428846644e-4, 2.96456e-06/1.1160734742838394329222428846644e-4, 1.59314e-05/1.1160734742838394329222428846644e-4, -0.000149424/1.1160734742838394329222428846644e-4,1.59314e-05/1.1160734742838394329222428846644e-4, 2.96456e-06/1.1160734742838394329222428846644e-4,1.1160734742838394329222428846644e-4}
                        }), false),
                        "Двовим. Стабілізуючий γ(2)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d ,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 1.27420563489571e-5, 4.1165e-03/1.27420563489571, 9.20847e-02/1.27420563489571, 2.14132e-01/1.27420563489571, -1.8949/1.27420563489571, 2.14132e-01/1.27420563489571,9.20847e-02/1.27420563489571,4.1165e-03/1.27420563489571,1.6236e-5/1.27420563489571}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                            { 1.27420563489571e-5, 4.1165e-03/1.27420563489571, 9.20847e-02/1.27420563489571, 2.14132e-01/1.27420563489571, -1.8949/1.27420563489571, 2.14132e-01/1.27420563489571,9.20847e-02/1.27420563489571,4.1165e-03/1.27420563489571,1.6236e-5/1.27420563489571}
                        }), false),
                        "Двовим. Стабілізуючий γ(3)"
                    )
                );
            TwoDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d,
                        Matrixes.TensorProduct(
                        new double[,]
                        {
                             { 2.293854834116579400e-5, 1.32248e-02/2.293854834116579400, 2.7676e-01/2.293854834116579400, 4.92362e-01/2.293854834116579400, -3.85865/2.293854834116579400, 4.92362e-01/2.293854834116579400,2.7676e-01/2.293854834116579400,1.32248e-02/2.293854834116579400,5.26177e-5/2.293854834116579400}
                        },
                        Matrixes.GetTransp(new double[,]
                        {
                             { 2.293854834116579400e-5, 1.32248e-02/2.293854834116579400, 2.7676e-01/2.293854834116579400, 4.92362e-01/2.293854834116579400, -3.85865/2.293854834116579400, 4.92362e-01/2.293854834116579400,2.7676e-01/2.293854834116579400,1.32248e-02/2.293854834116579400,5.26177e-5/2.293854834116579400}
                        }), false),
                        "Двовим. Стабілізуючий γ(4)"
                    )
                );

        }
    }
}
