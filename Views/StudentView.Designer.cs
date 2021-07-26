namespace TutionManagementSystem.Views
{
    partial class StudentView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentView));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridViewInformation = new System.Windows.Forms.DataGridView();
            this.dataGridViewCourses = new System.Windows.Forms.DataGridView();
            this.Info = new System.Windows.Forms.Label();
            this.Courses = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.viewInformationToolStripMenuItem,
            this.takeCourseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1141, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // viewInformationToolStripMenuItem
            // 
            this.viewInformationToolStripMenuItem.Name = "viewInformationToolStripMenuItem";
            this.viewInformationToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.viewInformationToolStripMenuItem.Text = "Update Information";
            this.viewInformationToolStripMenuItem.Click += new System.EventHandler(this.viewInformationToolStripMenuItem_Click);
            // 
            // takeCourseToolStripMenuItem
            // 
            this.takeCourseToolStripMenuItem.Name = "takeCourseToolStripMenuItem";
            this.takeCourseToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.takeCourseToolStripMenuItem.Text = "Take Course";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridViewInformation
            // 
            this.dataGridViewInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInformation.Location = new System.Drawing.Point(513, 62);
            this.dataGridViewInformation.Name = "dataGridViewInformation";
            this.dataGridViewInformation.RowTemplate.Height = 24;
            this.dataGridViewInformation.Size = new System.Drawing.Size(598, 207);
            this.dataGridViewInformation.TabIndex = 1;
            // 
            // dataGridViewCourses
            // 
            this.dataGridViewCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCourses.Location = new System.Drawing.Point(513, 338);
            this.dataGridViewCourses.Name = "dataGridViewCourses";
            this.dataGridViewCourses.RowTemplate.Height = 24;
            this.dataGridViewCourses.Size = new System.Drawing.Size(598, 207);
            this.dataGridViewCourses.TabIndex = 2;
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Location = new System.Drawing.Point(463, 37);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(73, 16);
            this.Info.TabIndex = 3;
            this.Info.Text = "Information";
            // 
            // Courses
            // 
            this.Courses.AutoSize = true;
            this.Courses.Location = new System.Drawing.Point(478, 310);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(58, 16);
            this.Courses.TabIndex = 4;
            this.Courses.Text = "Courses";
            // 
            // StudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 593);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.dataGridViewCourses);
            this.Controls.Add(this.dataGridViewInformation);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentView";
            this.Text = "Student Information";
            this.Load += new System.EventHandler(this.StudentView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeCourseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dataGridViewInformation;
        private System.Windows.Forms.DataGridView dataGridViewCourses;
        private System.Windows.Forms.Label Info;
        private System.Windows.Forms.Label Courses;
    }
}