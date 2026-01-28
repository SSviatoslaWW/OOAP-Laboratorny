using lab3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    internal class ApartmentBuilding : House
    {
        public List<Owner> ApartmentOwners { get; set; }

        public ApartmentBuilding(double area, int floors, string address, List<Owner> owners)
        {
            Area = area; 
            Floors = floors; 
            Address = address; 
            ApartmentOwners = owners;
        }

        public override House Clone()
        {
            List<Owner> clonedOwners = this.ApartmentOwners.Select(o => o.Clone()).ToList();
            return new ApartmentBuilding(this.Area, this.Floors, this.Address, clonedOwners);
        }

        public override void ShowInfo(string prefix = "") 
        {
            Console.WriteLine($"{prefix} ЖК | Адреса: {Address}, Поверхів: {Floors}, Власників: {ApartmentOwners.Count}");
        }
    }
}
