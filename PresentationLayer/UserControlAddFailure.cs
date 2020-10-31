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
        private bool dateChanged = false;
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
        public BindingSource _countiesBindingSource = new BindingSource();
        public BindingSource _typesOfFailureBindingSource = new BindingSource();
        public BindingSource _historyOfFailuresBindingSource = new BindingSource();

        private UserControlAddFailure()
        {
            InitializeComponent();

            _countiesBindingSource.DataSource = _failureRepository.GetCountiesComboBox();
            _typesOfFailureBindingSource.DataSource = _failureRepository.GetTypesOfFailureComboBox();
        }

        private void UserControlAddFailure_Load(object sender, EventArgs e)
        {
            userName = Login.userName;
            comboBoxCounties.DataSource = _countiesBindingSource;
            comboBoxTypesOfFailure.DataSource = _typesOfFailureBindingSource;
        }

        private void comboBoxCounties_SelectedIndexChanged(object sender, EventArgs e)
        {
            var countyName = comboBoxCounties.SelectedItem.ToString();
            comboBoxCities.DataSource = _failureRepository.GetCitiesByCountyComboBox(countyName);
        }

        private void btnInsertFailure_Click(object sender, EventArgs e)
        {
            if (comboBoxCounties.SelectedIndex > 0 && comboBoxCities.SelectedIndex > 0 && comboBoxTypesOfFailure.SelectedIndex > 0)
            {
                int userId = _failureRepository.GetUserIdByString(userName);

                string countyComboBox = comboBoxCounties.SelectedItem.ToString();
                int countyId = _failureRepository.GetCountyIdByString(countyComboBox);

                string cityCombobox = comboBoxCities.SelectedItem.ToString();
                int cityId = _failureRepository.GetCityIdByString(cityCombobox);

                string typeOfFailureCombobox = comboBoxTypesOfFailure.SelectedItem.ToString();
                int typeOfFailureId = _failureRepository.GetTypeOfFailureIdByString(typeOfFailureCombobox);

                string additionalDescription = richTextBoxAdditionalDescription.Text.ToString();

                if (dateChanged)
                {
                    var dateTimeFromChanged = dateTimePickerBeginOfFailure.Value;

                    var failure = new Failure
                    {
                        Id_Username = userId,
                        Id_TypeOfFailure = typeOfFailureId,
                        Id_City = cityId,
                        BeginOfFailure = dateTimeFromChanged,
                        AdditionalDescription = additionalDescription
                    };
                    _failureRepository.AddFailure(failure);

                }
                else
                {
                    var dateTimeFrom = dateTimePickerBeginOfFailure.Value;

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
            else
            {
                MessageBox.Show("Odaberite županiju, grad i vrstu ispada!");
            }    
        }

        private void dateTimePickerBeginOfFailure_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }
    }
}
