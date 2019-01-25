using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Departament Departament { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public void addSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }
        public void removeSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }
        public double totalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
        public Seller()
        {

        }

        public Seller(int id, string nome, string email, double baseSalary, DateTime birthDate, Departament departament)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Departament = departament;
        }
    }
}
