using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    class Student : ICustomerDal
    {
        public int Id { get; set; }
        public string Isım { get; set; }
        public void Add()
        {
            Console.WriteLine("Student added");
        }

        public void Delete()
        {
            Console.WriteLine("Student deleted");
        }

        public void Update()
        {
            Console.WriteLine("Student updated");
        }
    }
}
