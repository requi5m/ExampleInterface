using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal customer1 = new Customer() { Id = 1, Isım = "Yigit" };
            ICustomerDal student1 = new Student() { Id = 2, Isım = "Mert" };
            List<ICustomerDal> allthings = new List<ICustomerDal>() { customer1, student1 };
            CustomerManager customerManager = new CustomerManager();

            customerManager.ShowAll(allthings);

            ICustomerDal customer = new Customer();
            customer.Add();
            ICustomerDal student = new Student();
            student.Update();
        }
    }
}
