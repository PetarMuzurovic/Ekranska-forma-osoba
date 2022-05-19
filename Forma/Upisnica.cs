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

namespace EDnevnik
{
    public partial class Upisnica : Form
    {
        DataTable dt_upisnica;
        public Upisnica()
        {
            InitializeComponent();
        }

        private void cmb_godina_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM skolska_godina", veza);
            DataTable dt_godina = new DataTable();
            adapter.Fill(dt_godina);
            cmb_godina.DataSource = dt_godina;
            cmb_godina.ValueMember = "id";
            cmb_godina.DisplayMember = "naziv";
            cmb_godina.SelectedValue = 2;
        }
        private void cmb_godina_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_godina.IsHandleCreated && cmb_godina.Focused)
            {
                cmb_odeljenje_populate();
                cmb_odeljenje.SelectedIndex = -1;
                while (grid_upisnica.Rows.Count > 0)
                {
                    grid_upisnica.Rows.Remove(grid_upisnica.Rows[0]);
                }
                txt_upisnica.Text = "";
                cmb_ucenik.SelectedIndex = -1;
                cmb_ucenik.Enabled = false;
            }
        }

        private void cmb_odeljenje_populate()
        {
            string godina = cmb_godina.SelectedValue.ToString();
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, str(razred) + '/' + indeks AS naziv FROM odeljenje WHERE godina_id = " + godina, veza);
            DataTable dt_odeljenje = new DataTable();
            adapter.Fill(dt_odeljenje);
            cmb_odeljenje.DataSource = dt_odeljenje;
            cmb_odeljenje.ValueMember = "id";
            cmb_odeljenje.DisplayMember = "naziv";
        }
        private void cmb_odeljenje_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_odeljenje.IsHandleCreated && cmb_odeljenje.Focused)
            {
                cmb_ucenik_populate();
                cmb_ucenik.Enabled = true;
                grid_populate();
            }
        }

        private void cmb_ucenik_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, ime + ' ' + prezime AS naziv FROM osoba WHERE uloga = 1", veza);
            DataTable dt_ucenik = new DataTable();
            adapter.Fill(dt_ucenik);
            cmb_ucenik.DataSource = dt_ucenik;
            cmb_ucenik.ValueMember = "id";
            cmb_ucenik.DisplayMember = "naziv";
        }

        private void grid_populate()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT upisnica.id, ime + ' ' + prezime AS naziv, osoba.id AS ucenik FROM upisnica JOIN osoba ON osoba_id = osoba.id WHERE odeljenje_id = " + cmb_odeljenje.SelectedValue.ToString(), veza);
            dt_upisnica = new DataTable();
            adapter.Fill(dt_upisnica);
            grid_upisnica.DataSource = dt_upisnica;
            grid_upisnica.AllowUserToAddRows = false;
            grid_upisnica.Columns["ucenik"].Visible = false;
        }

        private void Upisnica_Load(object sender, EventArgs e)
        {
            cmb_godina_populate();
            cmb_odeljenje_populate();
            cmb_odeljenje.SelectedIndex = -1;
            cmb_ucenik.Enabled = false;
        }

        private void grid_upisnica_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grid_upisnica.CurrentRow != null)
            {
                int broj_sloga = grid_upisnica.CurrentRow.Index;
                if (dt_upisnica.Rows.Count != 0 && broj_sloga >= 0)
                {
                    cmb_ucenik.SelectedValue = grid_upisnica.Rows[broj_sloga].Cells["ucenik"].Value.ToString();
                    txt_upisnica.Text = grid_upisnica.Rows[broj_sloga].Cells["id"].Value.ToString();
                }
            }
            
            
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("INSERT INTO upisnica(odeljenje_id, osoba_id) VALUES('");
            naredba.Append(cmb_odeljenje.SelectedValue.ToString() + "', '");
            naredba.Append(cmb_ucenik.SelectedValue.ToString() + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid_populate();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder naredba = new StringBuilder("UPDATE upisnica SET ");
            naredba.Append("osoba_id = '" + cmb_ucenik.SelectedValue.ToString() + "' ");
            naredba.Append("WHERE id = " + txt_upisnica.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid_populate();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string naredba = "DELETE FROM upisnica WHERE id = " + txt_upisnica.Text;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(naredba, veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
                grid_populate();
            }
            catch (Exception Greska)
            {
                MessageBox.Show(Greska.Message);
            }
        }
    }
}
