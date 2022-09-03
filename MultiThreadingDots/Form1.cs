using System.Threading;

namespace MultiThreadingDots
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Hilo Color rojo
            Thread threadRed = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 1), new Rectangle(width, height, 10, 10));
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true};
            #endregion
            #region Hilo Color azul
            Thread threadBlue = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 1), new Rectangle(width, height, 10, 10));
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            #endregion
            #region Hilo Color verde
            Thread threadGreen = new Thread(t =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int height = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Green, 1), new Rectangle(width, height, 10, 10));
                    //Delay
                    Thread.Sleep(100);
                }
            })
            { IsBackground = true };
            #endregion
            threadBlue.Start();
            threadRed.Start();
            threadGreen.Start();
        }

        Random rd;

        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }

        private void redColor(object t)
        {

        }
    }
}