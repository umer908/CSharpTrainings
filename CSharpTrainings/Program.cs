// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using CSharpTrainings;

StudentMySqlLayer studentMySql  = new StudentMySqlLayer();

StudentMSSQLLayer studentMSSQLLayer = new StudentMSSQLLayer();
foreach (var student in studentMSSQLLayer.GetAllUsers())
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Gender: {student.Gender}, Date of Birth: {student.DateOfBirth.ToShortDateString()}, Active: {student.IsActive}");
}



Console.ReadKey();