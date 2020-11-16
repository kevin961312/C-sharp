using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Orderitem
    {
        public Orderitem()
        {
                
        }
        public Orderitem(int orderItemId)
        {
            orderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public int  Quantily { get; set; }
        public Orderitem Retrieve(int orderItemId)
        {
            return new Orderitem();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValidate = true;
            if(Quantily <= 0) isValidate = false;
            if (ProductId <= 0) isValidate = false;
            if (PurchasePrice == null) isValidate = false;
            return isValidate;
        }
    }
}
