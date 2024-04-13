using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainNameSpace
{
    class ClasePartial
    {
    }

    partial class Customer_2
    {
        public string Phone { get; set; }
        public string Alias { get; set; }
        public bool IsFrequentCustomer()
        {
            return !string.IsNullOrEmpty(Alias);
        }

    }
}
