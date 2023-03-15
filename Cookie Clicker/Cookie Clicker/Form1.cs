namespace Cookie_Clicker
{
    public partial class Form1 : Form
    {
        
        private int _ticks;
        private int _clicks;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Click on the Cookie as much as possible!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Cookie
            timer1.Start();
            label2.Text = "Clicks : " + _clicks;
            _clicks++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Timer
            _ticks++;
            label1.Text = "Time: " + _ticks;

            if (_ticks == 11)
            {
                timer1.Stop();
                label1.Text = "Game Over!";
                label2.Text = "Clicks: " + _clicks;
                _ticks = 0;
                _clicks = 0;
                MessageBox.Show("Time's Up!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Time: " + _ticks;
            label2.Text = "Clicks: " + _clicks;
            _ticks= 0;
            _clicks = 0;
        }
    }
}