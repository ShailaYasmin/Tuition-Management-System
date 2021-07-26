using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using TutionManagementSystem.Models;

namespace TutionManagementSystem.Controllers
{
    class CourseViewController
    {
        static Database db = new Database();
        public static ArrayList GetAllCourses()
        {
            return db.Courses.GetAllCourses();
        }
        public static void AddCourse(string courseName, string courseId, string courseFee)

        {
            Course u = new Course()
            {

               CourseName=courseName,
               CourseFee=courseFee,
               CourseId=courseId
               

            };
            db.Courses.AddCourse(u);

        }
        public static void UpdateCourse(string courseName, string courseId, string courseFee)

        {
            Course u = new Course()
            {

                CourseName = courseName,
                CourseFee = courseFee,
                CourseId = courseId


            };
            db.Courses.UpdateCourse(u);

        }
        public static void DeleteCourse(string courseName, string courseId, string courseFee)

        {
            Course u = new Course()
            {

                CourseName = courseName,
                CourseFee = courseFee,
                CourseId = courseId


            };
            db.Courses.DeleteCourse(u);

        }
    }
}
