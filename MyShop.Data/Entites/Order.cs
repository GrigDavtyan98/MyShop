using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Data.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        
        public Customer Customer { get; set; }
    }
}
