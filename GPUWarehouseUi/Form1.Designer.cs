using System.Data.SqlClient;
using ColeslawData.ColeslawConnection;

namespace GPUWarehouseUi
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		///  
		///  The thing is, Im going to modify it anyway
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(284, 243);
			this.Name = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		#region My Disposings
		private void DisposeMainMenu()
		{
			this.comboBoxWarehouse.Dispose();
			this.comboBoxMake.Dispose();
			this.comboBoxModel.Dispose();
			this.textBox1.Dispose();
			this.label2.Dispose();
			this.label3.Dispose();
			this.label4.Dispose();
			this.label5.Dispose();
			this.radioButton1.Dispose();
			this.radioButton2.Dispose();
			this.createDocumentButton.Dispose();
			this.label6.Dispose();
			this.comboBox4.Dispose();
			this.label7.Dispose();
			this.addingMenuButton.Dispose();
		}
		private void DisposeAddingMenu()
		{
			this.label1.Dispose();
			this.radioButton3.Dispose();
			this.radioButton4.Dispose();
			this.GoBack.Dispose();
		}
		private void DisposeAddWarehouse()
		{
			this.textBox3.Dispose();
			this.label8.Dispose();
			this.addWarehouseButton.Dispose();
		}
		private void DisposeAddGpu()
		{
			this.comboBox5.Dispose();
			this.label9.Dispose();
			this.addGpuButton.Dispose();
			this.textBox4.Dispose();
			this.label10.Dispose();
		}

		#endregion

		#region Initializations
		private void InitializeMainMenu()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
			this.comboBoxMake = new System.Windows.Forms.ComboBox();
			this.comboBoxModel = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.createDocumentButton = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.addingMenuButton = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "GPU Warehouses Managment";
			// 
			// comboBox1
			// 
			this.comboBoxWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWarehouse.FormattingEnabled = true;
			this.comboBoxWarehouse.Location = new System.Drawing.Point(130, 133);
			this.comboBoxWarehouse.Name = "comboBox1";
			this.comboBoxWarehouse.Size = new System.Drawing.Size(121, 23);
			this.comboBoxWarehouse.TabIndex = 1;
			this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBoxMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMake.FormattingEnabled = true;
			this.comboBoxMake.Location = new System.Drawing.Point(130, 162);
			this.comboBoxMake.Name = "comboBox2";
			this.comboBoxMake.Size = new System.Drawing.Size(121, 23);
			this.comboBoxMake.TabIndex = 2;
			this.comboBoxMake.SelectedIndexChanged += new System.EventHandler(this.comboBoxMake_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxModel.Enabled = false;
			this.comboBoxModel.FormattingEnabled = true;
			this.comboBoxModel.Location = new System.Drawing.Point(130, 191);
			this.comboBoxModel.Name = "comboBox3";
			this.comboBoxModel.Size = new System.Drawing.Size(121, 23);
			this.comboBoxModel.TabIndex = 3;
			this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(130, 249);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 23);
			this.textBox1.TabIndex = 4;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Which Warehouse:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Gpu Make:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 199);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Gpu Model:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 257);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Amount:";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(130, 71);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(87, 19);
			this.radioButton1.TabIndex = 9;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Distribution";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(130, 96);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(78, 19);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "Reception";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.createDocumentButton.Location = new System.Drawing.Point(130, 290);
			this.createDocumentButton.Name = "button1";
			this.createDocumentButton.Size = new System.Drawing.Size(121, 23);
			this.createDocumentButton.TabIndex = 11;
			this.createDocumentButton.Text = "Create Document";
			this.createDocumentButton.UseVisualStyleBackColor = true;
			this.createDocumentButton.Click += new System.EventHandler(this.createDocumentButton_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(266, 133);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(248, 180);
			this.textBox2.TabIndex = 12;
			this.textBox2.Font = new Font(this.textBox2.Font.Name, this.textBox2.Font.Size - 2f, this.textBox2.Font.Style, this.textBox2.Font.Unit);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(370, 115);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Logs";
			// 
			// comboBox4
			// 
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(130, 220);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 23);
			this.comboBox4.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 228);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(62, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Purchaser:";
			// 
			// button2
			// 
			this.addingMenuButton.Location = new System.Drawing.Point(394, 12);
			this.addingMenuButton.Name = "button2";
			this.addingMenuButton.Size = new System.Drawing.Size(121, 23);
			this.addingMenuButton.TabIndex = 16;
			this.addingMenuButton.Text = "Manage Content";
			this.addingMenuButton.UseVisualStyleBackColor = true;
			this.addingMenuButton.Click += new System.EventHandler(this.addingMenuButton_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 73);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(34, 15);
			this.label12.TabIndex = 17;
			this.label12.Text = "Type:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(527, 332);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.addingMenuButton);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.createDocumentButton);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBoxModel);
			this.Controls.Add(this.comboBoxMake);
			this.Controls.Add(this.comboBoxWarehouse);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();
			foreach (string Warehouse in DataCollector[0])
			{
				comboBoxWarehouse.Items.Add(Warehouse);
			}
			foreach (string Make in DataCollector[1])
			{
				comboBoxMake.Items.Add(Make);
			}
			foreach (string Name in DataCollector[2])
			{
				comboBox4.Items.Add(Name);
			}
		}
		private void InitializeNoConnection()
		{
			this.label11 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(12, 9);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(436, 45);
			this.label11.TabIndex = 0;
			this.label11.Text = "No connection with database";
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(458, 102);
			this.Controls.Add(this.label11);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private void InitializeAddingMenu()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.GoBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			this.GoBack.Location = new System.Drawing.Point(393, 17);
			this.GoBack.Name = "button2";
			this.GoBack.Size = new System.Drawing.Size(121, 23);
			this.GoBack.TabIndex = 16;
			this.GoBack.Text = "Manage Content";
			this.GoBack.UseVisualStyleBackColor = true;
			this.GoBack.Click += new System.EventHandler(this.backButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(365, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "GPU Warehouses Managment";
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(149, 51);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(73, 19);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.Text = "Add GPU";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Checked = true;
			this.radioButton4.Location = new System.Drawing.Point(12, 51);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(109, 19);
			this.radioButton4.TabIndex = 2;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Add Warehouse";
			this.radioButton4.UseVisualStyleBackColor = true;
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);

			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(527, 332);
			this.Controls.Add(this.GoBack);
			this.Controls.Add(this.radioButton4);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private void InitializeAddWarehouse()
		{
			GpuOrWearhouse = true;
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.addWarehouseButton = new System.Windows.Forms.Button();

			this.textBox3.Location = new System.Drawing.Point(12, 106);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 23);
			this.textBox3.TabIndex = 3;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(12, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 15);
			this.label8.TabIndex = 4;
			this.label8.Text = "City";
			// 
			// button3
			// 
			this.addWarehouseButton.Location = new System.Drawing.Point(12, 171);
			this.addWarehouseButton.Name = "button3";
			this.addWarehouseButton.Size = new System.Drawing.Size(95, 23);
			this.addWarehouseButton.TabIndex = 5;
			this.addWarehouseButton.Text = "Add";
			this.addWarehouseButton.UseVisualStyleBackColor = true;
			this.addWarehouseButton.Click += new System.EventHandler(this.addWarehouseButton_Click);

			this.Controls.Add(this.addWarehouseButton);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox3);
		}
		private void InitializeAddGpu()
		{
			GpuOrWearhouse = false;
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.addGpuButton = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			// 
			// comboBox5
			// 
			this.comboBox5.FormattingEnabled = true;
			this.comboBox5.Location = new System.Drawing.Point(12, 106);
			this.comboBox5.Name = "comboBox5";
			this.comboBox5.Size = new System.Drawing.Size(100, 23);
			this.comboBox5.TabIndex = 3;
			this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(12, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(36, 15);
			this.label9.TabIndex = 4;
			this.label9.Text = "Make";
			// 
			// button4
			// 
			this.addGpuButton.Location = new System.Drawing.Point(12, 171);
			this.addGpuButton.Name = "button4";
			this.addGpuButton.Size = new System.Drawing.Size(95, 23);
			this.addGpuButton.TabIndex = 5;
			this.addGpuButton.Text = "Add";
			this.addGpuButton.UseVisualStyleBackColor = true;
			this.addGpuButton.Click += new System.EventHandler(this.addGpuButton_Click);
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(149, 106);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 23);
			this.textBox4.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(149, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 15);
			this.label10.TabIndex = 7;
			this.label10.Text = "Model";

			this.Controls.Add(this.label10);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.addGpuButton);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.comboBox5);

			foreach (string Make in DataCollector[1])
			{
				comboBox5.Items.Add(Make);
			}

		}
		#endregion

		#region Update comboboxes
		private void UpdateDataCollector()
		{
			if (DataCollector != null)
			{
				DataCollector.Clear();
			}
			DataCollector = ColeslawData.ColeslawConnectionEF.DBConnectionService.GetLists();
		}
		private void UpdateComboMainMenu()
		{
			UpdateDataCollector();
			comboBoxWarehouse.Items.Clear();
			comboBoxMake.Items.Clear();
			comboBox4.Items.Clear();
			foreach (string Warehouse in DataCollector[0])
			{
				comboBoxWarehouse.Items.Add(Warehouse);
			}
			foreach (string Make in DataCollector[1])
			{
				comboBoxMake.Items.Add(Make);
			}
			foreach (string Name in DataCollector[clientType])
			{
				comboBox4.Items.Add(Name);
			}
		}
		private void UpdateClient()
		{
			comboBox4.Items.Clear();
			foreach (string Name in DataCollector[clientType])
			{
				comboBox4.Items.Add(Name);
			}
		}
		private void Log(string message)
		{
			message += "\r\n" + textBox2.Text;
			textBox2.Text = DateTime.Now.ToString("HH:mm:ss : ") + message;
		}
		private void Log(int i)
		{
			string message = DateTime.Now.ToString("HH:mm:ss : ");
			if (i == 1)
			{
				message += "ERROR: Failed connecting to database";
				message += "\r\n" + textBox2.Text;
				textBox2.Text = message;
			}
			if (i == 2)
			{
				message += $"Connected to database {DbName}";
				message += "\r\n" + textBox2.Text;
				textBox2.Text = message;
			}
		}
		private void Log(int i, string message)
		{
			string messageToLog = DateTime.Now.ToString("HH:mm:ss : ");
			if (i == 1)
			{
				messageToLog += $"Error: {message}";
				messageToLog += "\r\n" + textBox2.Text;
				textBox2.Text = messageToLog;
			}
			else if (i == 2)
			{
				messageToLog += $"Added: {message}";
				messageToLog += "\r\n" + textBox2.Text;
				textBox2.Text = messageToLog;
			}
			else if (i == 3)
			{
				messageToLog += $"Created: {message}";
				messageToLog += "\r\n" + textBox2.Text;
				textBox2.Text = messageToLog;
			}
		}
		#endregion
		private string DbName = "Test1";
		private string ConnectionString = $"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Test1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		private List<List<string>> DataCollector = new List<List<string>>();
		private int type = 1;
		private SqlTransaction currentTransaction;
		private DBConnectionService gpuWarehouseService = new DBConnectionService("Test1");
		private bool GpuOrWearhouse;
		private int clientType = 2;
		private Label label1;
		private ComboBox comboBoxWarehouse;
		private ComboBox comboBoxMake;
		private ComboBox comboBoxModel;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private Button createDocumentButton;
		private TextBox textBox2;
		private Label label6;
		private ComboBox comboBox4;
		private Label label7;
		private Button addingMenuButton;
		private RadioButton radioButton3;
		private RadioButton radioButton4;
		private TextBox textBox3;
		private Label label8;
		private Button addWarehouseButton;
		private ComboBox comboBox5;
		private Label label9;
		private Button addGpuButton;
		private TextBox textBox4;
		private Label label10;
		private Button GoBack;
		private Label label11;
		private Label label12;
	}
}