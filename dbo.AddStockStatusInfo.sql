CREATE PROCEDURE [dbo].[AddStockStatusInfo]
AS
	declare @idWarehouse int
	declare @idGpu int
	declare @DoesExist int

	select @idWarehouse = min( Id ) from Warehouse

	WHILE @idWarehouse is not null
	BEGIN

		select @idGpu = min( Id ) from Gpu

		WHILE @idGpu is not null
		BEGIN

			select @DoesExist = count(1) from GPUStatus where WarehouseId = @idWarehouse and GpuId = @idGpu
			IF(@DoesExist = 0)
			BEGIN
				insert into GPUStatus (Amount,WarehouseId,GpuId) values (0,@idWarehouse,@idGpu)
			END

			select @idGpu = min( Id ) from Gpu where Id > @idGpu

		END

		select @idWarehouse = min( Id ) from Warehouse where Id > @idWarehouse
	END