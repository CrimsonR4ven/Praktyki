using ColeslawData.ColeslawConnection;
using ColeslawData.ColeslawConnectionEF;
using ColeslawData.DataHolders;
using System.Data.SqlClient;
namespace GPUWarehouseUi
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			if (!gpuWarehouseService.FailedToConnect)
			{
				UpdateDataCollector();
				InitializeMainMenu();
				Log(2);
				ColeslawData.ColeslawConnectionEF.DBConnectionService.AddDocument(15, "AMD Production", "RX 570","Oslo" , 2);
			}
			else
			{
				InitializeNoConnection();
			}
		}
		private void createDocumentButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text != "" && comboBoxModel.Text != "" && comboBoxWarehouse.Text != "" && comboBox4.Text != "")
				{
					ColeslawData.ColeslawConnectionEF.DBConnectionService.AddDocument(int.Parse(textBox1.Text), comboBox4.Text, comboBoxModel.Text, comboBoxWarehouse.Text, type);
	
					Log(3, "New document");
				}
				Log("Amount of " + comboBoxMake.Text + " " + comboBoxModel.Text + " in " + comboBoxWarehouse.Text + ": " + gpuWarehouseService.Select("amount", "GPUStatus Inner join Warehouse ON GPUStatus.WarehouseId = Warehouse.Id Inner join Gpu ON GPUStatus.GpuId = Gpu.Id ", $"WHERE City = \'{comboBoxWarehouse.Text}\' AND Model = \'{comboBoxModel.Text}\'")[0][0]);
			}
			catch
			{
				MessageBox.Show("No Connection with database", "Error");
				Log(1);
			}
		}
		private void addingMenuButton_Click(object sender, EventArgs e)
		{
			this.DisposeMainMenu();
			InitializeAddingMenu();
			InitializeAddWarehouse();

		}
		private void addWarehouseButton_Click(object sender, EventArgs e)
		{
			if (textBox3.Text != "")
			{
				try
				{
					ColeslawData.ColeslawConnectionEF.DBConnectionService.AddWarehouse(textBox3.Text);
				
					DisposeAddWarehouse();
					DisposeAddingMenu();
					InitializeMainMenu();
				}
				catch
				{
					MessageBox.Show("No Connection with database", "Error");
					Log(1);
				}
			}
		}
		private void addGpuButton_Click(object sender, EventArgs e)
		{
			if (textBox4.Text != "" && comboBox5.Text != "")
			{
				try
				{
					ColeslawData.ColeslawConnectionEF.DBConnectionService.AddGpu(comboBox5.Text, textBox4.Text);

					DisposeAddGpu();
					DisposeAddingMenu();
					InitializeMainMenu();
				}
				catch
				{
					System.Windows.Forms.MessageBox.Show("No Connection with database", "Error");
					Log(1);
				}
			}
		}
		private void backButton_Click(object sender, EventArgs e)
		{
			DisposeAddingMenu();
			if (!GpuOrWearhouse)
			{
				DisposeAddGpu();
			}
			else
			{
				DisposeAddWarehouse();
			}

			InitializeMainMenu();
			UpdateComboMainMenu();
		}
		private void comboBoxWarehouse_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxModel.Text != "")
			{
				try
				{
					Log("Amount of " + comboBoxMake.Text + " " + comboBoxModel.Text + " in " + comboBoxWarehouse.Text + ": " + gpuWarehouseService.Select("amount", "GPUStatus Inner join Warehouse ON GPUStatus.WarehouseId = Warehouse.Id Inner join Gpu ON GPUStatus.GpuId = Gpu.Id ", $"WHERE City = \'{comboBoxWarehouse.Text}\' AND Model = \'{comboBoxModel.Text}\'")[0][0]);
				}
				catch
				{
					MessageBox.Show("No Connection with database", "Error");
					Log(1);
				}
			}
		}
		private void comboBoxMake_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				UpdateDataCollector();
				comboBoxModel.Items.Clear();
				if (comboBoxModel.Enabled == false)
				{
					comboBoxModel.Enabled = true;
				}
				foreach (string Model in DataCollector[comboBoxMake.Items.IndexOf(comboBoxMake.Text) + 4])
				{
					comboBoxModel.Items.Add(Model);
				}
			}
			catch
			{
				MessageBox.Show("No Connection with database", "Error");
				Log(1);
			}
		}
		private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Log("Amount of " + comboBoxMake.Text + " " + comboBoxModel.Text + " in " + comboBoxWarehouse.Text + ": " + gpuWarehouseService.Select("amount", "GPUStatus Inner join Warehouse ON GPUStatus.WarehouseId = Warehouse.Id Inner join Gpu ON GPUStatus.GpuId = Gpu.Id ", $"WHERE City = \'{comboBoxWarehouse.Text}\' AND Model = \'{comboBoxModel.Text}\'")[0][0]);
			}
			catch
			{
				MessageBox.Show("No Connection with database", "Error");
				Log(1);
			}
		}
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
			{
				label7.Text = "Purchaser";
				type = 1;
				clientType = 2;
				UpdateClient();
			}
			else
			{
				label7.Text = "Distributor";
				type = 2;
				clientType = 3;
				UpdateClient();
			}
		}
		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			if( radioButton4.Checked)
			{
				InitializeAddWarehouse();
				DisposeAddGpu();
			}
			else
			{
				DisposeAddWarehouse();
				InitializeAddGpu();
			}
		}
		private void textBox1_KeyPress(object sender, KeyPressEventArgs KeyPressEvent)
		{
			if(char.IsDigit(KeyPressEvent.KeyChar) || KeyPressEvent.KeyChar == '\b')
				KeyPressEvent.Handled = false;
			else
				KeyPressEvent.Handled = true;
		}
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Are you sure you want to really exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (dialog == DialogResult.No)
			{
				e.Cancel = true;
			}
		}
	}
}