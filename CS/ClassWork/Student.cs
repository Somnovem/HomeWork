using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork
{
    class StudentCard:IComparable,ICloneable
    {
        public int Number { get; set; }
        public string Series { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            StudentCard st1 = obj as StudentCard;
            if (Series == st1.Series) return Number.CompareTo(st1.Number);

            return Series.CompareTo(st1.Series);
        }

        public override string ToString()
        {
            return $"Number : {Number}\t Series : {Series}";
        }
    }
    internal class Student: IComparable<Student>, ICloneable
    {
        public static IComparer<Student> ByBirthday { get {return new DateComparer(); } }
        public static IComparer ByCard { get { return new StudentCardComparer(); } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public StudentCard StudentCard { get; set; }

        public object Clone()
        {
            Student res=(Student)this.MemberwiseClone();
            res.StudentCard = (StudentCard)StudentCard.Clone();
            return res;
        }

        public int CompareTo(Student obj)
        {
            return LastName.CompareTo(obj.LastName);
        }

        public override string ToString()
        {
            return $"First Name: {FirstName}\nLastname: {LastName}\nBirtday: {Birthday.ToShortDateString()}\n{StudentCard}";
        }
        public override int GetHashCode()
        {
            return $"{StudentCard.Series} #{StudentCard.Number}".GetHashCode();
        }
    }

    class Group: IEnumerable
    {
        Student[] students =
        {
            new Student()
            {
                FirstName = "Olga",
                LastName = "Petrova",
                Birthday = new DateTime(1996,5,14),
                StudentCard = new StudentCard()
                {
                    Series = "AC",Number =123456
                }
             },
            new Student()
            {
                FirstName = "Natasha",
                LastName = "Romanoff",
                Birthday = new DateTime(1998,7,2),
                StudentCard = new StudentCard()
                {
                    Series = "AB",Number =123466
                }
             },
            new Student()
            {
                FirstName = "Petro",
                LastName = "Oleksiiv",
                Birthday = new DateTime(2000,4,25),
                StudentCard = new StudentCard()
                {
                    Series = "AC",Number =123478
                }
             },
            new Student()
            {
                FirstName = "Geralt",
                LastName = "of Rivia",
                Birthday = new DateTime(1578,6,16),
                StudentCard = new StudentCard()
                {
                    Series = "AB",Number =123444
                }
             }
        };

        public IEnumerable<Student> Top3()
        {
            for (int i = 0; i < students.Length; i++)
            {
                if (i ==3)
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
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students,comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }
    class DateComparer : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return DateTime.Compare((x as Student).Birthday, (y as Student).Birthday);
        }
    }

    class StudentCardComparer : IComparer
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
}
