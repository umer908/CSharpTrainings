using System.Xml.Linq;

namespace CSharpTrainings.LINQ
{
    public class LinqToXML
    {
        private readonly string _filePath;
        public LinqToXML() 
        {
            _filePath = @"StudentData.xml";
        }

        public IEnumerable<Student> LoadStudents()
        {

            XElement xdoc = XElement.Load($"{_filePath}");

            // Query the XML document using LINQ
            var students = from student in xdoc.Descendants("Student")
                           select new Student
                           {
                               Id = (int)student.Element("id"),
                               FirstName = (string)student.Element("FirstName"),
                               LastName = (string)student.Element("LastName"),
                               Gender = (string)student.Element("Gender"),
                               DateOfBirth = (DateTime)student.Element("DateOfBirth"),
                               IsActive = (bool)student.Element("isActive")
                           };

            return students;
        }
    }
}
