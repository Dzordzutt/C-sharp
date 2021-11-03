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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
  
    }

        private void poleKwadratuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ua = new Form1();
            ua.ShowDialog();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void poleKołaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ua = new Form2();
            ua.ShowDialog();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Zakończyć program ?", "Uwaga", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wynik.Text = "Pole trójkąta wynosi: " + Convert.ToString((Convert.ToInt32(a.Text) * Convert.ToInt32(h.Text)) / 2);
            MessageBox.Show("Pole trójkąta wynosi: " + Convert.ToString((Convert.ToInt32(a.Text) * Convert.ToInt32(h.Text)) / 2), "Wynik",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
