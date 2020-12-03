using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lagerverwaltung
{
    public partial class Mitarbeiter : Form
    {
        MySqlConnection conn = DButils.GetDBConnection();
        private MySqlDataAdapter da;        // Data Adapter
        private DataSet ds;                 // Dataset
        private string sTable = "mitarbeiter";  // Table Name
        public Mitarbeiter()
        {
            InitializeComponent();
            
        }

        public void ausgabe()
        {
            da = new MySqlDataAdapter("SELECT * FROM mitarbeiter;", conn);
            ds = new DataSet();
            da.Fill(ds, sTable);
            conn.Close();
            dataGridView1.Refresh();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = sTable;
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            DialogResult ende = MessageBox.Show("Wollen Sie das Programm wirklich beenden?", "Abfrage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ende == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (ende == DialogResult.No)
            {


            }
        }

        private void btn_erfassen_Click(object sender, EventArgs e)
        {
            Mitarbeiter_erfassung erfassung = new Mitarbeiter_erfassung();

            erfassung.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            ausgabe();
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(da);
            da.Update(ds, sTable);
            dataGridView1.CancelEdit();
        }

        private void Bearbeiten_Click(object sender, EventArgs e)
        {

        }
    }
}
