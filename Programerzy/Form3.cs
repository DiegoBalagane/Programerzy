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
    public partial class Form3 : Form
    {
        private Form1 form1Form = null;
        public Form3(int questionNumber)
        {
            InitializeComponent();
            valueOfPrize(questionNumber);
        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 179, 179, 179));

            // Draw Line For Title
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 83, Width, 83);

            // Draw Line For prize amount and button
            pen.Width = 2f;
            e.Graphics.DrawLine(pen, 0, 179, Width, 179);
            e.Graphics.DrawLine(pen, 0, 262, Width, 262);

            pen.Dispose();
        }

        private void PrizeValue_Click(object sender, EventArgs e)
        {

        }

        private void ReturnMenu_Click(object sender, EventArgs e)
        {
            form1Form.Show();
            this.Dispose();
        }

        public void setForm1Form(Form1 form)
        {
            this.form1Form = form;
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void valueOfPrize(int questionNumber)
        {
            switch(questionNumber)
            {
                case 1:
                    PrizeValue.Text = "0 zł";
                    break;
                case 2:
                    PrizeValue.Text = "500 zł";
                    break;
                case 3:
                    PrizeValue.Text = "1000 zł";
                    break;
                case 4:
                    PrizeValue.Text = "2000 zł";
                    break;
                case 5:
                    PrizeValue.Text = "5000 zł";
                    break;
                case 6:
                    PrizeValue.Text = "10 000 zł";
                    break;
                case 7:
                    PrizeValue.Text = "20 000 zł";
                    break;
                case 8:
                    PrizeValue.Text = "40 000 zł";
                    break;
                case 9:
                    PrizeValue.Text = "75 000 zł";
                    break;
                case 10:
                    PrizeValue.Text = "125 000 zł";
                    break;
                case 11:
                    PrizeValue.Text = "250 000 zł";
                    break;
                case 12:
                    PrizeValue.Text = "500 000 zł";
                    break;
                case 13:
                    PrizeValue.Text = "1 000 000 zł";
                    break;

            }
        }
    }
}
