using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MiniprojectStudentmanagement
{
    class AppEngine
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static SqlConnection getCon()
        {
            con = new SqlConnection(@"data source =RMGW58ZLPC0934\SQLEXPRESS; Initial Catalog= MiniprojectStudentmanagement; user=sa; password=Temp1234");
            con.Open();
            return con;
        }
        public void  Course_Details(Course course)
        {
            Console.WriteLine(course.Course_Id + "  " + course.Course_Name + "  " + course.Course_Duration + "  " + course.Course_Fees);
        }
        public void Student_Insert(Student student)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = getCon();

                cmd = new SqlCommand("INSERT INTO STUDENTS VALUES(@Student_Id,@Student_Name,@Student_Dob)", con);
                cmd.Parameters.AddWithValue("@Student_Id", student.Student_Id);
                cmd.Parameters.AddWithValue("@Student_Name", student.Student_Name);
                cmd.Parameters.AddWithValue("Student_Dob", student.Student_Dob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine(" Query Executed Succsesfully Row inserted.....");
                else
                    Console.WriteLine("Row Not Effected..... ");


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex); 
            }
            finally
            {

                con.Close();
            }
        }

   

        public void Details_Of_Student()
        {
            try
            {
                con = getCon();
                cmd = new SqlCommand("SELECT * FROM STUDENTS", con);
                dr= cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id Is....: " + dr[0] + "  " + "Student Name Is....: " + dr[1] + "  " + "Student Dob Is...: " + dr[2]);
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update_Student_Details()
        {
            try
            {
                
                Console.WriteLine("Enter Student Id.....:");
                int StudentId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student Name.....:");
                string StudentName = Console.ReadLine();
                Console.WriteLine("Enter Student Dob....:");
                string StudentDob = Console.ReadLine();
                con = getCon();
                cmd = new SqlCommand("UPDATE STUDENTS SET Student_Name=@S_Name,Student_Dob=@S_Dob where Student_Id=@s_Id",con);
                cmd.Parameters.AddWithValue("@S_Id", StudentId);
                cmd.Parameters.AddWithValue("@S_Name", StudentName);
                cmd.Parameters.AddWithValue("@S_Dob", StudentDob);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Query Executed Succsesfully Row Updated......");
                }
                else
                {
                    Console.WriteLine("Rows Not Updated.....");
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete_Perticular_Student()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter  Student Id is  :");
                int StudentId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("DELETE STUDENTS WHERE Student_Id=@Stu_id", con);
                cmd.Parameters.AddWithValue("@Stu_Id", StudentId);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Query Executed Succsesfully Row Delete.....");
                else
                    Console.WriteLine("Row Not Deleted......");
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Fatch_Only_One_Student()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter Student Id....:");
                int StudentId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("SELECT * FROM STUDENTS WHERE Student_Id =@S_id", con);
                cmd.Parameters.AddWithValue("@S_id", StudentId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Student Id : " + dr[0] + " " + "Student Name : " + dr[1] + " " + "Student DOB : " + dr[2]);
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }
        public void Details_Course_List()
        {
            try
            {
                con = getCon();
                cmd = new SqlCommand("SELECT * FROM COURSES", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id Is...: " + dr[0] + " Course Name Is....: " + dr[1] + " Course Duration Is....: " + dr[2] + " Course Fees is.... : " + dr[3]);
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Fatch_Only_One_Course()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter Course Id....: ");
                int CourseId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("SELECT * FROM COURSES WHERE Course_Id=@C_Id");
                cmd.Parameters.AddWithValue("@C_Id", CourseId);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("Course Id Is....: " + dr[0] + " Course Name Is.... : " + dr[1] + " Course Duration Is.... : " + dr[2] + " Course Fees is... : " + dr[3]);
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Update_The_Course()
        {
            try
            {
                Console.WriteLine("Enter Course Id......:");
                int CourseId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Duration....:");
                int CourseDuration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Course Fees.....:");
                float CourseFees = Convert.ToSingle(Console.ReadLine());
                con = getCon();
                cmd = new SqlCommand("UPDATE COURSES SET Course_Duration=@C_Duration,Course_Fees=@C_Fees WHERE Course_Id=@C_Id",con);
                cmd.Parameters.AddWithValue("@C_Id", CourseId);
                cmd.Parameters.AddWithValue("@C_Duration", CourseDuration);
                cmd.Parameters.AddWithValue("@C_Fees", CourseFees);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Query Executed Succsesfully Row Updated.....");
                }
                else
                {
                    Console.WriteLine("Row Not Updated......");
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Delete_Perticular_Course()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter Course Id ....:");
                int CourseId = Convert.ToInt32(Console.ReadLine());
                cmd = new SqlCommand("DELETE COURSES WHERE Course_Id=@C_Id", con);
                cmd.Parameters.AddWithValue("@C_Id", CourseId);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                    Console.WriteLine("Query Executed Succsesfully Row Deleted......");
                else
                    Console.WriteLine("Row Not Deleted.......");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void Course_Insert()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter Course Id..... :");
                int CourseId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Name..... :");
                string CourseName = Console.ReadLine();
                Console.WriteLine("Enter Course Duration..... : ");
                int CourseDuration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course Fees..... : ");
                float CourseFees = Convert.ToSingle(Console.ReadLine());
                cmd = new SqlCommand("insert into Courses values(@C_Id,@C_Name,@C_Duration,@C_Fees)", con);
                cmd.Parameters.AddWithValue("@C_Id", CourseId);
                cmd.Parameters.AddWithValue("C_Name", CourseName);
                cmd.Parameters.AddWithValue("@C_Duration", CourseDuration);
                cmd.Parameters.AddWithValue("@C_Fees", CourseFees);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Query Executed Succsesfully Row Inserted.....");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted.....");
                }
            }
            catch (SqlException vm)
            {
                Console.WriteLine(vm);
            }
            finally
            {
                con.Close();
            }
        }

        public void Enroll_Insert()
        {
            try
            {
                con = getCon();
                Console.WriteLine("Enter Student Id.... :");
                int Student_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Course id .....:");
                int Course_Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Enroll_Date....:");
                string Enroll_Date = Console.ReadLine();
                //DateTime Enroll_Date =DateTime.Parse(Console.ReadLine());
                cmd = new SqlCommand("INSERT INTO ENROLL_DETAILS VALUES(@CourseId,@StudentId,@EnrollDate)", con);
                cmd.Parameters.AddWithValue("@CourseId", Course_Id);
                cmd.Parameters.AddWithValue("@StudentId",Student_Id);
                cmd.Parameters.AddWithValue("@EnrollDate", Enroll_Date);
                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("Query Executed Succsesfully Row Inserted.....");
                }
                else
                {
                    Console.WriteLine("Row Not Inserted....... ");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}