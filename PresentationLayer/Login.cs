using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        string connectionString = "Server = 193.198.57.183; Database = PIS_TEST; User Id = student; Password = student";
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (DbConnection oConnection = new SqlConnection(connectionString))
            using (DbCommand oCommand = oConnection.CreateCommand())
            {
                oCommand.CommandText = "SELECT korisnicko_ime, lozinka FROM [03_Korisnik] WHERE korisnicko_ime ='" + textBoxUsername.Text + "' AND lozinka= '" + textBoxPassword.Text + "'";
                oConnection.Open();
                using (DbDataReader oReader = oCommand.ExecuteReader())
                {
                    if(oReader.Read())
                    {
                        userName = textBoxUsername.Text;
                        this.Hide();
                        InfrastructureFailureManager infrastructureFailureManager = new InfrastructureFailureManager();
                        infrastructureFailureManager.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        lblWrongUsernameOrPassword.Text = "Netočno korisničko ime ili lozinka!";
                        textBoxUsername.Clear();
                        textBoxPassword.Clear();
                    }
                }
            }    
        }
    }
}
