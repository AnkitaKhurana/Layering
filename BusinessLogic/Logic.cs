using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    [System.ComponentModel.DataObject]
    public class Logic
    {

        [System.ComponentModel.DataObjectMethodAttribute
            (System.ComponentModel.DataObjectMethodType.Select, true)]
        public static List<Customer> Index()
        {
            return Util.GetAllCustomers(); 
        }

    }
}
