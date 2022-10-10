using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "";
            label8.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize , final,  ortalama;

            try
            {
              vize = Convert.ToDouble(numericUpDown1.Value);
              final = Convert.ToDouble(numericUpDown2.Value);
              ortalama = vize * 0.4 + final * 0.6;
             label3.Text = ortalama.ToString();
                label5.Text = ortalama.ToString();
                if
                    (ortalama < 50 || final < 50) { 
               
                    label5.Text = "Kaldınız.";
                    label5.ForeColor = Color.Red; }
               
                else { 
                    label5.Text = "Geçtiniz.";
                  label5.ForeColor = Color.Green;
                    }

                if
                    (numericUpDown1.Value >=101 || numericUpDown2.Value >=101)
                {
                    MessageBox.Show("Lütfen 0 ile 100 arasında sayı giriniz");

                    numericUpDown1.Value = (0);
                    numericUpDown2.Value = (0);
                }



                if ( ortalama <= 49)
                    label8.Text = "FF";
                if (ortalama >= 50 && ortalama <= 59)
                    label8.Text = "CC";
                if (ortalama >= 60 && ortalama <= 69)
                    label8.Text = "CB";
                if (ortalama >= 70 && ortalama <= 79)
                    label8.Text = "BB";
                if (ortalama >= 80 && ortalama <=89)
                    label8.Text = "BA";
                if (ortalama >= 90 && ortalama <= 100)
                    label8.Text = "AA";
                

            }

            catch (Exception exit)

            
            {
                
            }

        }




           


        }

        
    }

