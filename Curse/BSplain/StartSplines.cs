using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSplain
{
    public static class StartSplines
    {
        public static List<SplainInstance> OneDimSplainStarterPack = new List<SplainInstance>();
        static StartSplines()
        {
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 48,
                        new double[,]
                        {
                            { -1,2,46,2,-1}
                        },
                        "Згладжуючий S(2,1)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 288,
                        new double[,]
                        {
                                        { 1,-4,-5,304,-5,-4,1}
                        },
                        "Згладжуючий S(2,2)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d/6,
                        new double[,]
                        {
                            { 1,4,1}
                        },
                        "Згладжуючий S(3,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 144,
                        new double[,]
                        {
                            { -5,14,126,14,-5}
                        },
                        "Згладжуючий S(3,1)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 6912,
                        new double[,]
                        {
                            { 47,-240,249,6800,249,-240,47}
                        },
                        "Згладжуючий S(3,2)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 384,
                        new double[,]
                        {
                            { 1,76,230,76,1}
                        },
                        "Згладжуючий S(4,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 120,
                        new double[,]
                        {
                            { 1,26,66,26,1}
                        },
                        "Згладжуючий S(5,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 8,
                        new double[,]
                        {
                            { -1,2,-1}
                        },
                        "Високочастотний S(2,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 6,
                        new double[,]
                        {
                            { -1,2,-1}
                        },
                        "Високочастотний S(3,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 384,
                        new double[,]
                        {
                            { -1,-76,154,-76,-1}
                        },
                        "Високочастотний S(4,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 120,
                        new double[,]
                        {
                            { -1,-26,54,-26,-1}
                        },
                        "Високочастотний S(5,0)"
                    )
                );
            ///////
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 8,
                        new double[,]
                        {
                            { 1,-8,48,-8,1}
                        },
                        "Контрастний S(2,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 6,
                        new double[,]
                        {
                            { 1,-6,24,-6,1}
                        },
                        "Контрастний S(3,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 384,
                        new double[,]
                        {
                            { -0.00067154,-0.04892947,0.25787256,-0.80938034,2.20221768,-0.80938034,0.25787256,-0.04892947,-0.00067154}
                        },
                        "Контрастний S(4,0)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d / 120,
                        new double[,]
                        {
                             { -609, -14144,73080,-202800,449520,-202800,73080,-14144,609}
                        },
                        "Контрастний S(5,0)"
                    )
                );
            /////////////
            OneDimSplainStarterPack.Add
            (
                new SplainInstance
                (
                    1d / 3136,
                    new double[,]
                    {
                            { 1,8,-74,8,1}
                    },
                    "Стабілізуючий γ(0)"
                )
            );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d ,
                        new double[,]
                        {
                             { 6.12745461019500331312e-5, 8.93587e-02/6.12745461019500331312, 5.40282e-01/6.12745461019500331312, -7.38748/6.12745461019500331312,5.40282e-01/6.12745461019500331312,8.93587e-02/6.12745461019500331312,6.12745461019500331312e-5}
                        },
                        "Стабілізуючий γ(1)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d ,
                        new double[,]
                        {
                             { 1.1160734742838394329222428846644e-4, 2.96456e-06/1.1160734742838394329222428846644e-4, 1.59314e-05/1.1160734742838394329222428846644e-4, -0.000149424/1.1160734742838394329222428846644e-4,1.59314e-05/1.1160734742838394329222428846644e-4, 2.96456e-06/1.1160734742838394329222428846644e-4,1.1160734742838394329222428846644e-4}
                        },
                        "Стабілізуючий γ(2)"
                    )
                );
            OneDimSplainStarterPack.Add
                (
                    new SplainInstance
                    (
                        1d,
                        new double[,]
                        {
                             { 1.27420563489571e-5, 4.1165e-03/1.27420563489571, 9.20847e-02/1.27420563489571, 2.14132e-01/1.27420563489571, -1.8949/1.27420563489571, 2.14132e-01/1.27420563489571,9.20847e-02/1.27420563489571,4.1165e-03/1.27420563489571,1.6236e-5/1.27420563489571}
                        },
                        "Стабілізуючий γ(3)"
                    )
                );
            OneDimSplainStarterPack.Add
               (
                   new SplainInstance
                   (
                       1d ,
                       new double[,]
                       {
                             { 2.293854834116579400e-5, 1.32248e-02/2.293854834116579400, 2.7676e-01/2.293854834116579400, 4.92362e-01/2.293854834116579400, -3.85865/2.293854834116579400, 4.92362e-01/2.293854834116579400,2.7676e-01/2.293854834116579400,1.32248e-02/2.293854834116579400,5.26177e-5/2.293854834116579400}
                       },
                       "Стабілізуючий γ(4)"
                   )
               );
        }

    }
}
