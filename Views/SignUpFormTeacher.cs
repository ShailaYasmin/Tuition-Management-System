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
    public partial class SignUpFormTeacher : Form
    {
         SignUpForm f1 = new SignUpForm();
        public SignUpFormTeacher(SignUpForm rechiveForm)
        {
            InitializeComponent();
            this.f1 = rechiveForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dynamic type = (string)f1.comboBoxUserType.SelectedItem;
            string Text = "";
            string username = "T-" + f1.textBoxId.Text;
            /*  foreach(string s in checkedListBoxSubject.CheckedItems)
              {
                  make(s);
              }*/


            for (int i = 0; i < checkedListBoxSubject.CheckedItems.Count; i++)
            {

                Text = Text + checkedListBoxSubject.CheckedItems[i] + ",";

            }


            //dynamic  str =  checkedListBoxSubject.CheckedItems.ToString();

            /*for (int i = 0; i <   checkedListBoxSubject.Items.Count; i++)
            {
                if (checkedListBoxSubject.Items[i] == true)// getting selected value from CheckBox List  
                {
                    str += CheckboxList1.Items[i].Text + " ," + "<br/>"; // add selected Item text to the String .  
                }


            }
            if (str != "")
            {
                str = str.Substring(0, str.Length - 7); // Remove Last "," from the string .  
                lblmsg.Text = "Selected Cities are <br/><br/>" + str; // Show selected Item List by Label.  
            }
            */

            dynamic gender = null;
            if (f1.radioButtonMale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }
            else if (f1.radioButtonFemale.Checked == true)
            {
                gender = f1.radioButtonMale.Text;
            }

            string medium = listBoxMedium.SelectedItem.ToString();
            
            SignUpController.AddUser(f1.textBoxName.Text,username, f1.textBoxId.Text, f1.textBoxPassword.Text, f1.textBoxEmail.Text, f1.textBoxAddress.Text, f1.textBoxPhone.Text, type, f1.textBoxDateOfBirth.Text, "No", gender);
            SignUpController.AddUserTeacher(textBoxId.Text, medium, Text, richTextBoxQualification.Text,username);
            this.Hide();
            new Login().Show();
        }

        private void SignUpFormTeacher_Load(object sender, EventArgs e)
        {
            string username = "T-" + f1.textBoxId.Text;
            textBoxUsername.ReadOnly = true;
            textBoxId.ReadOnly = true;
            textBoxId.Text = f1.textBoxId.Text;
            textBoxUsername.Text = username;
        }

        private void textBoxSubject_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
