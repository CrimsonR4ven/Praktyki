namespace ColeslawData.DataHolders
{
	public class Document
	{
		public int Amount;
		public int TypeId;
		public string BusinessPartnerName;
		public string GpuName;
		public string WarehouseName;
		public Document(int amount, string businessPartnerName, string gpuName, string warehouseName, int typeId)
		{
			Amount = amount;
			BusinessPartnerName = businessPartnerName;
			GpuName = gpuName;
			WarehouseName = warehouseName;
			TypeId = typeId;
		}
	}
}
