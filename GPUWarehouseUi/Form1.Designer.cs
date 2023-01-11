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
			this.label11 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label11.Location = new System.Drawing.Point(12, 34);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(436, 45);
			this.label11.TabIndex = 0;
			this.label11.Text = "No connection with database";
			this.label11.Click += new System.EventHandler(this.label11_Click);
			// 
			// Form1
			// 
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(453, 88);
			this.Controls.Add(this.label11);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		#region My Disposings
		private void DisposeMainMenu()
		{
			this.comboBox1.Dispose();
			this.comboBox2.Dispose();
			this.comboBox3.Dispose();
			this.textBox1.Dispose();
			this.label2.Dispose();
			this.label3.Dispose();
			this.label4.Dispose();
			this.label5.Dispose();
			this.radioButton1.Dispose();
			this.radioButton2.Dispose();
			this.button1.Dispose();
			this.label6.Dispose();
			this.comboBox4.Dispose();
			this.label7.Dispose();
			this.button2.Dispose();
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
			this.button3.Dispose();
		}
		private void DisposeAddGpu()
		{
			this.comboBox5.Dispose();
			this.label9.Dispose();
			this.button4.Dispose();
			this.textBox4.Dispose();
			this.label10.Dispose();
		}

		#endregion

		#region Initializations
		private void InitializeMainMenu()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
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
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 128);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "Warehouse";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(139, 128);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 23);
			this.comboBox2.TabIndex = 2;
			this.comboBox2.Text = "Make";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox3
			// 
			this.comboBox3.Enabled = false;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(266, 128);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 23);
			this.comboBox3.TabIndex = 3;
			this.comboBox3.Text = "Model";
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(393, 128);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 23);
			this.textBox1.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Which Warehouse";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(139, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Gpu Make";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(266, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Gpu Model";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(393, 101);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "Amount";
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 61);
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
			this.radioButton2.Location = new System.Drawing.Point(139, 61);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(78, 19);
			this.radioButton2.TabIndex = 10;
			this.radioButton2.Text = "Reception";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 23);
			this.button1.TabIndex = 11;
			this.button1.Text = "Create Document";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(266, 185);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(248, 128);
			this.textBox2.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(266, 167);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Logs";
			// 
			// comboBox4
			// 
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(12, 185);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 23);
			this.comboBox4.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 167);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Purchaser";
			this.label7.Click += new System.EventHandler(this.label7_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(393, 17);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 23);
			this.button2.TabIndex = 16;
			this.button2.Text = "Manage Content";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(527, 332);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.comboBox4);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.comboBox3);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();
			foreach (string Warehouse in gpuWarehouseService.WarehousesList)
			{
				comboBox1.Items.Add(Warehouse);
			}
			foreach (string Make in gpuWarehouseService.GpuMakeList)
			{
				comboBox2.Items.Add(Make);
			}
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
			this.GoBack.Click += new System.EventHandler(this.GoBackclk);
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
			this.button3 = new System.Windows.Forms.Button();

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
			this.button3.Location = new System.Drawing.Point(12, 171);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(95, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);

			this.Controls.Add(this.button3);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox3);
		}

		private void InitializeAddGpu()
		{
			GpuOrWearhouse = false;
			this.comboBox5 = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
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
			this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
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
			this.button4.Location = new System.Drawing.Point(12, 171);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(95, 23);
			this.button4.TabIndex = 5;
			this.button4.Text = "Add";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
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
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.comboBox5);

			foreach (string Make in gpuWarehouseService.GpuMakeList)
			{
				comboBox5.Items.Add(Make);
			}

		}
		#endregion

		#region Update comboboxes
		private void UpdateDataCollector()
		{
			if(DataCollector != null)
			{
				DataCollector.Clear();
			}
			DataCollector.Add(gpuWarehouseService.Select("City", "Warehouse", "Order by City", 1)[0]);
			DataCollector.Add(gpuWarehouseService.Select("Make", "Gpu", "Group by Make Order by Make", 1)[0]);
			foreach (string make in DataCollector[1])
			{
				DataCollector.Add(gpuWarehouseService.Select("Make, Model", "Gpu", $"Make = '{make}' Order by Model")[1]);
			}
		}
		private void UpdateComboMainMenu()
		{
			gpuWarehouseService.UpdateIt();
			comboBox1.Items.Clear();
			comboBox2.Items.Clear();
			foreach (string Warehouse in gpuWarehouseService.WarehousesList)
			{
				comboBox1.Items.Add(Warehouse);
			}
			foreach (string Make in gpuWarehouseService.GpuMakeList)
			{
				comboBox2.Items.Add(Make);
			}
		}
		#endregion
		private bool GpuOrWearhouse;
		private Label label1;
		private ComboBox comboBox1;
		private ComboBox comboBox2;
		private ComboBox comboBox3;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private Button button1;
		private TextBox textBox2;
		private Label label6;
		private ComboBox comboBox4;
		private Label label7;
		private Button button2;
		private RadioButton radioButton3;
		private RadioButton radioButton4;
		private TextBox textBox3;
		private Label label8;
		private Button button3;
		private ComboBox comboBox5;
		private Label label9;
		private Button button4;
		private TextBox textBox4;
		private Label label10;
		private Button GoBack;
		private Label label11;
	}
}