using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class AnaEkran : Form
    {
        private object kitapAdi;
        private object txtyazarad;

        public AnaEkran()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            this.Hide();
        }

        public void kitapEkle(string kitapAdi)
        {
            listBox1.Items.Add(kitapAdi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KitapEklemeEkrani kitapEklemeEkrani = new KitapEklemeEkrani(this);
            kitapEklemeEkrani.Show();
            this.Hide();

            KitapEklemeEkrani duzenle = new KitapEklemeEkrani(this);
            duzenle.Show();
            int index = listBox1.SelectedIndex;
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox1.Items.Insert(index, duzenle);

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);



            DialogResult Cikis;
            Cikis = MessageBox.Show("Silmek Istediğinize Eminmisin", "Silme Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                this.Close();
            }
            if (Cikis == DialogResult.No)
            {
                Application.Run();
            }
        }

        private void listele(ListBox listBox1)
        {
            throw new NotImplementedException();
        }
    }
    }

