using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Data.Common;

namespace Ado11_1
{
    internal class TeachersDbContext : IDisposable
    {
        public IDbConnection dbConnection;
        public TeachersDbContext(string connectionString)
        {
            dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();//так как он сам не контролирует включение подключения
        }
        public TeachersDbContext() : this(System.Configuration.ConfigurationManager.ConnectionStrings["TeachersDbConnection"].ConnectionString) { }

        public void Dispose()
        {
            dbConnection?.Close();
        }
        public void PrintAllTeachers()
        {
            Console.WriteLine("\nPrint all teachers");
            var teachers = dbConnection.Query("select * from Teachers");
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}  ({t.BirthDate}) - {t.DepartmentId}");
            }
        }
        public void PrintTeacherById(int id)
        {
            Console.WriteLine("\nPrint all teachers by Id");
            var teachers = dbConnection.Query("select * from Teachers where Id = @id", new { id });
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}  ({t.BirthDate}) - {t.DepartmentId}");
            }
        }
        public void PrintTeacherByName(string fName, string lName)
        {
            Console.WriteLine("\nPrint all teachers by Name");
            var teachers = dbConnection.Query("select * from Teachers where FirstName = @firstname and LastName = @lastname"
                , new { firstname = fName, lastname = lName });
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}  ({t.BirthDate}) - {t.DepartmentId}");
            }
        }
        public void PrintAllTeachersTypically()
        {


            Console.WriteLine("\nPrint all teachers(typically)");
            var teachers = dbConnection.Query<Teacher>("select * from Teachers");
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName}  ({t.BirthDate.ToShortDateString()}) - {t.DepartmentId}");
            }
        }
        public void PrintAllTeachersAndDepartmentsTypically()
        {

            Console.WriteLine("\nPrint all teachers and departments(typically)");
            var teachers = dbConnection.Query<Teacher, Department, Teacher>("select * from Teachers as T join Departments as D on T.DepartmentId = D.Id"
                                                                          , (t, d) =>
                                                                          {
                                                                              t.Department = d;
                                                                              return t;
                                                                          });
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FirstName} {t.LastName} - {t.Department.Name}, {t.Department.Phone}");
            }
        }

        public void AddNewGroup() //через хранимую процедуру
        {
            Console.Write("Enter name of the new group: ");
            string groupName = Console.ReadLine();
            Console.Write("\nEnter faculty Id: ");
            int id = int.Parse(Console.ReadLine());

            var p = new DynamicParameters();

            //parameters in
            p.Add("@groupName", groupName);
            p.Add("@facultyId", id,DbType.Int32);

            //parameters out(returns id of the added group)
            p.Add("@groupId", DbType.Int32,direction:ParameterDirection.Output);
            //output parameter of the prcedure
            p.Add("@result", DbType.Int32, direction: ParameterDirection.ReturnValue);


            dbConnection.Execute("AddNewGroup",p,commandType:CommandType.StoredProcedure);
            Console.WriteLine($"New Group Id = {p.Get<int>("@groupId")}");

            Console.WriteLine("New list of all groups");
            var groups = dbConnection.Query("select * from Groups");
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Id}. {g.Name}  Faculty:{g.FacultyId} Student Count:{g.StudentCount}");
            }
        }

        public void AddFaculties()
        {

            //пакетная вставка анонимных обьектов
            Console.WriteLine("Add Faculty");
            //var faculties = new List<object>();
            //for (int i = 1; i <= 5; i++)
            //{
            //    faculties.Add(new { Name = $"Faculty {i}" });
            //}

            //пакетная вставка типизированных обьектов
            var faculties = new List<Faculty>();
            for (int i = 11; i <= 15; i++)
            {
                faculties.Add(new Faculty{ Name = $"Faculty {i}" });
            }


            int res = dbConnection.Execute("INSERT INTO Faculties(Name) values(@Name)", faculties);
            Console.WriteLine($"Result: {res} rows affected");
        }
        public void PrintFaculties()
        {
            Console.WriteLine("All faculties");

            var faculties = dbConnection.Query<Faculty>("select * from Faculties");
            foreach (var faculty in faculties)
            {
                Console.WriteLine($"{faculty.Id}.{faculty.Name}");
            }
        }
        public void DeleteTempFaculties() 
        {
            Console.WriteLine("Delete Faculties");
            //пакетное удаление через анонимные обьекты
            var faculties = new List<int>();
            int id = 0;
            while (true)
            {
                Console.Write("Enter Id(write -1 to break) = ");
                id = int.Parse(Console.ReadLine());
                if (id < 0) break;
                faculties.Add(id);
            }

            IDbTransaction tran = dbConnection.BeginTransaction();
            try
            {
                int res = dbConnection.Execute("DELETE FROM Faculties where Id in @faculties", new { faculties },transaction:tran);
                Console.WriteLine($"Result: {res} rows affected");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                Console.WriteLine(ex.Message);
            }
        }

        public void UpdateTempFaculties()
        {
            Console.WriteLine("Update Faculty");
            PrintFaculties();
            //пакетное обновление
            var faculty = new Faculty();
            Console.Write("Enter id = ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter name = ");
            string name = Console.ReadLine();

            faculty.Name = name;
            faculty.Id = id;

            IDbTransaction tran = dbConnection.BeginTransaction();
            try
            {
                int res = dbConnection.Execute("UPDATE Faculties SET Name = @Name where Id = @Id", faculty,transaction: tran);
                Console.WriteLine($"Result: {res} rows affected");
                tran.Commit();
                PrintFaculties();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                Console.WriteLine(ex.Message);
            }

        }

        public void MultiQueryDapper() 
        {
            string sql = "select * from Teachers;" +
                    " select * from Faculties;" +
                    " select * from Groups;";
            using (var multi = dbConnection.QueryMultiple(sql))
            {
                var teachers = multi.Read<Teacher>().ToList();          
                var faculties = multi.Read<Faculty>().ToList();          
                var groups = multi.Read<Group>().ToList();
                Console.WriteLine("----------Teachers list----------");
                foreach (Teacher teacher in teachers)
                {
                    Console.WriteLine($"{teacher.LastName} {teacher.FirstName} - {teacher.BirthDate.ToShortDateString()}");
                }
                Console.WriteLine("----------Faculties list----------");
                foreach (Faculty faculty in faculties) 
                {
                    Console.WriteLine($"{faculty.Name}");
                }
                Console.WriteLine("----------Groups list----------");
                foreach (Group group in groups)
                {
                    Console.WriteLine($"{group.Name} {group.FacultyId} - {group.StudentsCount}");
                }
            }
        }
        public void PrintGroupFaculty()
        {
            Console.Write("Enter faculty id= ");
            int id = int.Parse(Console.ReadLine());
            var result = dbConnection.Query("GroupsFaculty"
                ,new { id },commandType:CommandType.StoredProcedure);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public void ExequteScalarFunc()
        {
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();
            var result = dbConnection.ExecuteScalar<int>("select dbo.GetSubjectCount('@firstname','@lastname')", new { firstname,lastname});
            Console.WriteLine($"Result: {result}");
        }
        public void ExequteScalarStudentsCount()
        {
            var result = dbConnection.ExecuteScalar<int>("select count(*) from Students");
            Console.WriteLine($"Students count: {result}");
        }
    }
}
