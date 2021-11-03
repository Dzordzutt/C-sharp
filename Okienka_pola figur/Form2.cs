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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void poleTrójkątaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 ua = new Form3();
            ua.ShowDialog();
        }

        private void poleKwadratuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ua = new Form1();
            ua.ShowDialog();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Zakończyć program ?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void r_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wynik.Text = "Pole koła wynosi: " + Convert.ToString(Convert.ToInt32(Math.PI) * Convert.ToInt32(r.Text) * Convert.ToInt32(r.Text));
            MessageBox.Show("Pole koła wynosi: " + Convert.ToString(Convert.ToInt32(Math.PI) * Convert.ToInt32(r.Text) * Convert.ToInt32(r.Text)), "Wynik",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
