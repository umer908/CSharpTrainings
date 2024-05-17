using System.Data.SqlClient;
using System.Text;

namespace CSharpTrainings
{
    public class StudentMSSQLLayer
    {
        string _con;
        public StudentMSSQLLayer()
        {
            _con = "server=LAPTOP-CBE07JIV;uid=sa;database=dbOtp;pwd=umer908;";
        }

        public List<Student> GetAllUsers()
        {

            using (SqlConnection conn = new SqlConnection(_con))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, FirstName, LastName, Gender, DateOfBirth, isActive FROM tbl_student";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    List<Student> students = new List<Student>();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("isActive")),


                            };
                            students.Add(student);
                        }
                    }

                    return students;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return new List<Student>();
                }
            }
        }

        // get user by id
        // add new user
        // update new user
    }
}
