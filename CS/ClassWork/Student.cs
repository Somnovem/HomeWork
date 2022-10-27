using ClassWork;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PV111_CSharp
{


    [Serializable]
    public class StudentCard : IComparable, ICloneable
    {

        public string Series { get; set; }
        public int Number { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            StudentCard st1 = obj as StudentCard;
            if (Series == st1.Series)
            {
                return Number.CompareTo(st1.Number);
            }
            else
            {
                return Series.CompareTo(st1.Series);
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Series} #{Number}";
        }
    }

    [Programmer("Vasya", "2022.10.10")]
    class GroupName
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    [Serializable]
    [AgeValidation(10)]
    [Programmer]
    public class Student : IComparable<Student>, ICloneable
    {
        public int GroupName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDay { get; set; }
        public StudentCard StudentCard { get; set; }

        public static IComparer<Student> FromBirthDay { get { return new DateComparer(); } }
        public static IComparer FromStudentCard { get { return new StudCardComparer(); } }

        public override int GetHashCode()
        {
            return $"{StudentCard.Series} #{StudentCard.Number}".GetHashCode();
        }

        public int CompareTo(Student obj) => LastName.CompareTo(obj.LastName);
        //{
        //    return LastName.CompareTo(obj.LastName);
        //}

        public override string ToString()
        {
            return $"{FirstName.PadRight(10)} {LastName.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public object Clone()
        {
            Student student = (Student)this.MemberwiseClone();
            student.StudentCard = (StudentCard)this.StudentCard.Clone();
            return student;
        }

        public void Exam(DateTime date)
        {
            Console.WriteLine($"Екзамен для {FirstName} {LastName} назначений на {date.ToShortDateString()}");
        }

        //public void Exam(object sender, ExamEventArgs examEvent)
        //{
        //    Console.WriteLine($"Екзамен для {FirstName} {LastName} назначений на {examEvent.Date.ToShortDateString()}");
        //}
    }

    class ExamEventArgs : EventArgs
    {
        public DateTime Date { get; set; }
    }

    class Group /*: IEnumerable*/
    {
        Student[] students =
        {
            new Student()
            {
                FirstName = "Olga",
                LastName = "Petrova",
                BirthDay = new DateTime(2000, 10, 15),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123456
                }
            },
            new Student()
            {
                FirstName = "Valery",
                LastName = "Matveev",
                BirthDay = new DateTime(2001, 11, 5),
                StudentCard = new StudentCard()
                {
                    Series = "AB",
                    Number = 123400
                }
            },
            new Student()
            {
                FirstName = "Petro",
                LastName = "Alekseev",
                BirthDay = new DateTime(2000, 10, 14),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123489
                }
            },
            new Student()
            {
                FirstName = "Irina",
                LastName = "Fadeeva",
                BirthDay = new DateTime(1999, 2, 24),
                StudentCard = new StudentCard()
                {
                    Series = "AC",
                    Number = 123455
                }
            }
        };

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return students.GetEnumerator();
        //}

        public IEnumerable<Student> Top3()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (i == 3)
                {
                    yield break;
                }
                yield return students[i];
            }
        }


        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Length; i++)
            {
                yield return students[i];
            }
        }

        public void Sort()
        {
            //students.Sort();
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            //students.Sort();
            Array.Sort(students, comparer);
        }
    }

    class DateComparer : IComparer<Student>
    {
        //public int Compare(object x, object y)
        //{
        //    if(x is Student && y is Student)
        //    {
        //        return DateTime.Compare((x as Student).BirthDay, (y as Student).BirthDay);
        //    }
        //    throw new NotImplementedException();
        //}
        public int Compare(Student x, Student y)
        {
            return DateTime.Compare(x.BirthDay, y.BirthDay);
        }
    }

    class StudCardComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student).StudentCard.CompareTo((y as Student).StudentCard);
            }
            throw new NotImplementedException();
        }
    }


    class Teacher
    {

        //public EventHandler<ExamEventArgs> Exam;

        public event Action<string> Exam2;

        SortedList<string, Action<DateTime>> list = new SortedList<string, Action<DateTime>>();


        public event Action<DateTime> Exam
        {
            add
            {
                Student st = value.Target as Student;
                list.Add(st.LastName + " " + st.FirstName, value);
            }
            remove
            {
                Student st = value.Target as Student;
                if (list.ContainsKey(st.LastName + " " + st.FirstName))
                {
                    list.Remove(st.LastName + " " + st.FirstName);
                }
            }
        }

        public void SetExam(string s)
        {
            Exam2?.Invoke(s);
            //if (Exam2 != null)
            //{
            //    Exam2(s);
            //}
        }


        public void SetExam(DateTime date)
        {
            foreach (var item in list.Keys)
            {
                list[item](date);
            }

            //Exam?.Invoke(date);
            //if(Exam != null)
            //{
            //    Exam(date);
            //}

        }
    }

}