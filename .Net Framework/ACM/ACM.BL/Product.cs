using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
     public class Product :  EntityBase
    {
        public Product()
        {
                
        }
        public Product(int productId)
        {
            ProductId = productId;
        }
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get;  set; }
        public int ProductId { get; private set; }
        private string _productName;
        public string ProductName 
        {
            get 
            {
                var stringHandler = new StringHandler();
                return stringHandler.InsertSpaces(_productName);
            }
            set 
            {
                _productName= value;
            }
        }
 

        public override string ToString() => ProductName;
        public override bool Validate() 
        {
            var isValidate = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValidate = false;
            if (CurrentPrice == null) isValidate = false;
            return isValidate;
        }
    }
}
