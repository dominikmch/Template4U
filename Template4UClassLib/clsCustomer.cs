using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Template4UClassLib
{
    public class ClsCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerName { get; set; }
        public DateTime CustomerRegistrationDate { get; set; }
        public bool CustomerIsBusinessClient { get; set; }

        private readonly clsDataConnection _clsDataConnection;


        public ClsCustomer()
        {
            //Initialize the Customer Class with default values
            CustomerId = 0;
            CustomerEmail = "";
            CustomerPassword = "";
            CustomerName = "";
            CustomerIsBusinessClient = false;
            _clsDataConnection = new clsDataConnection();
        }

        public ClsCustomer(int customerId)
        {
            CustomerId = customerId;
        }



        public int AddCustomer(string email, string password, string name, bool isBusiness)
        {
            try
            {
                if (!Validate(email))
                {
                    return -1;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                return -1;
            }
            

            CustomerEmail = email;
            CustomerPassword = password;
            CustomerName = name;
            CustomerIsBusinessClient = isBusiness;
            CustomerId = _clsDataConnection.Execute("sproc_tblCustomer_SelectSingle");

            return CustomerId;
        }

        private bool Validate(string email)
        {
            var isEmail = new EmailAddressAttribute().IsValid(email);
            if (!isEmail)
            {
                throw new ArgumentException("Email provided is not correct email address. ", nameof(email));
                
            }

            var isCustomer = _clsDataConnection.Execute("dbo.sproc_tblCustomer_CountEmail");
            return isCustomer < 1;
        }

        public void UpdateCustomer(int id)
        {

        }
    }
}
