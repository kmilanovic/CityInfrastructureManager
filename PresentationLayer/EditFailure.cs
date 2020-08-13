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
            dateTimePickerBegin.Value = _failure.BeginOfFailure;
            dateTimePickerEnd.CustomFormat = " ";
            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.ValueChanged += new System.EventHandler(dateTimePickerEnd_ValueChanged);
            textBoxAdditionalDescription.Text = _failure.AdditionalDescription;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (dateChanged)
            {
                _failure.Id = Int32.Parse(lblFailure.Text);
                string typeOfFailure = lblTypeOfFailure.Text;
                _failure.Id_TypeOfFailure = _failureRepository.GetTypeOfFailureIdByString(typeOfFailure);
                string username = lblUsername.Text;
                _failure.Id_Username = _failureRepository.GetUserIdByString(username);
                string city = lblCity.Text;
                _failure.Id_City = _failureRepository.GetCityIdByString(city);
                _failure.BeginOfFailure = dateTimePickerBegin.Value;
                _failure.EndOfFailure = dateTimePickerEnd.Value;
                _failure.AdditionalDescription = textBoxAdditionalDescription.Text;

                _failureRepository.UpdateFailure(_failure);
            }
            else
            {
                _failure.Id = Int32.Parse(lblFailure.Text);
                string typeOfFailure = lblTypeOfFailure.Text;
                _failure.Id_TypeOfFailure = _failureRepository.GetTypeOfFailureIdByString(typeOfFailure);
                string username = lblUsername.Text;
                _failure.Id_Username = _failureRepository.GetUserIdByString(username);
                string city = lblCity.Text;
                _failure.Id_City = _failureRepository.GetCityIdByString(city);
                _failure.BeginOfFailure = dateTimePickerBegin.Value;
                _failure.AdditionalDescription = textBoxAdditionalDescription.Text;

                _failureRepository.UpdateFailureWithoutDate(_failure);
            }
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.CustomFormat = "dd.MM.yyyy HH:mm:ss";
            dateChanged = true;

            if (!string.IsNullOrEmpty(dateTimePickerEnd.Value.ToString()))
            {
                Convert.ToDateTime(dateTimePickerEnd.Value);
            }
            else
            {
                dateTimePickerEnd.Value = Convert.ToDateTime(_failure.EndOfFailure);
            }
        }
    }
}
