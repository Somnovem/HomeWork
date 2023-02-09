using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesLINQ
{
    [Table(Name ="Countries")]
    public class Country
    {
        [Column(Name="Id",IsPrimaryKey = true,IsDbGenerated =true)]
        public int Id { get; set; }

        [Column(Name = "Name")]
        public string Name { get; set; }

        [Column(Name = "Capital")]
        public string Capital { get; set; }

        [Column(Name = "Population")]
        public int Population { get; set; }

        [Column(Name = "Area")]
        public int Area { get; set; }

        [Column(Name = "Continent")]
        public string Continent { get; set; }
    }
}
