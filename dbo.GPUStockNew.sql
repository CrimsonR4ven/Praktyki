CREATE PROCEDURE [dbo].[GPUStockNew]
AS
	update GPUStatus set Amount = d.SUMA
	from GPUStatus g
	inner join (select GpuId, WarehouseId, 
	sum(case when DocTypeId = 1 then -Amount else Amount end) as [SUMA]
	from Document
	group by GpuId, WarehouseId) d 
	on g.GpuId = d.GPUId AND g.WarehouseId =d.WarehouseId 
RETURN 0