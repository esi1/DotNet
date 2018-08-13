using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfases
{
     public interface ICustomer : IItem
    {
         string FirstName { get; set; }
         string LastName { get; set; }
    }
}
