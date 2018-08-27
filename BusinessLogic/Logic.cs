using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.DataModels;
using DataAccessLayer;
using System.Linq;

namespace BusinessLogic
{
    [System.ComponentModel.DataObject]
    public class Logic
    {

        [System.ComponentModel.DataObjectMethodAttribute
            (System.ComponentModel.DataObjectMethodType.Select, true)]
        public static Customers Index()
        {
            var myCustomers = new Customers() ;
            var list = Util.GetAllCustomers();
            foreach (var c in Util.GetAllCustomers())
            {

                myCustomers.AllCustomers.Add(c);
            }
            return myCustomers; 
        }

        public static bool AddCustomer(CustomerBLL customer)
        {
            var myCustomer = new Customer();
            myCustomer.Name = customer.Name;
            myCustomer.Age = customer.Age;
            myCustomer.Balance = customer.Balance;
            var saved = Util.AddNewCustomer(myCustomer);
            return saved;
        }

    }
}
