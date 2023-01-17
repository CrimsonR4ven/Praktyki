using System.Data.SqlClient;
using ColeslawData.DataHolders;
namespace ColeslawData.ColeslawConnection
{
	public class DBConnectionService
	{
		public bool FailedToConnect;
		public string ConnectionString;

		public DBConnectionService(string database)
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
			var selectStatement = $"SELECT {select} FROM {from} {where};";
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

		public static SqlTransaction AddDocument(SqlConnection cn, ColeslawData.DataHolders.Document dane, SqlTransaction t = null)
		{
			if (t == null)
			{
				t = cn.BeginTransaction();
			}
			var cmd = new SqlCommand("AddDocument", cn, t);
			cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Int);
			cmd.Parameters["@Amount"].Value = dane.Amount;
			cmd.Parameters.Add("@BusinessPartnerName", System.Data.SqlDbType.VarChar, 50);
			cmd.Parameters["@BusinessPartnerName"].Value = dane.BusinessPartnerName;
			cmd.Parameters.Add("@GPUName", System.Data.SqlDbType.VarChar, 30);
			cmd.Parameters["@GPUName"].Value = dane.GpuName;
			cmd.Parameters.Add("@WarehouseName", System.Data.SqlDbType.VarChar, 50);
			cmd.Parameters["@WarehouseName"].Value = dane.WarehouseName;
			cmd.Parameters.Add("@TypeId", System.Data.SqlDbType.Int);
			cmd.Parameters["@TypeId"].Value = dane.TypeId;

			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.ExecuteNonQuery();
			return cmd.Transaction;
		}
		public static SqlTransaction AddWarehouse(SqlConnection cn, string dane, SqlTransaction t = null)
		{
			if (t == null)
			{
				t = cn.BeginTransaction();
			}
			var cmd = new SqlCommand("AddWarehouse", cn, t);
			cmd.Parameters.Add("@WarehouseName", System.Data.SqlDbType.VarChar, 30);
			cmd.Parameters["@WarehouseName"].Value = dane;
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.ExecuteNonQuery();
			return cmd.Transaction;
		}
		public static SqlTransaction AddGpu(SqlConnection cn, string make, string model, SqlTransaction t = null)
		{
			if (t == null)
			{
				t = cn.BeginTransaction();
			}
			var cmd = new SqlCommand("AddGpu", cn, t);
			cmd.Parameters.Add("@GpuMake", System.Data.SqlDbType.NVarChar, 20);
			cmd.Parameters["@GpuMake"].Value = make;
			cmd.Parameters.Add("@GpuModel", System.Data.SqlDbType.NVarChar, 20);
			cmd.Parameters["@GpuModel"].Value = model;
			cmd.CommandType = System.Data.CommandType.StoredProcedure;
			cmd.ExecuteNonQuery();
			return cmd.Transaction;
		}
		public static string CommitTransaction(SqlTransaction t)
		{
			try
			{
				t.Commit();
			}
			catch (Exception ex)
			{
				try
				{
					t.Rollback();
				}
				catch (Exception ex2)
				{
					return ex2.Message;
				}
				return ex.Message;
			}
			return "";
		}
	}
}