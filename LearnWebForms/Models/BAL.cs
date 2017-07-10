using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LearnWebForms.Models
{
    public class BAL
    {

        public List<String> GetCountries()
        {
            using (var context = new NorthwindDataContext())
            {
                return (from c in context.Customers
                        select c.Country).Distinct().ToList();
            }
        }

        public List<Customer> GetCustomerByCountry(string country)
        {
            using (var context = new NorthwindDataContext())
            {
                return (from c in context.Customers
                        where c.Country == country
                        select c).ToList();
            }
        }

        public Customer GetCustomer(string custID)
        {
            using (var context = new NorthwindDataContext())
            {
                return (from c in context.Customers
                        where c.CustomerID == custID
                        select c).SingleOrDefault();
            }
        }

    }
}