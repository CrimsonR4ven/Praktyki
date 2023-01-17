using System.Data.SqlClient;
namespace ColeslawData
{
	public class GPUWarehouseService
	{
		public bool FailedToConnect;
		public string ConnectionString;

		public GPUWarehouseService(string database)
		{
			ConnectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={database};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			try
			{
				var cn = new SqlConnection();
				cn.ConnectionString = ConnectionString;
				cn.Open();
				cn.Close();
				FailedToConnect = false;
			}
			catch
			{
				FailedToConnect = true;
			}
		}
		public List<List<string>> Select(string select, string from, string where)
		{
			var selectStatement = $"SELECT {select} FROM {from} WHERE {where};";
			using (var cn = new SqlConnection())
			{
				var temporaryList = new List<List<string>>();

				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				cmd.CommandText = selectStatement;

				var reader = cmd.ExecuteReader();
				reader.Read();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					temporaryList.Add(new List<string>());
				}
				do
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						temporaryList[i].Add(reader.GetValue(i).ToString());
					}
				} while (reader.Read());
				cn.Close();
				return temporaryList;
			}
		}
		public List<List<string>> Select(string select, string from, string notWhere, int notUsedInt)
		{
			var selectStatement = $"SELECT {select} FROM {from} {notWhere};";
			using (var cn = new SqlConnection())
			{
				var temporaryList = new List<List<string>>();

				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				cmd.CommandText = selectStatement;

				var reader = cmd.ExecuteReader();
				reader.Read();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					temporaryList.Add(new List<string>());
				}
				do
				{
					for (int i = 0; i < reader.FieldCount; i++)
					{
						temporaryList[i].Add(reader.GetValue(i).ToString());
					}
				} while (reader.Read());
				cn.Close();
				return temporaryList;
			}
		}
		public List<string> SelectOne(string select, string from, string where)
		{
			var selectStatement = $"SELECT {select} FROM {from} WHERE {where};";
			using (var cn = new SqlConnection())
			{
				var list = new List<string>();
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				cmd.CommandText = selectStatement;

				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					list.Add(reader.GetValue(0).ToString());
				}

				cn.Close();
				return list;
			}
		}
		public List<string> SelectOne(string select, string from, string notWhere, int notUsedInt)
		{
			var selectStatement = $"SELECT {select} FROM {from} {notWhere};";
			using (var cn = new SqlConnection())
			{
				var list = new List<string>();
				cn.ConnectionString = ConnectionString; 
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				cmd.CommandText = selectStatement;

				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					list.Add(reader.GetValue(0).ToString());
				}

				cn.Close();
				return list;
			}
		}
		public void Insert(string into, string values)
		{
			using (var cn = new SqlConnection())
			{
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				var insertStatement = $"Insert Into {into} Values({values});";
				cmd.CommandText = insertStatement;
				var reader1 = cmd.ExecuteNonQuery();
				cn.Close();
			}
		}
	}
}