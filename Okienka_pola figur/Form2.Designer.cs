namespace Okienka_pola_figur
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleKwadratuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleTrójkątaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(39, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Oblicz!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // r
            // 
            this.r.Location = new System.Drawing.Point(39, 161);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(100, 20);
            this.r.TabIndex = 2;
            this.r.TextChanged += new System.EventHandler(this.r_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pole koła";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(36, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Podaj promień (r):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.polaToolStripMenuItem,
            this.plikToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // polaToolStripMenuItem
            // 
            this.polaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poleKwadratuToolStripMenuItem,
            this.poleTrójkątaToolStripMenuItem});
            this.polaToolStripMenuItem.Name = "polaToolStripMenuItem";
            this.polaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.polaToolStripMenuItem.Text = "Pola";
            // 
            // poleKwadratuToolStripMenuItem
            // 
            this.poleKwadratuToolStripMenuItem.Name = "poleKwadratuToolStripMenuItem";
            this.poleKwadratuToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.poleKwadratuToolStripMenuItem.Text = "Pole kwadratu";
            this.poleKwadratuToolStripMenuItem.Click += new System.EventHandler(this.poleKwadratuToolStripMenuItem_Click);
            // 
            // poleTrójkątaToolStripMenuItem
            // 
            this.poleTrójkątaToolStripMenuItem.Name = "poleTrójkątaToolStripMenuItem";
            this.poleTrójkątaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
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
            this.wynik.Location = new System.Drawing.Point(251, 245);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(40, 13);
            this.wynik.TabIndex = 7;
            this.wynik.Text = "Wynik:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Okienka_pola_figur.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(529, 324);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.r);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Pole koła";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox r;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poleKwadratuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poleTrójkątaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label wynik;
    }
}