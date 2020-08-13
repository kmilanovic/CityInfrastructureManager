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
    public partial class UserControlActiveFailures : UserControl
    {
        private static UserControlActiveFailures _instance;
        public static UserControlActiveFailures Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlActiveFailures();
                }
                return _instance;
            }
        }

        public FailureRepository _failureRepository = new FailureRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public UserControlActiveFailures()
        {
            InitializeComponent();

            _tableBindingSource.DataSource = _failureRepository.GetFailures();
        }

        private void UserControlActiveFailures_Load(object sender, EventArgs e)
        {
            dataGridViewActiveFailures.DataSource = _tableBindingSource;

            dataGridViewActiveFailures.AutoGenerateColumns = false;
            dataGridViewActiveFailures.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("C:\\Users\\Kristijan\\Documents\\Visual Studio 2015\\Projects\\CityInfrastructureManager_ZavrsniRad\\PresentationLayer\\Resources\\trash.png");

            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewActiveFailures.Columns.Add(oDeleteButton);
            dataGridViewActiveFailures.Columns[7].HeaderText = "Obriši";
        }

        public void RefreshList()
        {
            dataGridViewActiveFailures.DataSource = _failureRepository.GetFailures();
        }

        private void dataGridViewActiveFailures_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewActiveFailures.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                var id = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[0].Value.ToString());
                var id_username = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[1].Value.ToString());
                var id_type_of_failure = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[2].Value.ToString());
                var id_city = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[3].Value.ToString());
                var begin_of_failure = Convert.ToDateTime(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[4].Value);
                var additional_description = dataGridViewActiveFailures.Rows[e.RowIndex].Cells[6].Value.ToString();

                var failure = new Failure
                {
                    Id = id,
                    Id_Username = id_username,
                    Id_TypeOfFailure = id_type_of_failure,
                    Id_City = id_city,
                    BeginOfFailure = begin_of_failure,
                    AdditionalDescription = additional_description
                };
                _failureRepository.DeleteFailure(failure);
                RefreshList();
            }            
        }

        private void dataGridViewActiveFailures_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewActiveFailures.SelectedRows)
            {
                var id = Convert.ToInt32(row.Cells[0].Value.ToString());
                var id_username = Convert.ToInt32(row.Cells[1].Value.ToString());
                var id_type_of_failure = Convert.ToInt32(row.Cells[2].Value.ToString());
                var id_city = Convert.ToInt32(row.Cells[3].Value.ToString());
                var begin_of_failure = Convert.ToDateTime(row.Cells[4].Value.ToString());
                var additional_description = row.Cells[6].Value.ToString();
            }
        }

        private void dataGridViewActiveFailures_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[0].Value.ToString());
            var id_username = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[1].Value.ToString());
            var id_type_of_failure = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[2].Value.ToString());
            var id_city = Convert.ToInt32(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[3].Value.ToString());
            var begin_of_failure = Convert.ToDateTime(dataGridViewActiveFailures.Rows[e.RowIndex].Cells[4].Value);
            var additional_description = dataGridViewActiveFailures.Rows[e.RowIndex].Cells[6].Value.ToString();

            var failure = new Failure
            {
                Id = id,
                Id_Username = id_username,
                Id_TypeOfFailure = id_type_of_failure,
                Id_City = id_city,
                BeginOfFailure = begin_of_failure,
                AdditionalDescription = additional_description
            };

            EditFailure formEditFailure = new EditFailure(failure);
            formEditFailure.Show();
        }
    }
}
