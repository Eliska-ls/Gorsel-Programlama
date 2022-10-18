using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12._10._2022
{
    public partial class Form2 : Form
    {
        Form1 AnaForm;  // rctxb ye eklenen metinin silinmesi engeller
        public Form2(Form1 parametredengelenAnaForm) 
        {
            InitializeComponent();
            AnaForm = parametredengelenAnaForm;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 anaekran = new Form1();
            AnaForm.Show();// rctxb ye eklenen metinin silinmesi engeller
            this.Close();
           
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            AnaForm.Show();  // 2. formu kapatınca ana ekranı getirmek için event form closed çift tıkla
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
