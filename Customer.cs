using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
   public class Customer
    {
       public int CustomerId { get; set; }
       public String Name { get; set; }
       public int CBILScore { get; set; }
       public List<Vehicle> VehicleList { get; set; }
    }
}
