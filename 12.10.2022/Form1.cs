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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
       

        }
    private void button1_Click(object sender, EventArgs e)
        {
            Form2 oğrencieklemekrani = new Form2(this);// iki formu çalıştırmak için
            oğrencieklemekrani.Show();  // gizlemek çiin          
            this.Hide();// gizlemek çiin
            

        }   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 ogrekle = new Form2(this);
            ogrekle.ShowDialog();
            ogrekle.Show();
            this.Hide();

        }

        private void çıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Programdan Çıkmak İstediğine Eminmisin", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Cikis == DialogResult.No)
            {
                Application.Run();
            }
        }
    }
}
