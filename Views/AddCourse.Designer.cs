namespace TutionManagementSystem.Views
{
    partial class AddCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourse));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCourseName = new System.Windows.Forms.TextBox();
            this.Students = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourse = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTeacher = new System.Windows.Forms.ToolStripMenuItem();
            this.addTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEmployees = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPendingRequest = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCourseId = new System.Windows.Forms.TextBox();
            this.textBoxCourseFee = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Students.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(149, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // textBoxCourseName
            // 
            this.textBoxCourseName.Location = new System.Drawing.Point(280, 71);
            this.textBoxCourseName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCourseName.Multiline = true;
            this.textBoxCourseName.Name = "textBoxCourseName";
            this.textBoxCourseName.Size = new System.Drawing.Size(253, 31);
            this.textBoxCourseName.TabIndex = 1;
            // 
            // Students
            // 
            this.Students.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Students.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHome,
            this.MenuItemCourse,
            this.MenuItemTeacher,
            this.MenuItemStudent,
            this.MenuItemEmployees,
            this.MenuItemPendingRequest});
            this.Students.Location = new System.Drawing.Point(0, 0);
            this.Students.Name = "Students";
            this.Students.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.Students.Size = new System.Drawing.Size(778, 24);
            this.Students.TabIndex = 8;
            this.Students.Text = "menuStrip1";
            // 
            // toolStripMenuItemHome
            // 
            this.toolStripMenuItemHome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.toolStripMenuItemHome.Name = "toolStripMenuItemHome";
            this.toolStripMenuItemHome.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItemHome.Text = "Home Page";
            this.toolStripMenuItemHome.Click += new System.EventHandler(this.toolStripMenuItemHome_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // MenuItemCourse
            // 
            this.MenuItemCourse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem});
            this.MenuItemCourse.Name = "MenuItemCourse";
            this.MenuItemCourse.Size = new System.Drawing.Size(56, 20);
            this.MenuItemCourse.Text = "Course";
            this.MenuItemCourse.Click += new System.EventHandler(this.MenuItemCourse_Click);
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            // 
            // MenuItemTeacher
            // 
            this.MenuItemTeacher.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTeacherToolStripMenuItem});
            this.MenuItemTeacher.Name = "MenuItemTeacher";
            this.MenuItemTeacher.Size = new System.Drawing.Size(64, 20);
            this.MenuItemTeacher.Text = "Teachers";
            // 
            // addTeacherToolStripMenuItem
            // 
            this.addTeacherToolStripMenuItem.Name = "addTeacherToolStripMenuItem";
            this.addTeacherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addTeacherToolStripMenuItem.Text = "Add Teacher";
            // 
            // MenuItemStudent
            // 
            this.MenuItemStudent.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem});
            this.MenuItemStudent.Name = "MenuItemStudent";
            this.MenuItemStudent.Size = new System.Drawing.Size(65, 20);
            this.MenuItemStudent.Text = "Students";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            // 
            // MenuItemEmployees
            // 
            this.MenuItemEmployees.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem});
            this.MenuItemEmployees.Name = "MenuItemEmployees";
            this.MenuItemEmployees.Size = new System.Drawing.Size(76, 20);
            this.MenuItemEmployees.Text = "Employees";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // MenuItemPendingRequest
            // 
            this.MenuItemPendingRequest.Name = "MenuItemPendingRequest";
            this.MenuItemPendingRequest.Size = new System.Drawing.Size(113, 20);
            this.MenuItemPendingRequest.Text = "Pending Requests";
            this.MenuItemPendingRequest.Click += new System.EventHandler(this.MenuItemPendingRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(149, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Course Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(149, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Course Fee";
            // 
            // textBoxCourseId
            // 
            this.textBoxCourseId.Location = new System.Drawing.Point(280, 126);
            this.textBoxCourseId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCourseId.Multiline = true;
            this.textBoxCourseId.Name = "textBoxCourseId";
            this.textBoxCourseId.Size = new System.Drawing.Size(253, 31);
            this.textBoxCourseId.TabIndex = 11;
            // 
            // textBoxCourseFee
            // 
            this.textBoxCourseFee.Location = new System.Drawing.Point(280, 179);
            this.textBoxCourseFee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCourseFee.Multiline = true;
            this.textBoxCourseFee.Name = "textBoxCourseFee";
            this.textBoxCourseFee.Size = new System.Drawing.Size(253, 31);
            this.textBoxCourseFee.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(541, 249);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 46);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(392, 249);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(128, 46);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(242, 249);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(128, 46);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(9, 320);
            this.dataGridViewCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowHeadersWidth = 51;
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(760, 206);
            this.dataGridViewCourses.TabIndex = 16;
            this.dataGridViewCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCourses_CellContentClick);
            this.dataGridViewCourses.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SelectRow);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(778, 535);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxCourseFee);
            this.Controls.Add(this.textBoxCourseId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.textBoxCourseName);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            this.Students.ResumeLayout(false);
            this.Students.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCourseName;
        private System.Windows.Forms.MenuStrip Students;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHome;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCourse;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTeacher;
        private System.Windows.Forms.ToolStripMenuItem addTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemStudent;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEmployees;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPendingRequest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCourseId;
        private System.Windows.Forms.TextBox textBoxCourseFee;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
    }
}