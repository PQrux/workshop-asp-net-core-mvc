using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Departament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        public Departament()
        {
        }
        public Departament(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void addSeller(Seller seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSalles(DateTime initial, DateTime final)
        {
            return Sellers.Sum(sl => sl.totalSales(initial,final));
        }
    }
}
