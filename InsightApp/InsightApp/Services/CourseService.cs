using InsightApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace InsightApp.Services
{
    public class CourseService
    {

        private SqlConnection GetConnection(string _connection_string)
        {
            return new SqlConnection(_connection_string);
        }

        public IEnumerable<Course> GetCourses(string _connection_string)
        {
            List<Course> _lst = new List<Course>();
            string _statement = "SELECT CourseID,CourseName,rating from Course";
            SqlConnection _connection = GetConnection(_connection_string);
            _connection.Open();
            SqlCommand _sqlcommand = new SqlCommand(_statement, _connection);
            using (SqlDataReader _reader = _sqlcommand.ExecuteReader())
            {
                while (_reader.Read())
                {
                    Course _course = new Course()
                    {
                        CourseID = _reader.GetInt32(0),
                        CourseName = _reader.GetString(1),
                        Rating = _reader.GetDecimal(2)
                    };

                    _lst.Add(_course);
                }
            }
            _connection.Close();
            return _lst;
        }

        public void UpdateCourse(Course p_course, string _connection_string)
        {
            StringBuilder _statement = new StringBuilder("UPDATE Course SET Rating=");
            _statement.Append(p_course.Rating);
            _statement.Append(" WHERE CourseID=");
            _statement.Append(p_course.CourseID);

            SqlConnection _connection = GetConnection(_connection_string);
            _connection.Open();
            SqlCommand _sqlcommand = new SqlCommand(_statement.ToString(), _connection);
            _sqlcommand.ExecuteNonQuery();

        }

        public Course GetCourse(string id, string _connection_string)
        {
            IEnumerable<Course> _courses = this.GetCourses(_connection_string);
            Course _course = _courses.FirstOrDefault(m => m.CourseID == Int32.Parse(id));
            return _course;
        }
    }
}
