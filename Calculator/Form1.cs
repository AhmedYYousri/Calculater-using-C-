using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "8";
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "2";
        }

        private void btnthree_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "3";
        }

        private void btnfour_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "4";
        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "5";
        }

        private void btnsex_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "7";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            textstore.Text = textstore.Text + "9";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            textstore.Clear();
            textresualt.Clear();
        }
        float num;
        int count;
        private void btnmin_Click(object sender, EventArgs e)
        {
            if (textstore.Text !="")
            {
                num = float.Parse(textstore.Text);
                textresualt.Text = textstore.Text + "-";
                textstore.Clear();
                count = 1;
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresualt.Text = textstore.Text + "+";
                textstore.Clear();
                count = 2;
            }
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresualt.Text = textstore.Text + "*";
                textstore.Clear();
                count = 3;
            }
        }

        private void btndevide_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresualt.Text = textstore.Text + "/";
                textstore.Clear();
                count = 4;
            }
        }

        private void btnrd_Click(object sender, EventArgs e)
        {
            if (textstore.Text != "")
            {
                num = float.Parse(textstore.Text);
                textresualt.Text = textstore.Text + "%";
                textstore.Clear();
                count = 5;
            }
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            float ans;
            switch (count)
            {
                case 1:
                    ans = num - float.Parse(textstore.Text);
                    textresualt.Text = textresualt.Text + textstore.Text ;
                    textstore.Text = ans.ToString();
                    break;
                case 2:
                    ans = num + float.Parse(textstore.Text);
                    textresualt.Text = textresualt.Text + textstore.Text ;
                    textstore.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(textstore.Text);
                    textresualt.Text = textresualt.Text + textstore.Text;
                    textstore.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(textstore.Text);
                    textresualt.Text = textresualt.Text + textstore.Text;
                    textstore.Text = ans.ToString();
                    break;
                case 5:
                    ans = num % float.Parse(textstore.Text);
                    textresualt.Text = textresualt.Text + textstore.Text;
                    textstore.Text = ans.ToString();
                    break;
            }
        }
    }
}
