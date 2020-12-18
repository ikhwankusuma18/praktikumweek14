using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string reverse(string kata)
        {
            char[] a = kata.ToCharArray();

            Array.Reverse(a);
            return new string(a);
        }
        private void btn_reverse_Click(object sender, EventArgs e)
        {
            string text = tb_inputan.Text;
            lbl_output.Text = reverse(text);

            {
                if (tb_inputan.Text == "") 
                    MessageBox.Show("Tolong isi textbox dahulu");
            }
        }

        private void btn_urutkan_Click(object sender, EventArgs e)
        {
            if (tb_inputan.Text == "")
                MessageBox.Show("Tolong isi textbox dahulu");


        }
    }
}
      
