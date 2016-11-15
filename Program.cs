using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //int[] numbers = { 4, 5, 6, 8, 9, 10, 12, 16, 78, 89 };
            //var modifiedData = from n in numbers
            //                   where n%2==1
            //                   select n + 1;
            //foreach (int n in modifiedData)
            //    Console.WriteLine(n);
            var query = from Customer customer in CreateCustomerList()
                        where customer.CBILScore>600
                        orderby customer.Name
                        select new { customer.Name,customer.CBILScore };


            foreach (var c in query)
                Console.WriteLine(c.Name + ": " + c.CBILScore);


            var q = from Customer c in CreateCustomerList()
                   
                    select new { c.Name, c.VehicleList };
            foreach (var data in q)
            {
                Console.WriteLine("Customer Name: {0}",data.Name);
                foreach (Vehicle v in data.VehicleList)
                    Console.WriteLine(v.RegNo);
            }


            Console.ReadKey();


        }

        public static List<Customer> CreateCustomerList()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();


            List<Customer> customerList = new List<Customer>();
           
            vehicleList.Add(new Vehicle { RegNo="TN-32-0908",Model="Honda VX",FuelType="Petrol"});
            vehicleList.Add(new Vehicle { RegNo = "TN-02-0064", Model = "Estilo VX", FuelType = "Petrol" });
            customerList.Add(new Customer { CustomerId = 145314, Name = "Ashok", CBILScore = 678,VehicleList=vehicleList });
            vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle { RegNo = "CH-02-0907", Model = "BMW", FuelType = "Petrol" });
            
            customerList.Add(new Customer { CustomerId = 145317, Name = "Arun", CBILScore = 875,VehicleList=vehicleList });

            vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle { RegNo = "KL-01-0907", Model = "AUDI Q4", FuelType = "Disel" });
            customerList.Add(new Customer { CustomerId = 145325, Name = "Anjana", CBILScore = 780,VehicleList=vehicleList });
            vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle { RegNo = "KA-01-0907", Model = "AUDI Q1", FuelType = "Disel" }); 
            customerList.Add(new Customer { CustomerId = 145345, Name = "Sanjay", CBILScore = 550,VehicleList=vehicleList });
            vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle { RegNo = "TN-01-0999", Model = "Swift", FuelType = "Petrol" }); 
            customerList.Add(new Customer { CustomerId = 145667, Name = "Swarna", CBILScore = 666,VehicleList=vehicleList });
            vehicleList = new List<Vehicle>();
            vehicleList.Add(new Vehicle { RegNo = "KL-02-0909", Model = "RITZ", FuelType = "Disel" });
            customerList.Add(new Customer { CustomerId = 145712, Name = "Rani", CBILScore = 888,VehicleList=vehicleList });
            return customerList;
        }


    }
}
