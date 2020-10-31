using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class InfrastructureFailureManager : Form
    {
        private IconButton currentBtn;
        public InfrastructureFailureManager()
        {
            InitializeComponent();
        }

        private void ActivateButton(object sendrBtn)
        {
            if (sendrBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)sendrBtn;
                currentBtn.BackColor = Color.FromArgb(4, 83, 145);
                currentBtn.TextAlign = ContentAlignment.MiddleRight;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(33, 150, 243);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;  
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DisableButton();

            if (!panelBody.Controls.Contains(UserControlHomepage.Instance))
            {
                panelBody.Controls.Add(UserControlHomepage.Instance);
                UserControlHomepage.Instance.Dock = DockStyle.Fill;
                UserControlHomepage.Instance.BringToFront();
            }
            else
            {
                UserControlHomepage.Instance.BringToFront();
            }
        }

        private void iconButtonAddFailure_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

            if (!panelBody.Controls.Contains(UserControlAddFailure.Instance))
            {
                panelBody.Controls.Add(UserControlAddFailure.Instance);
                UserControlAddFailure.Instance.Dock = DockStyle.Fill;
                UserControlAddFailure.Instance.BringToFront();
            }
            else
            {
                UserControlAddFailure.Instance.BringToFront();
            }
        }

        private void iconButtonActiveFailures_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UserControlActiveFailures.Instance.RefreshList();

            if (!panelBody.Controls.Contains(UserControlActiveFailures.Instance))
            {
                panelBody.Controls.Add(UserControlActiveFailures.Instance);
                UserControlActiveFailures.Instance.Dock = DockStyle.Fill;
                UserControlActiveFailures.Instance.BringToFront();
            }
            else
            {
                UserControlActiveFailures.Instance.BringToFront();
            }
        }

        private void iconButtonHistoryOfFailures_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UserControlHistoryOfFailures.Instance.RefreshList();

            if (!panelBody.Controls.Contains(UserControlHistoryOfFailures.Instance))
            {
                panelBody.Controls.Add(UserControlHistoryOfFailures.Instance);
                UserControlHistoryOfFailures.Instance.Dock = DockStyle.Fill;
                UserControlHistoryOfFailures.Instance.BringToFront();
            }
            else
            {
                UserControlHistoryOfFailures.Instance.BringToFront();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        private void InfrastructureFailureManager_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.userName; //ovo malo bolje prouci i nauci. Staticka varijabla 

            if (!panelBody.Controls.Contains(UserControlHomepage.Instance))
            {
                panelBody.Controls.Add(UserControlHomepage.Instance);
                UserControlHomepage.Instance.Dock = DockStyle.Fill;
                UserControlHomepage.Instance.BringToFront();
            }
            else
            {
                UserControlHomepage.Instance.BringToFront();
            }
        }
    }
}
