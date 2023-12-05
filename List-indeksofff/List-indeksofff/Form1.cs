using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_indeksofff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> personelListe = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            int sira = personelListe.IndexOf(aranan);


            if (sira >= 0)
            {
                listBox1.SelectedIndex = sira;
                MessageBox.Show("Aradığınız personel " + (sira + 1) + ". sırada.");
            }

            else
            {
                MessageBox.Show("Personel bulunamadı.");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            personelListe.Add("Ahmet");
            personelListe.Add("Burak");
            personelListe.Add("Ayşe");
            personelListe.Add("Beyza");
            personelListe.Add("Aliye");
            personelListe.Add("Kemal");
            personelListe.Add("Ruziye");
            personelListe.Add("Handan");
            personelListe.Add("Muzaffer");

            listBox1.DataSource = personelListe.ToList();
        }
    }
}
