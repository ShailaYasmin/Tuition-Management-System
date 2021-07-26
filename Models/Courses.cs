using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace TutionManagementSystem.Models
{
    public class Courses
    {
        SqlConnection conn;
        public Courses()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-NEA3P59\SQLEXPRESS;Initial Catalog=TutionManagement;Integrated Security=True");
        }
        public ArrayList GetAllCourses()
        {
            ArrayList courses = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Courses";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Course u = new Course()
                {

                    CourseName = reader.GetString(reader.GetOrdinal("CourseName")),
                    CourseId = reader.GetString(reader.GetOrdinal("CourseId")),
                    CourseFee = reader.GetString(reader.GetOrdinal("CourseFee"))
                   

                };
                courses.Add(u);
            }
            
            conn.Close();
            return  courses;
        }

        public void AddCourse(Course a)
        {
            conn.Open();

            string query = "INSERT INTO Courses(CourseName,CourseId,CourseFee) Values ( '" + a.CourseName + "','" + a.CourseId + "','" + a.CourseFee + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void UpdateCourse(Course a)
        {
            conn.Open();

            string query = "Update Courses set CourseName='" + a.CourseName +"',CourseFee='"+ a.CourseFee + "' where CourseId='"+ a.CourseId +"'" ;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteCourse(Course a)
        {
            conn.Open();

            string query = "DELETE FROM Courses WHERE CourseId='"+a.CourseId +"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
