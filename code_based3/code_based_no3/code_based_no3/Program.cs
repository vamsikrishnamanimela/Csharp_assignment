using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CodebaseTest3
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        public static SqlConnection getcon()
        {
            con = new SqlConnection(@"data source = RMGW58ZLPC0934\SQLEXPRESS; Initial Catalog =MyFirstDb; user id =sa; password =Temp1234");
            con.Open();
            return con;
        }

        public static void insertEmployeesdata()
        {
            try
            {
                con = getcon();
                Console.WriteLine("Enter The Empname.....: ");
                string Empname = Console.ReadLine();
                Console.WriteLine("Enter The Empsal....: ");
                float Empsal = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Enter The Employee type......: ");
                string Emptype = Console.ReadLine();
                cmd = new SqlCommand("CO_EMPLOYEES", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd = new SqlCommand("execute CO_EMPLOYEES @empname,@empsal,@emptype", con);
                cmd.Parameters.Add(new SqlParameter("@empname", Empname));
                cmd.Parameters.Add(new SqlParameter("@empsal", Empsal));
                cmd.Parameters.Add(new SqlParameter("@emptype", Emptype));


                int res = cmd.ExecuteNonQuery();
                if (res > 0)
                {
                    Console.WriteLine("No.of Rows effected :{0}", res);
                }
                else
                {
                    Console.WriteLine("No Row Effected");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void DisplayEmployees()
        {
            con = getcon();


            cmd = new SqlCommand("select * from Code_Employee", con);



            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("EmpId is.....: " + dr[0]);
                Console.WriteLine("Empname is....: " + dr[1]);
                Console.WriteLine("EmpSalary is....: " + dr[2]);
                Console.WriteLine("EmpType is.....: " + dr[3]);


            }
        }
        static void Main(string[] args)
        {
            insertEmployeesdata();
            DisplayEmployees();
            Console.Read();
        }
    }
}