using MySql.Data.MySqlClient;

namespace CSharpTrainings
{

    public class StudentMySqlLayer
    {
        string _con;
        public StudentMySqlLayer() 
        {
            _con = "server=127.0.0.1;uid=root;database=db_trainings;pwd=umer908;AllowLoadLocalInfile=true";
        }

        public List<Student> GetAllUsers()
        {

            using (MySqlConnection conn = new MySqlConnection(_con))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT id, FirstName, LastName, Gender, DateOfBirth, isActive FROM tbl_student";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    List<Student> students = new List<Student>();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student()
                            {
                                Id = reader.GetInt32("id"),
                                FirstName = reader.GetString("FirstName"),
                                LastName = reader.GetString("LastName"),
                                Gender = reader.GetString("Gender"),
                                DateOfBirth = reader.GetDateTime("DateOfBirth"),
                                IsActive = reader.GetBoolean("isActive"),
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
    }
}
