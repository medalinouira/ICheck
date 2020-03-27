/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

using System;
using System.Linq;
using System.Collections.Generic;

namespace ICheck.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string Label { get; set;  }
        public DateTime Date { get; set; }
        public string TotalPrice
        {
            get
            {
                return Products.Sum(x => x.Key * x.Value.Price).ToString() + "" + "Dinars";
            }
        }

        public IList<KeyValuePair<int, ProductModel>> Products { get; set; }
    }
}
