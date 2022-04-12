using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
        int total = 0;
        if (txtFood1.Text != "")
                total += Convert.ToInt32(txtFood1.Text) * 30;

        if (txtFood2.Text != "")
                total += Convert.ToInt32(txtFood2.Text) * 70;

        if (txtFood3.Text != "")
                total += Convert.ToInt32(txtFood3.Text) * 120;
        
        if (txtFood4.Text != "")
                total += Convert.ToInt32(txtFood4.Text) * 160;

        if (txtFood5.Text != "")
                total += Convert.ToInt32(txtFood5.Text) * 200;

        if (txtFood6.Text != "")
                total += Convert.ToInt32(txtFood6.Text) * 100;

        if (txtFood7.Text != "")
                total += Convert.ToInt32(txtFood7.Text) * 230;

        if (txtFood8.Text != "")
                total += Convert.ToInt32(txtFood8.Text) * 150;

            textBox3.Text = total.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
