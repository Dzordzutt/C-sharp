namespace Okienka_pola_figur
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.TextBox();
            this.a = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.polaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleKołaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poleKwadratuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wynik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 239);
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
            this.label1.Location = new System.Drawing.Point(29, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Podaj bok a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Podaj wysokość h:";
            // 
            // h
            // 
            this.h.Location = new System.Drawing.Point(31, 194);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(100, 20);
            this.h.TabIndex = 3;
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(31, 112);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pole trójkąta";
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
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(530, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // polaToolStripMenuItem
            // 
            this.polaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poleKołaToolStripMenuItem,
            this.poleKwadratuToolStripMenuItem});
            this.polaToolStripMenuItem.Name = "polaToolStripMenuItem";
            this.polaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.polaToolStripMenuItem.Text = "Pola";
            // 
            // poleKołaToolStripMenuItem
            // 
            this.poleKołaToolStripMenuItem.Name = "poleKołaToolStripMenuItem";
            this.poleKołaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.poleKołaToolStripMenuItem.Text = "Pole koła";
            this.poleKołaToolStripMenuItem.Click += new System.EventHandler(this.poleKołaToolStripMenuItem_Click);
            // 
            // poleKwadratuToolStripMenuItem
            // 
            this.poleKwadratuToolStripMenuItem.Name = "poleKwadratuToolStripMenuItem";
            this.poleKwadratuToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.poleKwadratuToolStripMenuItem.Text = "Pole kwadratu";
            this.poleKwadratuToolStripMenuItem.Click += new System.EventHandler(this.poleKwadratuToolStripMenuItem_Click);
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
            this.wynik.Location = new System.Drawing.Point(213, 248);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(40, 13);
            this.wynik.TabIndex = 8;
            this.wynik.Text = "Wynik:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.BackgroundImage = global::Okienka_pola_figur.Properties.Resources._2;
            this.ClientSize = new System.Drawing.Size(530, 325);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a);
            this.Controls.Add(this.h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox h;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem polaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poleKołaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poleKwadratuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.Label wynik;
    }
}