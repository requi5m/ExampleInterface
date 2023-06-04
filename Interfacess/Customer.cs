using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    class Customer : ICustomerDal
    {
        public int Id { get; set; }
        public string Isım { get; set; }

        public void Add()
        {
            Console.WriteLine("Customer added");
        }     
        public void Delete()
        {
            Console.WriteLine("Customer deleted");
        }

        public void Update()
        {
            Console.WriteLine("Customer updated");
        }
    }
}
