using MainImageProcessor;
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
        }

        List<double[,,]> WorkingImage = new List<double[,,]>();
        string ImageName;

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
    }
}
