namespace JuliaVisualisation
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
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.maxy = new System.Windows.Forms.TextBox();
			this.miny = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.maxx = new System.Windows.Forms.TextBox();
			this.minx = new System.Windows.Forms.TextBox();
			this.Fractal = new System.Windows.Forms.PictureBox();
			this.Selection = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cIm = new System.Windows.Forms.TextBox();
			this.cRe = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.Predefined = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.Fractal)).BeginInit();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(451, 266);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 28);
			this.button1.TabIndex = 15;
			this.button1.Text = "Generuj";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(451, 89);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 28);
			this.label2.TabIndex = 14;
			this.label2.Text = "Zakres Y";
			// 
			// maxy
			// 
			this.maxy.Location = new System.Drawing.Point(528, 118);
			this.maxy.Name = "maxy";
			this.maxy.Size = new System.Drawing.Size(144, 23);
			this.maxy.TabIndex = 13;
			this.maxy.Text = "textBox3";
			// 
			// miny
			// 
			this.miny.Location = new System.Drawing.Point(528, 89);
			this.miny.Name = "miny";
			this.miny.Size = new System.Drawing.Size(144, 23);
			this.miny.TabIndex = 12;
			this.miny.Text = "textBox4";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(451, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 28);
			this.label1.TabIndex = 11;
			this.label1.Text = "Zakres X";
			// 
			// maxx
			// 
			this.maxx.Location = new System.Drawing.Point(528, 50);
			this.maxx.Name = "maxx";
			this.maxx.Size = new System.Drawing.Size(144, 23);
			this.maxx.TabIndex = 10;
			this.maxx.Text = "textBox2";
			// 
			// minx
			// 
			this.minx.Location = new System.Drawing.Point(528, 21);
			this.minx.Name = "minx";
			this.minx.Size = new System.Drawing.Size(144, 23);
			this.minx.TabIndex = 9;
			this.minx.Text = "textBox1";
			// 
			// Fractal
			// 
			this.Fractal.Cursor = System.Windows.Forms.Cursors.Cross;
			this.Fractal.Location = new System.Drawing.Point(10, 10);
			this.Fractal.Name = "Fractal";
			this.Fractal.Size = new System.Drawing.Size(422, 433);
			this.Fractal.TabIndex = 8;
			this.Fractal.TabStop = false;
			this.Fractal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Fractal_MouseDown);
			this.Fractal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Fractal_MouseMove);
			this.Fractal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Fractal_MouseUp);
			// 
			// Selection
			// 
			this.Selection.BackColor = System.Drawing.SystemColors.HighlightText;
			this.Selection.Location = new System.Drawing.Point(192, 197);
			this.Selection.Name = "Selection";
			this.Selection.Size = new System.Drawing.Size(58, 49);
			this.Selection.TabIndex = 16;
			this.Selection.Visible = false;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(557, 266);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 28);
			this.button2.TabIndex = 17;
			this.button2.Text = "Reset";
			this.button2.Click += new System.EventHandler(this.Form1_Load);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(451, 325);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(221, 59);
			this.label3.TabIndex = 18;
			this.label3.Text = "W oknie po lewej zaznacz fragment do powiekszenia, badz wpisz  zakres recznie i n" +
    "acisnij \"Generuj\"";
			// 
			// cIm
			// 
			this.cIm.Location = new System.Drawing.Point(528, 217);
			this.cIm.Name = "cIm";
			this.cIm.Size = new System.Drawing.Size(144, 23);
			this.cIm.TabIndex = 20;
			this.cIm.Text = "textBox3";
			// 
			// cRe
			// 
			this.cRe.Location = new System.Drawing.Point(528, 187);
			this.cRe.Name = "cRe";
			this.cRe.Size = new System.Drawing.Size(144, 23);
			this.cRe.TabIndex = 19;
			this.cRe.Text = "textBox4";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(480, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 28);
			this.label4.TabIndex = 21;
			this.label4.Text = "c (Re)";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(480, 226);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 29);
			this.label5.TabIndex = 22;
			this.label5.Text = "c (Im)";
			// 
			// Predefined
			// 
			this.Predefined.Items.AddRange(new object[] {
            "Douady\'s Rabbit Fractal ",
            "San Marco Fractal ",
            "Siegel Disk Fractal ",
            "Dendrite Fractal"});
			this.Predefined.Location = new System.Drawing.Point(480, 158);
			this.Predefined.Name = "Predefined";
			this.Predefined.Size = new System.Drawing.Size(192, 23);
			this.Predefined.TabIndex = 23;
			this.Predefined.Text = "Douady\'s Rabbit Fractal ";
			this.Predefined.SelectionChangeCommitted += new System.EventHandler(this.Predefined_SelectionChangeCommitted);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
			this.ClientSize = new System.Drawing.Size(702, 455);
			this.Controls.Add(this.Predefined);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.cIm);
			this.Controls.Add(this.cRe);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.Selection);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.maxy);
			this.Controls.Add(this.miny);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.maxx);
			this.Controls.Add(this.minx);
			this.Controls.Add(this.Fractal);
			this.Name = "Form1";
			this.Text = "Fraktale - zbior Julii - www.algorytm.org (c) 2008 by Tomasz Lubinski";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.Fractal)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		//for HSV colors
		private void HSV2RGB(float hue, float sat, float val, out float red, out float grn, out float blu)
		{
			int i;
			float f, p, q, t;
			red = 0; grn = 0; blu = 0;
			if (val == 0) { return; }
			else
			{
				hue /= 60;
				i = (int)(hue);
				f = hue - i;
				p = val * (1 - sat);
				q = val * (1 - (sat * f));
				t = val * (1 - (sat * (1 - f)));
				if (i == 0) { red = val; grn = t; blu = p; }
				else if (i == 1) { red = q; grn = val; blu = p; }
				else if (i == 2) { red = p; grn = val; blu = t; }
				else if (i == 3) { red = p; grn = q; blu = val; }
				else if (i == 4) { red = t; grn = p; blu = val; }
				else if (i == 5) { red = val; grn = p; blu = q; }
			}
		}

		//initialize color pens
		private void initializeColors()
		{
			float r, g, b;

			for (int i = 0; i < penColors.Length - 1; i++)
			{
				HSV2RGB((float)3.3 * i, (float)0.85, (float)0.6, out r, out g, out b);
				penColors[i] = new Pen(Color.FromArgb((int)(r * 255), (int)(g * 255), (int)(b * 255)));
			}
			penColors[penColors.Length - 1] = new Pen(Color.FromArgb(0, 0, 0));
		}

		/// <summary>
		/// Generates fractal - Julia set
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, System.EventArgs e)
		{
			
			int i, j, level;
			complex_t p = new complex_t();
			complex_t c = new complex_t();

			Fractal.Image = new Bitmap(Fractal.Width, Fractal.Height);
			Graphics graph = Graphics.FromImage(Fractal.Image);
			graph.FillRectangle(new SolidBrush(Color.White), 0, 0, Fractal.Width, Fractal.Height);

			minX = double.Parse(minx.Text);
			minY = double.Parse(miny.Text);
			maxX = double.Parse(maxx.Text);
			maxY = double.Parse(maxy.Text);

			c.real = double.Parse(cRe.Text);
			c.imaginary = double.Parse(cIm.Text);

			ratioX = (maxX - minX) / Fractal.Width;
			ratioY = (maxY - minY) / Fractal.Height;

			for (i = 0; i < Fractal.Height; i++)
			{
				p.imaginary = i * ratioY + minY;
				for (j = 0; j < Fractal.Width; j++)
				{
					p.real = j * ratioX + minX;
					level = levelSet(p, c);
					graph.DrawRectangle(penColors[level - 1], j, i, 1, 1);
				}
			}
			Fractal.Invalidate();
		}

		//function z[0]=p
		private complex_t f(complex_t p)
		{
			return p;
		}

		//function z[n+1] = z[n]^2 + c
		private complex_t g(complex_t z, complex_t c)
		{
			complex_t result = new complex_t();
			result.real = z.real * z.real - z.imaginary * z.imaginary + c.real;
			result.imaginary = 2 * z.real * z.imaginary + c.imaginary;
			return result;
		}

		//value is inside set in the returned level
		private int levelSet(complex_t p, complex_t c)
		{
			complex_t z = new complex_t();
			int iteration;

			iteration = 0;
			z = f(p);

			do
			{
				z = g(z, c);
				iteration++;
			} while (z.complexModSq() < 4 && iteration < 120);

			return iteration;
		}

		//intialize form
		private void Form1_Load(object sender, System.EventArgs e)
		{
			minx.Text = ((double)-1.5).ToString();
			maxx.Text = ((double)1.5).ToString();
			miny.Text = ((double)-1.25).ToString();
			maxy.Text = ((double)1.25).ToString();

			cRe.Text = ((double)-0.123).ToString();
			cIm.Text = ((double)0.745).ToString();

			minX = double.Parse(minx.Text);
			minY = double.Parse(miny.Text);
			maxX = double.Parse(maxx.Text);
			maxY = double.Parse(maxy.Text);

			ratioX = (maxX - minX) / Fractal.Width;
			ratioY = (maxY - minY) / Fractal.Height;

			initializeColors();

			Fractal.Image = new Bitmap(Fractal.Width, Fractal.Height);
			graph = Graphics.FromImage(Fractal.Image);

			//render new fractal
			button1_Click(sender, e);
		}

		//draw selection
		private void Fractal_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				downX = e.X;
				downY = e.Y;

				Selection.Width = 0;
				Selection.Height = 0;
				Selection.Visible = true;
			}
		}

		//redraw selection
		private void Fractal_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Selection.Width = Math.Abs(downX - e.X);
				Selection.Height = Math.Abs(downY - e.Y);
				Selection.Left = Fractal.Left + Math.Min(downX, e.X);
				Selection.Top = Fractal.Top + Math.Min(downY, e.Y);
			}
		}

		//clear selection - render new fractal for given selection
		private void Fractal_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			//remove selection
			Selection.Visible = false;

			//get new range to render
			minx.Text = (Math.Min(downX, e.X) * ratioX + minX).ToString();
			maxx.Text = (Math.Max(downX, e.X) * ratioX + minX).ToString();
			miny.Text = (Math.Min(downY, e.Y) * ratioY + minY).ToString();
			maxy.Text = (Math.Max(downY, e.Y) * ratioY + minY).ToString();

			minX = double.Parse(minx.Text);
			minY = double.Parse(miny.Text);
			maxX = double.Parse(maxx.Text);
			maxY = double.Parse(maxy.Text);

			//render new fractal
			button1_Click(sender, e);
		}

		private void Predefined_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			switch (Predefined.SelectedIndex)
			{
				case 0:
					cRe.Text = (-0.123).ToString();
					cIm.Text = (0.745).ToString();
					break;
				case 1:
					cRe.Text = (-0.75).ToString();
					cIm.Text = (0.0).ToString();
					break;
				case 2:
					cRe.Text = (-0.390541).ToString();
					cIm.Text = (-0.586788).ToString();
					break;
				case 3:
					cRe.Text = (0).ToString();
					cIm.Text = (1).ToString();
					break;
			}

			//redraw fractal
			button1_Click(sender, e);
		}
		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox maxy;
		private System.Windows.Forms.TextBox miny;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox maxx;
		private System.Windows.Forms.TextBox minx;
		private System.Windows.Forms.PictureBox Fractal;
		private Graphics graph;

		//Describes places to render
		private double ratioX;
		private double ratioY;
		private double minX;
		private double minY;
		private double maxX;
		private double maxY;
		private int downX;
		private int downY;

		private Pen[] penColors = new Pen[120];
		private System.Windows.Forms.Panel Selection;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox cIm;
		private System.Windows.Forms.TextBox cRe;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox Predefined;
	}
	public class complex_t
	{
		public double real;
		public double imaginary;

		//calculate squared modus of given complex c
		public double complexModSq()
		{
			return (real * real + imaginary * imaginary);
		}
	}
}