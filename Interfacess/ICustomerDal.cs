using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
        

        int Id { get; set; }
        string Isım { get; set; }
    }
}
