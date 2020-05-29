using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerMicroService.Model
{
    [Table("Customer_Order")]
    public class Customer
    {
        [Key]
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string StreetAddress { get; set; }
        public int Zip { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string TN { get; set; }
        public string CreatedBy { get; set; }
        public string TNType { get; set; }
        public string Operation { get; set; }
        public string RequestData { get; set; }
    }
}
