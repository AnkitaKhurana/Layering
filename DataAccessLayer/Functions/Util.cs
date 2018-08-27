﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public static class Util 
    {
        private static CustomerContext db = new CustomerContext();

        public static List<Customer> GetAllCustomers()
        {
            var list = db.Customers.ToList();
            return list;
        }
    }
}
