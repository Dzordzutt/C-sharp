using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Okienka_pola_figur
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void a_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            wynik.Text = "Pole prostokąta wynosi: " + Convert.ToString(Convert.ToInt32(a.Text) * Convert.ToInt32(b.Text));
            MessageBox.Show("Pole prostokąta wynosi: " + Convert.ToString(Convert.ToInt32(a.Text) * Convert.ToInt32(b.Text)), "Wynik",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void trójkatToolStripMenuItem_Click(object sender, EventArgs e)        {

        }

        private void ątToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kołoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void poleKołaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ua = new Form2();
            ua.ShowDialog();
        }

        private void poleTrójkątaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ua = new Form3();
            ua.ShowDialog();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Zakończyć program ?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();


            this.Close();
        }

        private void b_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
