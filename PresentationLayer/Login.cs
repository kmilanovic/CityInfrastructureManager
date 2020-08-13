using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Login : Form
    {
        public static string userName = "";
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        SqlDataReader sdr;
        public Login()
        {
            InitializeComponent();

            connection.ConnectionString = @"Server = 193.198.57.183; Database = PIS_TEST; User Id = student; Password = student";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "SELECT korisnicko_ime, lozinka FROM [03_Korisnik] WHERE korisnicko_ime ='" + textBoxUsername.Text + "' AND lozinka= '" + textBoxPassword.Text + "'";
            sdr = command.ExecuteReader();
            if (sdr.Read())
            {
                userName = textBoxUsername.Text;
                this.Hide();
                InfrastructureFailureManager infrastructureFailureManager = new InfrastructureFailureManager();
                infrastructureFailureManager.Closed += (s, args) => this.Close();
                infrastructureFailureManager.Show();

            }
            else
            {
                MessageBox.Show("Korisničko ime ili lozinka su netočni", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
    }
}
