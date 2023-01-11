using System.Data.SqlClient;
namespace ColeslawData
{
	public class GPUWarehouseService
	{
		public bool FailedToConnect;
		public string ConnectionString;
		public List<string> WarehousesList;
		public List<string> GpuMakeList;
		public List<string> GpuModelListAmd;
		public List<string> GpuModelListNvidia;

		public GPUWarehouseService(string database)
		{
			ConnectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog={database};Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
			try
			{
				var Lists = ListAllData();
				WarehousesList = Lists[0];
				GpuMakeList = Lists[1];
				GpuModelListAmd = Lists[2];
				GpuModelListNvidia = Lists[3];
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
		private List<List<string>> ListAllData()
		{
			var selectStatement  = "SELECT City FROM Warehouse Order by City";
			var selectStatement2 = "SELECT Make, Model FROM Gpu Order by Model";
			var selectStatement3 = "SELECT Make FROM Gpu group by Make Order by Make";

			using (var cn = new SqlConnection())
			{
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				var temporaryList = new List<List<string>>();
				var temporaryListWarehouses = new List<string>();
				var temporaryListGpuMake = new List<string>();
				var temporaryListGpuModelAmd = new List<string>();
				var temporaryListGpuModelNvidia = new List<string>();

				cmd.CommandText = selectStatement;
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					temporaryListWarehouses.Add(reader.GetString(0));
				}
				reader.Close();
				cmd.CommandText = selectStatement2;
				var reader2 = cmd.ExecuteReader();

				while (reader2.Read())
				{
					if(reader2.GetString(0) == "Amd")
						temporaryListGpuModelAmd.Add(reader2.GetString(1));
					else
						temporaryListGpuModelNvidia.Add(reader2.GetString(1));

				}
				reader2.Close();
				cmd.CommandText = selectStatement3;
				var reader3 = cmd.ExecuteReader();

				while (reader3.Read())
				{
					temporaryListGpuMake.Add(reader3.GetString(0));
				}

					cn.Close();

				temporaryList.Add(temporaryListWarehouses);
				temporaryList.Add(temporaryListGpuMake);
				temporaryList.Add(temporaryListGpuModelAmd);
				temporaryList.Add(temporaryListGpuModelNvidia);
				return temporaryList;
			}
		}

		public string GpuStockInWarehouse(String Warehouse, String GpuModel)
		{
			var selectStatement = $"SELECT Amount FROM GPUStatus Inner join Warehouse ON GPUStatus.WarehouseId = Warehouse.Id Inner join Gpu ON GPUStatus.GpuId = Gpu.Id WHERE City = \'{Warehouse}\' AND Model = \'{GpuModel}\';";
			using (var cn = new SqlConnection())
			{
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };

				cmd.CommandText = selectStatement;
				var reader = cmd.ExecuteReader();
				reader.Read();
				string stock = reader.GetInt32(0).ToString();
				cn.Close();
				return stock;
			}
		}
		public void CreateDocument(int amount, string gpuModel, string warehouse, int type)
		{
			var selectStatement = $"Select g.Id, w.Id From GPUStatus Inner join Warehouse w ON GPUStatus.WarehouseId = w.Id Inner join Gpu g ON GPUStatus.GpuId = g.Id Where g.Model = \'{gpuModel}\' And w.City = \'{warehouse}\'";
			using (var cn = new SqlConnection())
			{
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };

				cmd.CommandText = selectStatement;
				var reader = cmd.ExecuteReader();
				reader.Read();
				var insertStatement = $"Insert Into Document (Amount,ClientId,GPUId,WarehouseId,DocTypeId) Values({amount}, 1,{reader.GetInt32(0)},{reader.GetInt32(1)},{type});";
				reader.Close();
				cmd.CommandText = insertStatement;
				var reader2 = cmd.ExecuteReader();
				cn.Close();
			}
		}
		public void AddWarehouse(string warehouse)
		{
			using (var cn = new SqlConnection())
			{
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				var insertStatement = $"Insert Into Warehouse (City) Values(\'{warehouse}\');";
				cmd.CommandText = insertStatement;
				var reader1 = cmd.ExecuteNonQuery();
				cn.Close();
			}
		}
		public void AddGpu(string Make,string Model)
		{
			using (var cn = new SqlConnection())
			{
				cn.ConnectionString = ConnectionString;
				cn.Open();

				var cmd = new SqlCommand() { Connection = cn };
				var insertStatement = $"Insert Into Gpu (Make, Model) Values(\'{Make}\',\'{Model}\');";
				cmd.CommandText = insertStatement;
				var reader1 = cmd.ExecuteNonQuery();
				cn.Close();
			}
		}
		public void UpdateIt()
		{
			var Lists = ListAllData();
			WarehousesList = Lists[0];
			GpuMakeList = Lists[1];
			GpuModelListAmd = Lists[2];
			GpuModelListNvidia = Lists[3];
		}
	}
}