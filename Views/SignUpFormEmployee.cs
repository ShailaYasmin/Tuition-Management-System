using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TutionManagementSystem.Controllers;

namespace TutionManagementSystem.Views
{
    public partial class SignUpFormEmployee : Form
    {
        SignUpForm f1;
        public SignUpFormEmployee(SignUpForm rechiveForm)
        {
            InitializeComponent();
            this.f1 = rechiveForm;

        }

        private void SignUpFormEmployee_Load(object sender, EventArgs e)
        {
            string username = "E-" + f1.textBoxId.Text;
            textBoxUsername.ReadOnly = true;
            textBoxId.ReadOnly = true;
            textBoxId.Text = f1.textBoxId.Text;
            textBoxUsername.Text = username;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            dynamic type = (string)f1.comboBoxUserType.SelectedItem;
            dynamic position = (string)comboBoxPosition.SelectedItem;
            dynamic gender = null;
            string username = "E-" + f1.textBoxId.Text;
            if (f1.radioButtonMale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            else if (f1.radioButtonFemale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            
            SignUpController.AddUser(f1.textBoxName.Text, username, f1.textBoxId.Text, f1.textBoxPassword.Text, f1.textBoxEmail.Text, f1.textBoxAddress.Text, f1.textBoxPhone.Text, type, f1.textBoxDateOfBirth.Text, "No", gender);
            SignUpController.AddUserEmployee(textBoxId.Text, position, richTextBoxQualification.Text, richTextBoxExperience.Text,username);
            this.Hide();
            new Login().Show();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBoxQualification_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxPosition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
