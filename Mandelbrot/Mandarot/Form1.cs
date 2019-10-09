using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandarot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int iterations = 20;
        int steps = 0;
        double scale = 1;
        double currSrc = 1.5;
        double currMvX = -1.5;
        double currMvY = -1.5;
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Draw();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        public Bitmap ZoomIn()
        {
            scale = 0.9 * scale;
            steps++;
            return Draw();
        }

        private Bitmap Draw()
        {
            int iters = iterations + 2 * steps;
            return Fractal.createImage(currSrc * scale, currMvX * scale, currMvY * scale, iters);
        }

    }
}
