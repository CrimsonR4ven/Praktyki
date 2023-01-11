using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionConsole
{
    public class Customer
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int NumberOfColeslaw { get; set; }

        public Customer()
        {
        }

        public Customer(Customer customer)
		{
            Id = customer.Id;
            Username = customer.Username;
            NumberOfColeslaw = customer.NumberOfColeslaw;
		}

        public string Present()
        {
            string result = $"     | {Id} |{Username}";
            for (int i = 0; i < (10 - Username.Length); i++)
            {
                result += " ";
            }
            result += $"| {NumberOfColeslaw}";
            for (int i = 0; i < (20 - NumberOfColeslaw.ToString().Length); i++)
            {
                result += " ";
            }
            return result+="|";
		}

        public override string ToString()
        {
            return $"{Id}";
        }
    }
}
