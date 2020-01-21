using MainImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        void RefreshImage()
        {
            OutputBitmapOnPictureBox(BitmapConverter.DoubleRgbToBitmap(WorkingImage[WorkingImage.Count-1]));
        }

        void OutputBitmapOnPictureBox(Bitmap image)
        {
            double Wreal = image.Width;
            double Hreal = image.Height;

            if (Wreal > pictureBox1.Width || Hreal > pictureBox1.Height)
            {

                double Wmax = pictureBox1.Width;
                double Hmax = pictureBox1.Height;

                double l = Hreal / Wreal;

                int scaledWidth = (int)Wmax;
                int scaledHeight = (int)Hmax;

                if (Wreal / Wmax > Hreal / Hmax)
                    scaledHeight = (int)(Wmax * l);

                else
                    scaledWidth = (int)(Hmax / l);

                pictureBox1.Image = Service.ResizeImage(image, scaledWidth, scaledHeight);
            }

            else
            {
                pictureBox1.Image = image;
            }
        }
    }
}
