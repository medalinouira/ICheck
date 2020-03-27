/// Mohamed Ali NOUIRA
/// http://www.mohamedalinouira.com
/// https://github.com/medalinouira
/// Copyright © Mohamed Ali NOUIRA. All rights reserved.

namespace ICheck.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public string BarCode { get; set; }

        public string PriceAsString
        {
            get
            {
                return Price.ToString() + " " + Unit.ToString();
            }
        }
    }
}
