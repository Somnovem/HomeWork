using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    internal class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class City 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
    internal class Section
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer>? Customers { get; set; }
    }
    internal class Product 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PrimeCost { get; set; }
        public decimal Price { get; set; }
        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
    internal class Customer
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string? Fathersname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public List<Section>? FavouriteSections { get; set; }
    }
    internal class Sales 
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SalePercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
    internal class ArchiveSales
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int SalePercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }

    internal class Interest
    {
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int SectionId { get; set; }
    public Section Section { get; set; }
    }
}
