using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace EDnevnik
{
    public partial class Ocena : Form
    {
        DataTable dt_Ocena;

        public Ocena()
        {
            InitializeComponent();
        }

        private void Ocena_Load(object sender, EventArgs e)
        {
            cmb_Godina_Populate();
            cmb_Predmet.Enabled = false;
            cmb_Odeljenje.Enabled = false;
            cmb_Ucenik.Enabled = false;
            cmb_Ocena.Items.Add(1);
            cmb_Ocena.Items.Add(2);
            cmb_Ocena.Items.Add(3);
            cmb_Ocena.Items.Add(4);
            cmb_Ocena.Items.Add(5);
            //cmb_Ocena.Enabled = false;
            cmb_Profesor_Populate();
        }

        private void cmb_Godina_Populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dt_Godina = new DataTable();
            adapter.Fill(dt_Godina);
            cmb_Godina.DataSource = dt_Godina;
            cmb_Godina.ValueMember = "id";
            cmb_Godina.DisplayMember = "naziv";
            cmb_Godina.SelectedValue = 2;
        }

        private void cmb_Godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Godina.IsHandleCreated && cmb_Godina.Focused)
            {
                cmb_Profesor_Populate();
            }
        }

        private void cmb_Profesor_Populate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba ");
            naredba.Append("JOIN raspodela ON osoba.id = nastavnik_id ");
            naredba.Append("WHERE godina_id = " + cmb_Godina.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Profesor = new DataTable();
            adapter.Fill(dt_Profesor);
            cmb_Profesor.DataSource = dt_Profesor;
            cmb_Profesor.ValueMember = "id";
            cmb_Profesor.DisplayMember = "naziv";
            cmb_Profesor.SelectedValue = -1;
            Debug.WriteLine(naredba.ToString());
        }

        private void cmb_Profesor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Profesor.IsHandleCreated && cmb_Profesor.Focused)
            {
                cmb_Predmet_Populate();
                cmb_Predmet.Enabled = true;

                cmb_Odeljenje.SelectedIndex = -1;
                cmb_Odeljenje.Enabled = false;

                cmb_Ucenik.SelectedIndex = -1;
                cmb_Ucenik.Enabled = false;

                cmb_Ocena.SelectedIndex = -1;
                cmb_Ocena.Enabled = false;

                dt_Ocena = new DataTable();
                grid_Ocene.DataSource = dt_Ocena;
            }
        }

        private void cmb_Predmet_Populate()
        {        
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT predmet.id AS id, naziv FROM predmet ");
            naredba.Append("JOIN raspodela ON predmet.id = predmet_id ");
            naredba.Append("WHERE godina_id = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_Profesor.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Predmet = new DataTable();
            adapter.Fill(dt_Predmet);
            cmb_Predmet.DataSource = dt_Predmet;
            cmb_Predmet.ValueMember = "id";
            cmb_Predmet.DisplayMember = "naziv";
            cmb_Predmet.SelectedIndex = -1;
        }

        private void cmb_Predmet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Predmet.IsHandleCreated && cmb_Predmet.Focused)
            {
                cmb_Odeljenje_Populate();
                cmb_Odeljenje.Enabled = true;
                cmb_Odeljenje.SelectedIndex = -1;

                cmb_Ucenik.SelectedIndex = -1;
                cmb_Ucenik.Enabled = false;

                cmb_Ocena.SelectedIndex = -1;
                cmb_Ocena.Enabled = false;

                dt_Ocena = new DataTable();
                grid_Ocene.DataSource = dt_Ocena;
            }
        }

        private void cmb_Odeljenje_Populate()
        {
            StringBuilder naredba = new StringBuilder("SELECT DISTINCT odeljenje.id AS id, STR(razred) + '/' + indeks AS naziv FROM odeljenje ");
            naredba.Append("JOIN raspodela ON odeljenje.id = odeljenje_id ");
            naredba.Append("WHERE raspodela.godina_id = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_Predmet.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Odeljenje = new DataTable();
            adapter.Fill(dt_Odeljenje);
            cmb_Odeljenje.DataSource = dt_Odeljenje;
            cmb_Odeljenje.ValueMember = "id";
            cmb_Odeljenje.DisplayMember = "naziv";            
        }

        private void cmb_Odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Odeljenje.IsHandleCreated && cmb_Odeljenje.Focused)
            {
                cmb_Ucenik_Populate();
                cmb_Ucenik.Enabled = true;
                cmb_Ocena.Enabled = true;
                Grid_Populate();
                UcenikOcenaId_Set(0);
            }
        }

        private void cmb_Ucenik_Populate()
        {
            StringBuilder naredba = new StringBuilder("SELECT osoba.id AS id, ime + ' ' + prezime AS naziv FROM osoba ");
            naredba.Append(" JOIN upisnica ON osoba.id = osoba_id ");
            naredba.Append(" WHERE upisnica.odeljenje_id = " + cmb_Odeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            DataTable dt_Ucenik = new DataTable();
            adapter.Fill(dt_Ucenik);
            cmb_Ucenik.DataSource = dt_Ucenik;
            cmb_Ucenik.ValueMember = "id";
            cmb_Ucenik.DisplayMember = "naziv";
            cmb_Ucenik.SelectedIndex = -1;
        }

        private void Grid_Populate()
        {
            StringBuilder naredba = new StringBuilder("SELECT ocena.id AS id, ime + ' ' + prezime AS naziv, ocena, ucenik_id, datum FROM osoba ");
            naredba.Append(" JOIN ocena ON osoba.id = ucenik_id ");
            naredba.Append(" JOIN raspodela ON raspodela_id = raspodela.id ");
            naredba.Append(" WHERE raspodela_id = ");
            naredba.Append(" (SELECT id FROM raspodela ");
            naredba.Append(" WHERE godina_id = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_Predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cmb_Odeljenje.SelectedValue.ToString() + ")");
            Debug.WriteLine(naredba.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter(naredba.ToString(), veza);
            dt_Ocena = new DataTable();
            adapter.Fill(dt_Ocena);
            grid_Ocene.DataSource = dt_Ocena;
            grid_Ocene.AllowUserToAddRows = false;
            grid_Ocene.Columns["ucenik_id"].Visible = false;
        }

        private void grid_Ocene_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UcenikOcenaId_Set(e.RowIndex);
            }
        }

        private void UcenikOcenaId_Set(int broj_sloga)
        {
            cmb_Ucenik.SelectedValue = dt_Ocena.Rows[broj_sloga]["ucenik_id"];
            cmb_Ocena.SelectedItem = dt_Ocena.Rows[broj_sloga]["ocena"];
            txt_Id.Text = dt_Ocena.Rows[broj_sloga]["id"].ToString();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // INSERT
            StringBuilder naredba = new StringBuilder("SELECT id FROM raspodela ");
            naredba.Append(" WHERE godina_id = " + cmb_Godina.SelectedValue.ToString());
            naredba.Append(" AND nastavnik_id = " + cmb_Profesor.SelectedValue.ToString());
            naredba.Append(" AND predmet_id = " + cmb_Predmet.SelectedValue.ToString());
            naredba.Append(" AND odeljenje_id = " + cmb_Odeljenje.SelectedValue.ToString());
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
            int id_raspodele = 0;
            try
            {
                veza.Open();
                id_raspodele = (int) Komanda.ExecuteScalar();
                veza.Close();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
            if (id_raspodele > 0)
            {
                DateTime datum = Datum.Value;
                naredba = new StringBuilder("INSERT INTO ocena (datum, raspodela_id, ucenik_id, ocena) VALUES('");
                naredba.Append(datum.ToString("yyyy-MM-dd") + "', '");
                naredba.Append(id_raspodele.ToString() + "', '");
                naredba.Append(cmb_Ucenik.SelectedValue.ToString() + "', '");
                naredba.Append(cmb_Ocena.SelectedItem.ToString() + "')");
                Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
            Grid_Populate();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (Convert.ToInt32(txt_Id.Text) > 0)
            {
                DateTime datum = Datum.Value;
                StringBuilder naredba = new StringBuilder("UPDATE ocena SET ");
                naredba.Append(" ucenik_id = '" + cmb_Ucenik.SelectedValue.ToString() + "', ");
                naredba.Append(" ocena = '" + cmb_Ocena.SelectedItem.ToString() + "', ");
                naredba.Append(" datum = '" + datum.ToString("yyyy-MM-dd") + "' ");
                naredba.Append(" WHERE id = " + txt_Id.Text);
                SqlConnection veza = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(naredba.ToString(), veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
                Grid_Populate();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            //DELETE
            if (Convert.ToInt32(txt_Id.Text) > 0)
            {
                string naredba = "DELETE FROM ocena WHERE id = " + txt_Id.Text;
                SqlConnection veza = Konekcija.Connect();
                SqlCommand Komanda = new SqlCommand(naredba, veza);
                try
                {
                    veza.Open();
                    Komanda.ExecuteNonQuery();
                    veza.Close();
                    Grid_Populate();
                    UcenikOcenaId_Set(0);
                }
                catch (Exception Greska)
                {
                    MessageBox.Show(Greska.Message);
                }
            }
        }
    }
}
