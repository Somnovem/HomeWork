namespace Ado11_1
{
    internal class Program11_1
    {
        static void Main(string[] args)
        {
            Console.Title = "Test Dapper ORM";
            TeachersDbContext db = new TeachersDbContext();
            //db.PrintAllTeachers();
            //Console.WriteLine("/////////////////////////////////");
            //db.PrintTeacherById(1);
            //Console.WriteLine("/////////////////////////////////");
            //db.PrintTeacherByName("Sophia", "Nelson");
            //db.PrintAllTeachersAndDepartmentsTypically();
            //db.AddNewGroup();
            //db.AddFaculties();
            //db.PrintFaculties();
            //db.DeleteTempFaculties();
            //db.PrintFaculties();

            //db.UpdateTempFaculties();


            //db.MultiQueryDapper();

            //db.PrintGroupFaculty();
            
            db.ExequteScalarStudentsCount();
            Console.WriteLine("\npress Enter key...");
            Console.ReadLine();
        }
    }
}