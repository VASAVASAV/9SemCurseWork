﻿using MainImageProcessor;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
     public partial class MainForm : Form
     {
        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileWindow = new OpenFileDialog();
            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(openFileWindow.FileName);

                //storing image info
                WorkingImage.Clear();
                WorkingImage.Add(BitmapConverter.BitmapToDoubleRgb(bmp));
                ImageName = Path.GetFileNameWithoutExtension(openFileWindow.FileName);
                toolStripStatusLabel1.Text = ImageName;

                LogOutputTextBox.Text += "Відкрито зображення \""+ ImageName + "\""+Environment.NewLine+"Ширина зображення :" + bmp.Width + Environment.NewLine+"Висота зображення:" + bmp.Height+Environment.NewLine;
                //fill fields with image height and width
                //textBox1.Text = String.Format("Ширина: {0}{2}Висота: {1}", bmp.Width, bmp.Height, Environment.NewLine);
                //SubdivisionWidthTextBox.Text = bmp.Width.ToString();
                //SubdivisionHeightTextBox.Text = bmp.Height.ToString();

                OutputBitmapOnPictureBox(bmp);
                textBox4.Text = "" + WorkingImage.Count;
            }
        }

        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = Environment.CurrentDirectory,
                FileName = ImageName + "_processed",
                DefaultExt = ".png"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BitmapConverter.DoubleRgbToBitmap(WorkingImage[WorkingImage.Count-1]).Save(sfd.FileName);
            }
        }
    }
}
