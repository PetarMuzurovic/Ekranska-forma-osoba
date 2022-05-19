
namespace EDnevnik
{
    partial class Glavna2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.obradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raspodelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.upisniceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sifarniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osobeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smeroviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skolskeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.predmetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvestajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obradaToolStripMenuItem,
            this.sifarniciToolStripMenuItem,
            this.izvestajiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // obradaToolStripMenuItem
            // 
            this.obradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.raspodelaToolStripMenuItem,
            this.oceneToolStripMenuItem,
            this.upisniceToolStripMenuItem});
            this.obradaToolStripMenuItem.Name = "obradaToolStripMenuItem";
            this.obradaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.obradaToolStripMenuItem.Text = "Obrada";
            // 
            // raspodelaToolStripMenuItem
            // 
            this.raspodelaToolStripMenuItem.Name = "raspodelaToolStripMenuItem";
            this.raspodelaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.raspodelaToolStripMenuItem.Text = "Raspodela";
            this.raspodelaToolStripMenuItem.Click += new System.EventHandler(this.raspodelaToolStripMenuItem_Click);
            // 
            // oceneToolStripMenuItem
            // 
            this.oceneToolStripMenuItem.Name = "oceneToolStripMenuItem";
            this.oceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oceneToolStripMenuItem.Text = "Ocene";
            this.oceneToolStripMenuItem.Click += new System.EventHandler(this.oceneToolStripMenuItem_Click);
            // 
            // upisniceToolStripMenuItem
            // 
            this.upisniceToolStripMenuItem.Name = "upisniceToolStripMenuItem";
            this.upisniceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.upisniceToolStripMenuItem.Text = "Upisnice";
            this.upisniceToolStripMenuItem.Click += new System.EventHandler(this.upisniceToolStripMenuItem_Click);
            // 
            // sifarniciToolStripMenuItem
            // 
            this.sifarniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osobeToolStripMenuItem,
            this.smeroviToolStripMenuItem,
            this.skolskeToolStripMenuItem,
            this.predmetiToolStripMenuItem});
            this.sifarniciToolStripMenuItem.Name = "sifarniciToolStripMenuItem";
            this.sifarniciToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.sifarniciToolStripMenuItem.Text = "Sifarnici";
            // 
            // osobeToolStripMenuItem
            // 
            this.osobeToolStripMenuItem.Name = "osobeToolStripMenuItem";
            this.osobeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.osobeToolStripMenuItem.Text = "Osobe";
            this.osobeToolStripMenuItem.Click += new System.EventHandler(this.osobeToolStripMenuItem_Click);
            // 
            // smeroviToolStripMenuItem
            // 
            this.smeroviToolStripMenuItem.Name = "smeroviToolStripMenuItem";
            this.smeroviToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.smeroviToolStripMenuItem.Text = "Smerovi";
            this.smeroviToolStripMenuItem.Click += new System.EventHandler(this.smeroviToolStripMenuItem_Click);
            // 
            // skolskeToolStripMenuItem
            // 
            this.skolskeToolStripMenuItem.Name = "skolskeToolStripMenuItem";
            this.skolskeToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.skolskeToolStripMenuItem.Text = "Skolske godine";
            this.skolskeToolStripMenuItem.Click += new System.EventHandler(this.skolskeToolStripMenuItem_Click);
            // 
            // predmetiToolStripMenuItem
            // 
            this.predmetiToolStripMenuItem.Name = "predmetiToolStripMenuItem";
            this.predmetiToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.predmetiToolStripMenuItem.Text = "Predmeti";
            this.predmetiToolStripMenuItem.Click += new System.EventHandler(this.predmetiToolStripMenuItem_Click);
            // 
            // izvestajiToolStripMenuItem
            // 
            this.izvestajiToolStripMenuItem.Name = "izvestajiToolStripMenuItem";
            this.izvestajiToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.izvestajiToolStripMenuItem.Text = "Izvestaji";
            // 
            // Glavna2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 377);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna2";
            this.Text = "Glavna2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Glavna2_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem obradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raspodelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem upisniceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sifarniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osobeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smeroviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skolskeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem predmetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvestajiToolStripMenuItem;
    }
}