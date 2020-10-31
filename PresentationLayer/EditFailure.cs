using DataAccessLayer;
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
    public partial class EditFailure : Form
    {
        private bool dateChanged = false;
        private FailureRepository _failureRepository = new FailureRepository();
        Failure _failure = new Failure();

        public EditFailure(Failure failure)
        {
            InitializeComponent();

            _failure = failure;
        }

        private void EditFailure_Load(object sender, EventArgs e)
        {
            lblFailure.Text = _failure.Id.ToString();
            int typeOfFailureId = _failure.Id_TypeOfFailure;
            lblTypeOfFailure.Text = _failureRepository.GetTypeOfFailureById(typeOfFailureId);
            int userId = _failure.Id_Username;
            lblUsername.Text = _failureRepository.GetUserById(userId);
            int cityId = _failure.Id_City;
            lblCity.Text = _failureRepository.GetCityById(cityId);
            lblBeginDate.Text = _failure.BeginOfFailure.ToString();
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = " ";
            textBoxAdditionalDescription.Text = _failure.AdditionalDescription;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (dateChanged)
            {
                int result = DateTime.Compare(Convert.ToDateTime(dateTimePickerEnd.Value), Convert.ToDateTime(lblBeginDate.Text));

                if(result == -1 || result == 0)
                {
                    MessageBox.Show("Uneseni datum završetka ispada: " + dateTimePickerEnd.Value + " je raniji ili jednak datumu početka ispada. Unesite novi datum završetka ispada!");
                }
                else
                {
                    _failure.EndOfFailure = dateTimePickerEnd.Value;
                    _failure.AdditionalDescription = textBoxAdditionalDescription.Text;
                    _failureRepository.UpdateFailure(_failure);

                    UserControlActiveFailures.Instance.RefreshList();
                    UserControlHistoryOfFailures.Instance.RefreshList();
                }
            }
            else
            {
                _failure.AdditionalDescription = textBoxAdditionalDescription.Text;
                _failureRepository.UpdateFailureWithoutDate(_failure);

                UserControlActiveFailures.Instance.RefreshList();
                UserControlHistoryOfFailures.Instance.RefreshList();

            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
            dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm:ss";
        }
    }
}
