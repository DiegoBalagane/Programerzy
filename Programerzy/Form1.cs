using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programerzy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            // Draw Line For Title
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 83, Width, 83);

            // Draw Line For Buttons
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 179, Width, 179);
            e.Graphics.DrawLine(pen, 0, 262, Width, 262);

            pen.Dispose();
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 window = new Form2();
            window.setForm1Form(this);
            window.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
