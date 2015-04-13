using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Mahin_Car
{
    public partial class Form1 : Form
    {
        Pen bluepen = new Pen(Color.Blue, 5);
        Graphics g = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            Point p = pictureBox1.Location;
            p.X += 10;
            pictureBox1.Location = p;
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.DrawLine(bluepen, 140, 60, 240, 60);

            e.Graphics.DrawLine(bluepen, 238, 60, 270, 90);
            e.Graphics.DrawLine(bluepen, 270, 90, 330, 110);
            e.Graphics.DrawLine(bluepen, 330, 110, 333, 130);
            e.Graphics.DrawLine(bluepen, 333, 130, 270, 130);

            e.Graphics.DrawLine(bluepen, 140, 60, 110, 90);
            e.Graphics.DrawLine(bluepen, 110, 90, 80, 110);
            e.Graphics.DrawLine(bluepen, 80, 110, 80, 130);
            e.Graphics.DrawLine(bluepen, 80, 130, 110, 130);

            e.Graphics.DrawLine(bluepen, 150, 130, 230, 130);

            e.Graphics.DrawEllipse(bluepen, 111, 120, 37, 37);
            e.Graphics.DrawEllipse(bluepen, 231, 120, 37, 37);

            e.Graphics.DrawLine(bluepen, 190, 60, 190, 130);
            e.Graphics.DrawLine(bluepen, 110, 90, 270, 90);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
