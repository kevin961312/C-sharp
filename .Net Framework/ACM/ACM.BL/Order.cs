using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public Order()
        {
                
        }
        public Order(int orderId)
        {
            OrderId = orderId;                
        }
        
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValidate = true;
            if (OrderDate == null) isValidate = false;
            return isValidate;
        }
    }
}
