using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Drug
    {
        public string Name { get; set; }
        public string Category { get; set; }

        public int Quantity { get; set; }   

        public DateTime ExpirationDate { get; set; }

        public Drug()
        {
                
        }

        public Drug(string name, string category, int quantity, DateTime expirationDate)
        {
            Name = name;
            Category = category;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }
    }
}
