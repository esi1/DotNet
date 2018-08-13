using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{
    public class Customer : ICustomer
    {
        private string firstName;
        private string lastName;
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get { return firstName; }
            set
            {
                firstName = value;
                Name = String.Format("{0} {1}", lastName, firstName);
            } }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                Name = String.Format("{0} {1}", lastName, firstName);
            }
        }


        public Customer() { }

        public Customer(ICustomer customer)
        {
            Id = customer.Id;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
        }
    }
}
