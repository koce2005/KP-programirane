namespace KP_programirane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Rectangle);
            t.Start();
        }
        private void Rectangle()
        {
            for (int i = 0; i < 50; i--)
            {
                Random rnd = new Random();

                int width = rnd.Next(50, 200);
                int height = rnd.Next(50, 200);
                int x = rnd.Next(1, this.Width);
                int y = rnd.Next(1, this.Height);

                Graphics g = this.CreateGraphics();
                g.DrawRectangle(Pens.Black, new Rectangle(x, y, width, height));
                Thread.Sleep(3000);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            Thread t = new Thread(Triangle);
            t.Start();
        }

        private void Triangle()
        {
            for (int i = 0; i < 50; i--)
            {
                Random rnd = new Random();
                int size = rnd.Next(50, 200);
                int x = rnd.Next(0, this.ClientSize.Width - size);
                int y = rnd.Next(0, this.ClientSize.Height - size);

                using (Graphics g = this.CreateGraphics())
                {
                    Point[] points = {
            new Point(x, y),
            new Point(x + size, y),
            new Point(x + size / 2, y + size) };

                    Pen penpen = new Pen(Brushes.Black);
                    g.DrawPolygon(penpen, points);
                }
                Thread.Sleep(3000);

            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(Circle);
            t.Start();
        }
        private void Circle()
        {
            for (int i = 0; i < 50; i--)
            {
                Random rand = new Random();
                Pen pen = new Pen(Brushes.Black);
                int size = rand.Next(50, 200);
                int x = rand.Next(0, this.ClientSize.Width - size);
                int y = rand.Next(0, this.ClientSize.Height - size);
                Graphics g = this.CreateGraphics();
                Pen penpen = new Pen(Brushes.Black);
                g.DrawEllipse(penpen, x, y, size, size);
                Thread.Sleep(3000);
            }

        }
    }
}