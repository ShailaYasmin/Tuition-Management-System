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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        private void MenuItemPendingRequest_Click(object sender, EventArgs e)
        {

        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            dataGridViewCourses.DataSource = CourseViewController.GetAllCourses();
            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            CourseViewController.AddCourse(textBoxCourseName.Text,textBoxCourseId.Text,textBoxCourseFee.Text);
            dataGridViewCourses.DataSource = CourseViewController.GetAllCourses();

        }

        private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SelectRow(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow rw = dataGridViewCourses.CurrentRow;
            // MessageBox.Show(rw.Cells["Username"].Value.ToString());
            textBoxCourseName.Text = rw.Cells["CourseName"].Value.ToString();
            textBoxCourseId.Text = rw.Cells["CourseId"].Value.ToString(); 
            textBoxCourseFee.Text = rw.Cells["CourseFee"].Value.ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            CourseViewController.UpdateCourse(textBoxCourseName.Text, textBoxCourseId.Text, textBoxCourseFee.Text);
            dataGridViewCourses.DataSource = CourseViewController.GetAllCourses();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            CourseViewController.DeleteCourse(textBoxCourseName.Text, textBoxCourseId.Text, textBoxCourseFee.Text);
            dataGridViewCourses.DataSource = CourseViewController.GetAllCourses();
        }

        private void toolStripMenuItemHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminView().Show();
        }

        private void MenuItemCourse_Click(object sender, EventArgs e)
        {
            this.Hide();
            new  AdminView().Show();
        }
    }
}
