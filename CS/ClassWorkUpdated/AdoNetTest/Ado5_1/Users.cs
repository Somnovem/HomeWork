using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
namespace Ado5_1
{
    //public  class BooksDb
    //{
    //}
    [Table(Name ="users")]
    public class User
    {
        [Column(Name ="id",IsPrimaryKey =true,IsDbGenerated =true)]
        public int Id { get; set; }

        [Column(Name ="userLogin")]
        public string UserLogin { get; set; }

        [Column(Name = "userPassword")]
        public string Password { get; set; }

        [Column(Name = "dateCreated",IsDbGenerated =true)]
        public DateTime DateCreated { get; set; }

        [Column]
        public bool allow { get; set; }
    }
}
