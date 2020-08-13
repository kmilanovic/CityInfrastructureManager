using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class UserControlHistoryOfFailures : UserControl
    {
        private static UserControlHistoryOfFailures _instance;
        public static UserControlHistoryOfFailures Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlHistoryOfFailures();
                }
                return _instance;
            }
        }

        public FailureRepository _failureRepository = new FailureRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public BindingSource _historyOfFailuresBindingSource = new BindingSource();
        public UserControlHistoryOfFailures()
        {
            InitializeComponent();

            _tableBindingSource.DataSource = _failureRepository.GetFailures();
            _historyOfFailuresBindingSource.DataSource = _failureRepository.GetHistoryOfFailures();
        }

        private void UserControlHistoryOfFailures_Load(object sender, EventArgs e)
        {
            dataGridViewHistoryOfFailures.DataSource = _historyOfFailuresBindingSource;

            dataGridViewHistoryOfFailures.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        public void RefreshList()
        {
            dataGridViewHistoryOfFailures.DataSource = _failureRepository.GetHistoryOfFailures();
        }
    }
}
