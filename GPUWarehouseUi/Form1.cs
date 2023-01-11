using ColeslawData;
namespace GPUWarehouseUi
{
	public partial class Form1 : Form
	{
	
		GPUWarehouseService gpuWarehouseService = new GPUWarehouseService("Test1");
		public List<List<string>> DataCollector = new List<List<string>>();
		int type = 1;
		public Form1()
		{
			if (gpuWarehouseService.FailedToConnect)
			{
				InitializeComponent();
			}
			else
			{

				InitializeMainMenu();
			}
			UpdateDataCollector();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var a = new List<string>();
			a.Add("Amount");
			try
			{
				if (textBox1.Text != "" && comboBox3.Text != "Model" && comboBox1.Text != "Warehouse")
					gpuWarehouseService.CreateDocument(int.Parse(textBox1.Text), comboBox3.Text, comboBox1.Text, type);
				textBox2.Text = "Amount of " + comboBox2.Text + " " + comboBox3.Text + " in " + comboBox1.Text + ": " + gpuWarehouseService.SelectOne("amount", "GPUStatus Inner join Warehouse ON GPUStatus.WarehouseId = Warehouse.Id Inner join Gpu ON GPUStatus.GpuId = Gpu.Id ", $"City = \'{comboBox1.Text}\' AND Model = \'{comboBox3.Text}\'")[0];
			}
			catch
			{
				MessageBox.Show("No Connection with database", "Error");
			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				gpuWarehouseService.UpdateIt();
				comboBox3.Items.Clear();
				if (comboBox3.Enabled == false)
				{
					comboBox3.Enabled = true;
				}
				foreach (string Model in DataCollector[comboBox2.Items.IndexOf(comboBox2.Text) + 2])
				{
					comboBox3.Items.Add(Model);
				}
			}
			catch
			{
				MessageBox.Show("No Connection with database", "Error");	
			}
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				textBox2.Text = "Amount of " + comboBox2.Text + " " + comboBox3.Text + " in " + comboBox1.Text + ": " + gpuWarehouseService.SelectOne("amount", "GPUStatus Inner join Warehouse ON GPUStatus.WarehouseId = Warehouse.Id Inner join Gpu ON GPUStatus.GpuId = Gpu.Id ", $"City = \'{comboBox1.Text}\' AND Model = \'{comboBox3.Text}\'")[0];
			}
			catch
			{
				MessageBox.Show("No Connection with database", "Error");
			}
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if(radioButton1.Checked)
			{
				label7.Text = "Purchaser";
				type = 1;
			}
			else
			{
				label7.Text = "Distributor";
				type = 2;
			}
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DisposeMainMenu();
			InitializeAddingMenu();
			InitializeAddWarehouse();
			
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (textBox3.Text != "")
			{
				try
				{ 
					gpuWarehouseService.Insert("Warehouse(City)",textBox3.Text);
					DisposeAddWarehouse();
					DisposeAddingMenu();
					InitializeMainMenu();
				}
				catch
				{
					MessageBox.Show("No Connection with database", "Error");
				}
			}
			
		}
		private void GoBackclk(object sender, EventArgs e)
		{
			DisposeAddingMenu();
			if(!GpuOrWearhouse)
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
		private void button4_Click(object sender, EventArgs e)
		{
			if (textBox4.Text != "" && comboBox5.Text != "")
			{
				try
				{
					gpuWarehouseService.Insert("Gpu (Make, Model)",$"comboBox5.Text, 'textBox4.Text'");
					DisposeAddGpu();
					DisposeAddingMenu();
					InitializeMainMenu();
				}
				catch
				{
					MessageBox.Show("No Connection with database", "Error");
				}
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

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}
	}
}