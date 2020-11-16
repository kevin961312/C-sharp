using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {
                
        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
        }
        public int CustomerId { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }

        public string FullName 
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName; 
            } 
        }
 
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public static int InstanceCount { get; set; }
        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValidate = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValidate = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValidate = false;
            return isValidate;
        }
    }
}
