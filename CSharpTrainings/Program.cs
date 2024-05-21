// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using CSharpTrainings;
using CSharpTrainings.LINQ;

//StudentMySqlLayer studentMySql  = new StudentMySqlLayer();

//StudentMSSQLLayer studentMSSQLLayer = new StudentMSSQLLayer();


// LINQ to Memory Objects Examples

//var studentList = studentMSSQLLayer.GetAllUsers();

//var student = from std in studentList
//              orderby std.FirstName ascending
//              select std.FirstName;


//foreach (var name in student)
//{
//    Console.WriteLine(name);
//}

//foreach (var student in studentMSSQLLayer.GetAllUsers())
//{
//    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Gender: {student.Gender}, Date of Birth: {student.DateOfBirth.ToShortDateString()}, Active: {student.IsActive}");
//}


// LINQ to XML Objects Examples

LinqToXML linqToXML = new LinqToXML();

foreach (var student in linqToXML.LoadStudents())
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}, Gender: {student.Gender}, Date of Birth: {student.DateOfBirth.ToShortDateString()}, Active: {student.IsActive}");
}


//  LINQ
//  Get Male Students or Female Students using paramter in fucntion
//  Group by on gender and get count
//  Orderby



/*
 * Ling to SQL we use Entity Framework if(VS == 2022) else LinqToSQL
 * 
 * Create New table Department (student n Courses)
 * 
 * DbContext
 * StudentDb Crud + Get all male/female students
 * CourseDb     
 * DepartmentDb Show courses by department using linq query.
 */



Console.ReadKey();