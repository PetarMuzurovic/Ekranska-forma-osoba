namespace EDnevnik
{
    partial class Raspodela
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
            this.cmb_nastavnik = new System.Windows.Forms.ComboBox();
            this.cmb_godina = new System.Windows.Forms.ComboBox();
            this.cmb_predmet = new System.Windows.Forms.ComboBox();
            this.cmb_odeljenje = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_last = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_first = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb_nastavnik
            // 
            this.cmb_nastavnik.FormattingEnabled = true;
            this.cmb_nastavnik.Location = new System.Drawing.Point(410, 103);
            this.cmb_nastavnik.Name = "cmb_nastavnik";
            this.cmb_nastavnik.Size = new System.Drawing.Size(161, 21);
            this.cmb_nastavnik.TabIndex = 0;
            // 
            // cmb_godina
            // 
            this.cmb_godina.FormattingEnabled = true;
            this.cmb_godina.Location = new System.Drawing.Point(410, 130);
            this.cmb_godina.Name = "cmb_godina";
            this.cmb_godina.Size = new System.Drawing.Size(161, 21);
            this.cmb_godina.TabIndex = 1;
            // 
            // cmb_predmet
            // 
            this.cmb_predmet.FormattingEnabled = true;
            this.cmb_predmet.Location = new System.Drawing.Point(410, 157);
            this.cmb_predmet.Name = "cmb_predmet";
            this.cmb_predmet.Size = new System.Drawing.Size(161, 21);
            this.cmb_predmet.TabIndex = 2;
            // 
            // cmb_odeljenje
            // 
            this.cmb_odeljenje.FormattingEnabled = true;
            this.cmb_odeljenje.Location = new System.Drawing.Point(410, 184);
            this.cmb_odeljenje.Name = "cmb_odeljenje";
            this.cmb_odeljenje.Size = new System.Drawing.Size(161, 21);
            this.cmb_odeljenje.TabIndex = 3;
            // 
            // txt_id
            // 
            this.txt_id.Enabled = false;
            this.txt_id.Location = new System.Drawing.Point(410, 77);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(161, 20);
            this.txt_id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Godina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nastavnik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Predmet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(349, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Odeljenje";
            // 
            // btn_last
            // 
            this.btn_last.Location = new System.Drawing.Point(569, 316);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(58, 23);
            this.btn_last.TabIndex = 29;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = true;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(505, 316);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(58, 23);
            this.btn_next.TabIndex = 28;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(439, 316);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(58, 23);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Brisi";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(375, 316);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(58, 23);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Izmeni";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(311, 316);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(58, 23);
            this.btn_insert.TabIndex = 25;
            this.btn_insert.Text = "Dodaj";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(247, 316);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(58, 23);
            this.btn_prev.TabIndex = 24;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_first
            // 
            this.btn_first.Location = new System.Drawing.Point(183, 316);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(58, 23);
            this.btn_first.TabIndex = 23;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = true;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // Raspodela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.cmb_odeljenje);
            this.Controls.Add(this.cmb_predmet);
            this.Controls.Add(this.cmb_godina);
            this.Controls.Add(this.cmb_nastavnik);
            this.Name = "Raspodela";
            this.Text = "Raspodela";
            this.Load += new System.EventHandler(this.Raspodela_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_nastavnik;
        private System.Windows.Forms.ComboBox cmb_godina;
        private System.Windows.Forms.ComboBox cmb_predmet;
        private System.Windows.Forms.ComboBox cmb_odeljenje;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_last;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_first;
    }
}