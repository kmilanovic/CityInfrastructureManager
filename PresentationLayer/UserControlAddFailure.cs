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
    public partial class UserControlAddFailure : UserControl
    {
        Login login = new Login();
        public string userName= "";
        private static UserControlAddFailure _instance;
        public static UserControlAddFailure Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UserControlAddFailure();
                }
                return _instance;
            }
        }

        public FailureRepository _failureRepository = new FailureRepository();
        public BindingSource _tableBindingSource = new BindingSource();
        public BindingSource _countiesBindingSource = new BindingSource();
        public BindingSource _typesOfFailureBindingSource = new BindingSource();
        public BindingSource _historyOfFailuresBindingSource = new BindingSource();

        public UserControlAddFailure()
        {
            InitializeComponent();

            _tableBindingSource.DataSource = _failureRepository.GetFailures();
            _countiesBindingSource.DataSource = _failureRepository.GetComboBoxCounties();
            _typesOfFailureBindingSource.DataSource = _failureRepository.GetComboBoxTypesOfFailure();
            _historyOfFailuresBindingSource.DataSource = _failureRepository.GetHistoryOfFailures();
        }

        private void UserControlAddFailure_Load(object sender, EventArgs e)
        {
            userName = Login.userName;
            comboBoxCounties.DataSource = _countiesBindingSource;
            comboBoxTypesOfFailure.DataSource = _typesOfFailureBindingSource;
        }

        private void comboBoxCounties_SelectedIndexChanged(object sender, EventArgs e)
        {
            string county = comboBoxCounties.SelectedValue.ToString();
            comboBoxCities.DataSource = _failureRepository.GetCitiesByCounty(county);
        }

        private void btnInsertFailure_Click(object sender, EventArgs e)
        {
             var user = _failureRepository.GetUserByUsername(userName);
             int userId = user.Id;


            string countyComboBox = comboBoxCounties.SelectedValue.ToString();
            var county = _failureRepository.GetCountyComboBoxValue(countyComboBox);
            int countyId = county.Id;

            string cityComboBox = comboBoxCities.SelectedValue.ToString();
            var city = _failureRepository.GetCityComboBoxValue(cityComboBox);
            int cityId = city.Id;

            string typeOfFailureComboBox = comboBoxTypesOfFailure.SelectedValue.ToString();
            var typeOfFailure = _failureRepository.GetTypeOfFailureComboBoxValue(typeOfFailureComboBox);
            int typeOfFailureId = typeOfFailure.Id;

            string additionalDescription = richTextBoxAdditionalDescription.Text.ToString();

            dateTimePickerBeginOfFailure.Value = DateTime.UtcNow.ToLocalTime();
            var dateTimeFrom = Convert.ToDateTime(dateTimePickerBeginOfFailure.Value);


            var failure = new Failure
            {
                Id_Username = userId,
                Id_TypeOfFailure = typeOfFailureId,
                Id_City = cityId,
                BeginOfFailure = dateTimeFrom,
                AdditionalDescription = additionalDescription
            };
            _failureRepository.AddFailure(failure);
        }
    }
}
