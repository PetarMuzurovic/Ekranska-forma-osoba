
namespace EDnevnik
{
    partial class Ocena
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
            this.cmb_Godina = new System.Windows.Forms.ComboBox();
            this.cmb_Profesor = new System.Windows.Forms.ComboBox();
            this.cmb_Predmet = new System.Windows.Forms.ComboBox();
            this.cmb_Odeljenje = new System.Windows.Forms.ComboBox();
            this.cmb_Ucenik = new System.Windows.Forms.ComboBox();
            this.cmb_Ocena = new System.Windows.Forms.ComboBox();
            this.Datum = new System.Windows.Forms.DateTimePicker();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.grid_Ocene = new System.Windows.Forms.DataGridView();
            this.lbl_Godina = new System.Windows.Forms.Label();
            this.lbl_Profesor = new System.Windows.Forms.Label();
            this.lbl_Predmet = new System.Windows.Forms.Label();
            this.lbl_Odeljenje = new System.Windows.Forms.Label();
            this.lbl_Ucenik = new System.Windows.Forms.Label();
            this.lbl_Ocena = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_Datum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Ocene)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Godina
            // 
            this.cmb_Godina.FormattingEnabled = true;
            this.cmb_Godina.Location = new System.Drawing.Point(15, 25);
            this.cmb_Godina.Name = "cmb_Godina";
            this.cmb_Godina.Size = new System.Drawing.Size(121, 21);
            this.cmb_Godina.TabIndex = 0;
            this.cmb_Godina.SelectedValueChanged += new System.EventHandler(this.cmb_Godina_SelectedValueChanged);
            // 
            // cmb_Profesor
            // 
            this.cmb_Profesor.FormattingEnabled = true;
            this.cmb_Profesor.Location = new System.Drawing.Point(142, 25);
            this.cmb_Profesor.Name = "cmb_Profesor";
            this.cmb_Profesor.Size = new System.Drawing.Size(121, 21);
            this.cmb_Profesor.TabIndex = 1;
            this.cmb_Profesor.SelectedValueChanged += new System.EventHandler(this.cmb_Profesor_SelectedValueChanged);
            // 
            // cmb_Predmet
            // 
            this.cmb_Predmet.FormattingEnabled = true;
            this.cmb_Predmet.Location = new System.Drawing.Point(269, 25);
            this.cmb_Predmet.Name = "cmb_Predmet";
            this.cmb_Predmet.Size = new System.Drawing.Size(121, 21);
            this.cmb_Predmet.TabIndex = 2;
            this.cmb_Predmet.SelectedValueChanged += new System.EventHandler(this.cmb_Predmet_SelectedValueChanged);
            // 
            // cmb_Odeljenje
            // 
            this.cmb_Odeljenje.FormattingEnabled = true;
            this.cmb_Odeljenje.Location = new System.Drawing.Point(396, 25);
            this.cmb_Odeljenje.Name = "cmb_Odeljenje";
            this.cmb_Odeljenje.Size = new System.Drawing.Size(121, 21);
            this.cmb_Odeljenje.TabIndex = 3;
            this.cmb_Odeljenje.SelectedValueChanged += new System.EventHandler(this.cmb_Odeljenje_SelectedValueChanged);
            // 
            // cmb_Ucenik
            // 
            this.cmb_Ucenik.FormattingEnabled = true;
            this.cmb_Ucenik.Location = new System.Drawing.Point(15, 70);
            this.cmb_Ucenik.Name = "cmb_Ucenik";
            this.cmb_Ucenik.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ucenik.TabIndex = 4;
            // 
            // cmb_Ocena
            // 
            this.cmb_Ocena.FormattingEnabled = true;
            this.cmb_Ocena.Location = new System.Drawing.Point(142, 70);
            this.cmb_Ocena.Name = "cmb_Ocena";
            this.cmb_Ocena.Size = new System.Drawing.Size(121, 21);
            this.cmb_Ocena.TabIndex = 5;
            // 
            // Datum
            // 
            this.Datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datum.Location = new System.Drawing.Point(396, 70);
            this.Datum.Name = "Datum";
            this.Datum.Size = new System.Drawing.Size(121, 20);
            this.Datum.TabIndex = 6;
            // 
            // txt_Id
            // 
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(269, 70);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(121, 20);
            this.txt_Id.TabIndex = 7;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(523, 9);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 8;
            this.btn_Insert.Text = "Dodaj";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(523, 38);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Izmeni";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(523, 67);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Brisi";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // grid_Ocene
            // 
            this.grid_Ocene.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Ocene.Location = new System.Drawing.Point(12, 97);
            this.grid_Ocene.Name = "grid_Ocene";
            this.grid_Ocene.Size = new System.Drawing.Size(583, 269);
            this.grid_Ocene.TabIndex = 11;
            this.grid_Ocene.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Ocene_CellClick);
            // 
            // lbl_Godina
            // 
            this.lbl_Godina.AutoSize = true;
            this.lbl_Godina.Location = new System.Drawing.Point(12, 9);
            this.lbl_Godina.Name = "lbl_Godina";
            this.lbl_Godina.Size = new System.Drawing.Size(41, 13);
            this.lbl_Godina.TabIndex = 12;
            this.lbl_Godina.Text = "Godina";
            // 
            // lbl_Profesor
            // 
            this.lbl_Profesor.AutoSize = true;
            this.lbl_Profesor.Location = new System.Drawing.Point(139, 9);
            this.lbl_Profesor.Name = "lbl_Profesor";
            this.lbl_Profesor.Size = new System.Drawing.Size(46, 13);
            this.lbl_Profesor.TabIndex = 13;
            this.lbl_Profesor.Text = "Profesor";
            // 
            // lbl_Predmet
            // 
            this.lbl_Predmet.AutoSize = true;
            this.lbl_Predmet.Location = new System.Drawing.Point(266, 9);
            this.lbl_Predmet.Name = "lbl_Predmet";
            this.lbl_Predmet.Size = new System.Drawing.Size(46, 13);
            this.lbl_Predmet.TabIndex = 14;
            this.lbl_Predmet.Text = "Predmet";
            // 
            // lbl_Odeljenje
            // 
            this.lbl_Odeljenje.AutoSize = true;
            this.lbl_Odeljenje.Location = new System.Drawing.Point(393, 9);
            this.lbl_Odeljenje.Name = "lbl_Odeljenje";
            this.lbl_Odeljenje.Size = new System.Drawing.Size(51, 13);
            this.lbl_Odeljenje.TabIndex = 15;
            this.lbl_Odeljenje.Text = "Odeljenje";
            // 
            // lbl_Ucenik
            // 
            this.lbl_Ucenik.AutoSize = true;
            this.lbl_Ucenik.Location = new System.Drawing.Point(12, 54);
            this.lbl_Ucenik.Name = "lbl_Ucenik";
            this.lbl_Ucenik.Size = new System.Drawing.Size(41, 13);
            this.lbl_Ucenik.TabIndex = 16;
            this.lbl_Ucenik.Text = "Ucenik";
            // 
            // lbl_Ocena
            // 
            this.lbl_Ocena.AutoSize = true;
            this.lbl_Ocena.Location = new System.Drawing.Point(139, 54);
            this.lbl_Ocena.Name = "lbl_Ocena";
            this.lbl_Ocena.Size = new System.Drawing.Size(39, 13);
            this.lbl_Ocena.TabIndex = 17;
            this.lbl_Ocena.Text = "Ocena";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(266, 54);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(18, 13);
            this.lbl_Id.TabIndex = 18;
            this.lbl_Id.Text = "ID";
            // 
            // lbl_Datum
            // 
            this.lbl_Datum.AutoSize = true;
            this.lbl_Datum.Location = new System.Drawing.Point(393, 54);
            this.lbl_Datum.Name = "lbl_Datum";
            this.lbl_Datum.Size = new System.Drawing.Size(38, 13);
            this.lbl_Datum.TabIndex = 19;
            this.lbl_Datum.Text = "Datum";
            // 
            // Ocena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 378);
            this.Controls.Add(this.lbl_Datum);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Ocena);
            this.Controls.Add(this.lbl_Ucenik);
            this.Controls.Add(this.lbl_Odeljenje);
            this.Controls.Add(this.lbl_Predmet);
            this.Controls.Add(this.lbl_Profesor);
            this.Controls.Add(this.lbl_Godina);
            this.Controls.Add(this.grid_Ocene);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.Datum);
            this.Controls.Add(this.cmb_Ocena);
            this.Controls.Add(this.cmb_Ucenik);
            this.Controls.Add(this.cmb_Odeljenje);
            this.Controls.Add(this.cmb_Predmet);
            this.Controls.Add(this.cmb_Profesor);
            this.Controls.Add(this.cmb_Godina);
            this.Name = "Ocena";
            this.Text = "Ocena";
            this.Load += new System.EventHandler(this.Ocena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Ocene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Godina;
        private System.Windows.Forms.ComboBox cmb_Profesor;
        private System.Windows.Forms.ComboBox cmb_Predmet;
        private System.Windows.Forms.ComboBox cmb_Odeljenje;
        private System.Windows.Forms.ComboBox cmb_Ucenik;
        private System.Windows.Forms.ComboBox cmb_Ocena;
        private System.Windows.Forms.DateTimePicker Datum;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView grid_Ocene;
        private System.Windows.Forms.Label lbl_Godina;
        private System.Windows.Forms.Label lbl_Profesor;
        private System.Windows.Forms.Label lbl_Predmet;
        private System.Windows.Forms.Label lbl_Odeljenje;
        private System.Windows.Forms.Label lbl_Ucenik;
        private System.Windows.Forms.Label lbl_Ocena;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_Datum;
    }
}