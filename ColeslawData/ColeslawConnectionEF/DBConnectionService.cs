namespace ColeslawData.ColeslawConnectionEF
{
	public class DBConnectionService
	{
		public static void AddGpu(string make, string model)
		{
			using var db = new GpuContext();
			try
			{
				db.Gpus.Single(g => g.Make == make && g.Model == model);
			}
			catch
			{
				db.Add(new Gpu
				{
					Make  = make,
					Model = model
				});
			}
			db.SaveChanges();
		}
		public static void AddDocument(int quantity, string bpName, string model, string city, int type)
		{
			using var db = new GpuContext();
			db.Add(new Document
			{
				Quantity        = quantity,
				BusinessPartner = db.BusinessPartners.Single(b => b.Name == bpName),
				Gpu             = db.Gpus.Single(g =>g.Model == model),
				Warehouse       = db.Warehouses.Single(w => w.City == city),
				DocType         = db.DocTypes.Single(t => t.DocTypeId == type)
			});
			db.SaveChanges();
		}
		public static void AddWarehouse(string city)
		{
			using var db = new GpuContext();
			try
			{
				db.Warehouses.Single(w => w.City == city);
			}
			catch
			{
				db.Add(new Warehouse
				{
					City = city
				});
			}
			db.SaveChanges();
		}
		public static List<List<string>> GetLists()
		{
			using var db = new GpuContext();
			List<List<string>> templist = new List<List<string>>();
			var query = from p in db.Set<Gpu>()
						group p by p.Make
						into g
						select new { g.Key};
			List<string> listMake      = query.Select(g => g.Key).ToList();
			List<string> listWarehouse = db.Warehouses.Select(g => g.City).ToList();
			List<string> listSellers   = db.BusinessPartners.Where(g => g.BusinessPartnerTypeId == 2).Select(g => g.Name).ToList();
			List<string> listBuyers    = db.BusinessPartners.Where(g => g.BusinessPartnerTypeId == 1).Select(g => g.Name).ToList();
			templist.Add(listWarehouse);
			templist.Add(listMake);
			templist.Add(listBuyers);
			templist.Add(listSellers);
			foreach (var item in listMake)
			{
				templist.Add(db.Gpus.Where(g => g.Make == item).Select(g => g.Model).ToList());
			}
			return templist;
		}
	}
}
