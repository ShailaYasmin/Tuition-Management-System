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
    public partial class SignUpFormStudent : Form
    {
        SignUpForm f1;
        public SignUpFormStudent(SignUpForm rechiveForm)
        {
            InitializeComponent();
            this.f1 = rechiveForm;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            dynamic type = (string)f1.comboBoxUserType.SelectedItem;
            dynamic clas = (string)comboBoxClass.SelectedItem;
            dynamic group = (string)comboBoxGroup.SelectedItem;
            dynamic medium = (string)comboBoxMedium.SelectedItem;
            string username = "ST-" + f1.textBoxId.Text;
            //dynamic d = comboBoxDepts.SelectedItem;
            dynamic gender=null;
            if (f1.radioButtonMale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            else if (f1.radioButtonFemale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            
            SignUpController.AddUser(f1.textBoxName.Text, username, f1.textBoxId.Text, f1.textBoxPassword.Text, f1.textBoxEmail.Text, f1.textBoxAddress.Text, f1.textBoxPhone.Text, type, f1.textBoxDateOfBirth.Text, "No", gender);
            SignUpController.AddUserStudent(textBoxId.Text, clas, group, medium, username);
            this.Hide();
            new Login().Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpFormStudent_Load(object sender, EventArgs e)
        {
            string username = "ST-" + f1.textBoxId.Text;
            textBoxUsername.ReadOnly = true;
            textBoxId.ReadOnly = true;
            textBoxUsername.Text = username;
            textBoxId.Text = f1.textBoxId.Text;
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
