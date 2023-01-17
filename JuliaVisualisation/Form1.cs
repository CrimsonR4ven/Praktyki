namespace JuliaVisualisation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			funny();
		}
		private void funny()
		{
			while (cIm.Text != "1")
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
				cIm.Text = (double.Parse(cIm.Text) + 0.01).ToString();
				cRe.Text = (double.Parse(cRe.Text) + 0.01).ToString();
				Task.Delay(2000);
			}
		}
	}
}