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
    public partial class StudentView : Form
    {
        string f1;
        public StudentView(string s)
        {
            InitializeComponent();
            this.f1 = s;
        }

        private void viewInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void StudentView_Load(object sender, EventArgs e)
        {
            dataGridViewInformation.DataSource = UserController.GetStudent(f1);
            dataGridViewCourses.DataSource = UserController.GetAllCourses();

        }
    }
}
