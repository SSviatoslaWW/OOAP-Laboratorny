using lab3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Models
{
    internal class Cottage : House
    {
        public Owner SingleOwner { get; set; }

        public Cottage(double area, int floors, string address, Owner owner)
        {
            Area = area; Floors = floors; Address = address; SingleOwner = owner;
        }

        public override House Clone()
        {
            return new Cottage(this.Area, this.Floors, this.Address, this.SingleOwner.Clone());
        }

        public override void ShowInfo(string prefix = "")
        {
            Console.WriteLine($"{prefix} Котедж | Адреса: {Address}, Площа: {Area}м2, Власник: {SingleOwner.FullName}");
        }
    }
}
