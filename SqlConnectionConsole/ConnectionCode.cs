using System.Data.SqlClient;

namespace SqlConnectionConsole
{
	public class ConnectionCode
	{
		public void Run()
		{
			var customers = new List<Customer>();
			var cn = new SqlConnection();
			cn.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			var selectStatement = "SELECT ID, Username, NumberOfBuyedKoleslaw " +
									  "FROM Customers ";
			using (var cmd = new SqlCommand() { Connection = cn })
			{
				cn.Open();

				cmd.CommandText = selectStatement;
				var reader = cmd.ExecuteReader();
				var customer = new Customer();

				while (reader.Read())
				{
					customer.Id = reader.GetInt32(0);
					customer.Username = reader.GetString(1);
					customer.NumberOfColeslaw = reader.GetInt32(2);
					customers.Add(new Customer(customer));
				}
				cn.Close();
			}
			Console.WriteLine("     /------------------------------------\\\n" + "     |ID | Username | Number of Coleslaws |\n" + "     |---|----------|---------------------|");
			foreach (Customer customer in customers)
			{
				Console.WriteLine(customer.Present());
			}
			Console.WriteLine("     \\------------------------------------/\n");
		}
	}
}
