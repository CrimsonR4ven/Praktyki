namespace WinFormsSqlConnection
{
	public partial class Form1 : Form
	{
		public string username = "null";
		public Form1()
		{
			InitializeComponent();
			this.ComboboxAdd();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			username = comboBox1.GetItemText(comboBox1.SelectedIndex);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = username;
		}
	}
}