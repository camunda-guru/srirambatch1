using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Vehicle
    {
        public String RegNo { get; set; }
        public String Model { get; set; }
        public String FuelType { get; set; }
        public Customer customer { get; set; }
    }
}
