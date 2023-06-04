using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
            
        }
        
        public void ShowAll(List<ICustomerDal> customer)
        {
            foreach (var allthings in customer)
            {
                Console.WriteLine(allthings.Isım);
            }
        }
    }
}
