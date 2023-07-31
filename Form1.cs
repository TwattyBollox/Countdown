namespace Countdown
{
    public partial class CountDownTimer : Form
    {
        public CountDownTimer()
        {
            InitializeComponent();
        }
        int timeleft = 1800;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                timerlabel.Text = timeleft + " seconds";
                int minsleft = timeleft / 60;
                minslabel.Text = minsleft.ToString();
                int secondsleft = timeleft % 60;
                secslabel.Text = secondsleft.ToString();
            }
            else
            {
                timeleft = 1800;
                timer.Start();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timeleft = 1800;
            timerlabel.Text = timeleft + " seconds";
            timer.Start();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}