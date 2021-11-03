namespace Okienka_pola_figur
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kołoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.poleKołaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleTrójkątaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pole prostokąta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(31, 105);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 2;
            this.a.TextChanged += new System.EventHandler(this.a_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Podaj bok a:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Podaj bok b:";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(31, 223);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 5;
            this.b.TextChanged += new System.EventHandler(this.b_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kołoToolStripMenuItem1,
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kołoToolStripMenuItem1
            // 
            this.kołoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poleKołaToolStripMenuItem,
            this.poleTrójkątaToolStripMenuItem});
            this.kołoToolStripMenuItem1.Name = "kołoToolStripMenuItem1";
            this.kołoToolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.kołoToolStripMenuItem1.Text = "Pola";
            this.kołoToolStripMenuItem1.Click += new System.EventHandler(this.kołoToolStripMenuItem1_Click);
            // 
            // poleKołaToolStripMenuItem
            // 
            this.poleKołaToolStripMenuItem.Name = "poleKołaToolStripMenuItem";
            this.poleKołaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.poleKołaToolStripMenuItem.Text = "Pole koła";
            this.poleKołaToolStripMenuItem.Click += new System.EventHandler(this.poleKołaToolStripMenuItem_Click);
            // 
            // poleTrójkątaToolStripMenuItem
            // 
            this.poleTrójkątaToolStripMenuItem.Name = "poleTrójkątaToolStripMenuItem";
            this.poleTrójkątaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.poleTrójkątaToolStripMenuItem.Text = "Pole trójkąta";
            this.poleTrójkątaToolStripMenuItem.Click += new System.EventHandler(this.poleTrójkątaToolStripMenuItem_Click);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Location = new System.Drawing.Point(215, 254);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(40, 13);
            this.wynik.TabIndex = 7;
            this.wynik.Text = "Wynik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Okienka_pola_figur.Properties.Resources._1;
            this.ClientSize = new System.Drawing.Size(528, 330);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.b);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Pole prostokata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kołoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem poleKołaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poleTrójkątaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label wynik;
    }
}

