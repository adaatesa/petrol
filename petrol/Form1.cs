using System;
using System.Windows.Forms;
using petrol;

namespace PetrolOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Formun arka plan rengini gri yapalım
            this.BackColor = System.Drawing.Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // FormOgretmen formunu oluşturuyoruz ve gösteriyoruz
            pompaci pompaci = new pompaci();
            pompaci.Show();  // Yeni formu aç
            this.Hide();          // Mevcut formu gizle
        }
    }
}
