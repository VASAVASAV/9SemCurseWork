using MainImageProcessor;
using MatrixProcessor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            AddKernel(new BSplain.SplainInstance(1d / 8, new double[,] { { 1, 6, 1 } }, "Згладжуючий S(2,0)"));
        }

        List<double[,,]> WorkingImage = new List<double[,,]>();
        private List<BSplain.SplainInstance> Kernels = new List<BSplain.SplainInstance>();
        int CurrentKernel=-1;
        string ImageName="";

        private void наКрокНазадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingImage.Count == 0)
                return;
            WorkingImage.RemoveAt(WorkingImage.Count-1);
            OutputBitmapOnPictureBox(BitmapConverter.DoubleRgbToBitmap(WorkingImage[WorkingImage.Count-1]));
        }

        private void доПочатковогоСтануToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WorkingImage.Count <2)
                return;
            WorkingImage.RemoveRange(1,WorkingImage.Count-1);
            OutputBitmapOnPictureBox(BitmapConverter.DoubleRgbToBitmap(WorkingImage[WorkingImage.Count - 1]));
        }

        private void AddKernel(BSplain.SplainInstance Kernel)
        {
            if (!listBox1.Items.Contains(Kernel.Name))
            {
                listBox1.Items.Add(Kernel.Name);
                listBox2.Items.Add(Kernel.Name);
                listBox3.Items.Add(Kernel.Name);
            }
            else
            {
                int i = 1;
                while (listBox1.Items.Contains(Kernel.Name + "(" +i+")"))
                {
                    i++;
                }
                Kernel.Name += "(" + i + ")";
                listBox1.Items.Add(Kernel.Name);
                listBox2.Items.Add(Kernel.Name);
                listBox3.Items.Add(Kernel.Name);
            }
            Kernels.Add(Kernel);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int Number = listBox1.SelectedIndex;
            textBox1.Text = ""+Kernels[Number].Multiplier;
            textBox2.Text = "" + Kernels[Number].Name;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            int S1 = Kernels[Number].MatrixForm.GetUpperBound(0)+1;
            int S2 = Kernels[Number].MatrixForm.GetUpperBound(1)+1;
            for (int i = 0; i < S2; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
            }
            for (int i = 0; i < S1; i++)
            {
                dataGridView1.Rows.Add();
            }
            for (int i = 0; i < S1; i++)
            {
                for (int j = 0; j < S2; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = "" + Kernels[Number].MatrixForm[i, j];
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < BSplain.StartSplines.OneDimSplainStarterPack.Count; i++)
            {
                AddKernel(BSplain.StartSplines.OneDimSplainStarterPack[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var j = Matrixes.TensorProduct(
                       new double[,]
                       {
                            { 1,6,1}
                       },
                       Matrixes.GetTransp(new double[,]
                       {
                            { 1,6,1}
                       }),false);
            for (int i = 0; i < BSplain.StartTwoDimSplains.TwoDimSplainStarterPack.Count; i++)
            {
                AddKernel(BSplain.StartTwoDimSplains.TwoDimSplainStarterPack[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplyKernel(Kernels[listBox1.SelectedIndex]);
        }

        void ApplyKernel(BSplain.SplainInstance target)
        {
            if (WorkingImage.Count < 1)
            {
                LogOutputTextBox.Text += "Спочатку виберіть зображення";
                return;
            }
            int height = WorkingImage[WorkingImage.Count - 1].GetUpperBound(1) + 1;
            int width = WorkingImage[WorkingImage.Count - 1].GetUpperBound(2) + 1;
            double[,,] result = new double[3, height,width];

            int filterWidth = target.MatrixForm.GetUpperBound(1)+1;
            int filterHeight = target.MatrixForm.GetUpperBound(0)+1;
            int ShortSide1 = (int)((filterHeight - 1d) / 2);
            int ShortSide2 = (int)((filterHeight - 1d) / 2);
            int LongSide1 = (int)Math.Ceiling((filterHeight - 1d) / 2);
            int LongSide2 = (int)Math.Ceiling((filterHeight - 1d) / 2);

                for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    double pixelR = 0;
                    double pixelG = 0;
                    double pixelB = 0;

                    int StartY = y - ShortSide1;
                    int StartX = x - ShortSide2;

                    for (int FX = 0; FX < filterWidth; FX++)
                    {
                        for (int FY = 0; FY < filterHeight; FY++)
                        {
                            int xx = StartX + FX;
                            int yy = StartY + FY;

                            if (xx < 0)
                                xx = 0;


                            if (yy < 0)
                                yy = 0;

                            if (xx >= width)
                                xx = width-1;


                            if (yy >= height)
                                yy = height-1;

                            pixelR += WorkingImage[WorkingImage.Count-1][0, yy, xx] * target.MatrixForm[FY,FX]*target.Multiplier;
                            pixelG += WorkingImage[WorkingImage.Count-1][1, yy, xx] * target.MatrixForm[FY,FX]*target.Multiplier;
                            pixelB += WorkingImage[WorkingImage.Count-1][2, yy, xx] * target.MatrixForm[FY,FX]*target.Multiplier;
                        }
                    }

                    result[0, y, x] = pixelR;
                    result[1, y, x] = pixelG;
                    result[2, y, x] = pixelB;
                }
            }
            WorkingImage.Add(result);
            RefreshImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num1 = listBox2.SelectedIndex;
            int num2 = listBox3.SelectedIndex;
            AddKernel
            (new BSplain.SplainInstance
                (
                Kernels[num1].Multiplier * Kernels[num2].Multiplier,
                (checkBox1.Checked) ?
                (Matrixes.TensorProduct(Kernels[num1].MatrixForm, Matrixes.GetTransp(Kernels[num2].MatrixForm),false))
                : Matrixes.TensorProduct(Kernels[num1].MatrixForm,Kernels[num2].MatrixForm, true),
                (textBox3.Text=="")?("Нове ядро"): textBox3.Text)
            );
        }
    }
}
