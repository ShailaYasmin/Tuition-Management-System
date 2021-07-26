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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void SignUpFprmStudent_Load(object sender, EventArgs e)
        {
            radioButtonMale.Checked = true;
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignUpNext_Click(object sender, EventArgs e)
        {


            dynamic item= (string)comboBoxUserType.SelectedItem;
            //dynamic d = comboBoxDepts.SelectedItem;
            dynamic gender;
            if (radioButtonMale.Checked == true)
            {
                gender = radioButtonMale.Text;
            }
            else if (radioButtonFemale.Checked == true)
            {
                gender = radioButtonMale.Text;
            }
            //SignUpController.AddUser(textBoxName.Text,textBoxUsername.Text,textBoxId.Text,textBoxPassword.Text,textBoxEmail.Text,textBoxAddress.Text,textBoxPhone.Text,item,textBoxDateOfBirth.Text,"No",gender);
            //dataGridViewUsers.DataSource = UserController.GetAllUsers();

            if (item == "Students")
            {
                this.Hide();
                new SignUpFormStudent(this).Show();
            }
            else if(item == "Teachers")
            {
                this.Hide();
                new SignUpFormTeacher(this).Show();
            } else if(item == "Employees")
            {
                this.Hide();
                new SignUpFormEmployee(this).Show();
            }

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDateOfBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
    }

