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
    public partial class Mitarbeiter_erfassung : Form
    {
        MySqlConnection conn = DButils.GetDBConnection();
        public Mitarbeiter_erfassung()
        {
            InitializeComponent();
         

            
        }

        private void btn_end_Click(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
        
        private void btn_Verbindung_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connection successful!!");
            conn.Open();
        }
        private void btn_eintragen_Click(object sender, EventArgs e)
        {
            eintragung();
           
        }

        public void eintragung()
        {
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            String sql = "Insert into Mitarbeiter (Vorname, Nachname, Aktiv) values (@vn,@nn,@A)";


            String vn = tbt_VN.Text;
            String nn = tbt_NN.Text;
            int A = Convert.ToInt16(tbt_A.Text);
            //int mid = Convert.ToInt16(tbt_mid.Text);

            

            

            cmd.CommandText = sql;

            //cmd.Parameters.Add("@mid", MySqlDbType.Int16).Value = mid;
            cmd.Parameters.Add("@vn", MySqlDbType.VarChar, 20).Value = vn;
            cmd.Parameters.Add("@nn", MySqlDbType.VarChar, 30).Value = nn;
            cmd.Parameters.Add("@A", MySqlDbType.Int16).Value = A;
            

            cmd.ExecuteNonQuery();

            conn.Close();

        }

       
    }
}
