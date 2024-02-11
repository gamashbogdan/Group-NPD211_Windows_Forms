using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace _04_Schulte_Table
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private int elapsedTimeInSeconds;
        private int pressedButtons = 1;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            elapsedTimeInSeconds = 30;
            foreach (Button elem in panelButton.Controls.OfType<Button>())
            {
                elem.Click += button_Click;
            }
            foreach (Button elem in panelButton.Controls.OfType<Button>())
            {
                elem.TabStop = false;
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            elapsedTimeInSeconds--;
            if (elapsedTimeInSeconds != 0)
            {
                labelTimer.Text = $"Timer: {elapsedTimeInSeconds} сек.";
            }
            else
            {
                buttonStop_Click(sender, null!);
                MessageBox.Show("Ви програли)))))))))","End Game",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Timer_Start()
        {
            timer.Start();

        }
        private void Timer_Stop()
        {
            timer.Stop();
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            Timer_Start();
            trackBar_Scroll(sender, null!);
            trackBar.Enabled = false;
            int[] arr = GenerateRandomArray(36);
            int i = 0;
            foreach (Button btn in panelButton.Controls.OfType<Button>())
            {
                btn.Text = arr[i].ToString();
                i++;
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            labelTimer.Text = "Timer:";
            progressBar.Value = 0;
            pressedButtons = 1;
            Timer_Stop();
            foreach (Button elem in panelButton.Controls.OfType<Button>())
            {
                if (elem is Button)
                {
                    elem.Enabled = true;
                }
            }
            trackBar.Enabled = true;
            foreach (Button btn in panelButton.Controls.OfType<Button>())
            {
                btn.Text = "";
            }
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            if (trackBar.Value == 1)
            {
                elapsedTimeInSeconds = 30;
            }
            else if (trackBar.Value == 2)
            {
                elapsedTimeInSeconds = 60;

            }
            else if (trackBar.Value == 3)
            {
                elapsedTimeInSeconds = 90;
            }
            else if (trackBar.Value == 4)
            {
                elapsedTimeInSeconds = 120;
            }
        }
        public int[] GenerateRandomArray(int count)
        {
            Random random = new Random();
            int[] result = new int[count];
            int i = 0;

            while (i < count)
            {
                int randomNumber = random.Next(1, count + 1);
                if (Array.IndexOf(result, randomNumber) == -1)
                {
                    result[i] = randomNumber;
                    i++;
                }
            }
            return result;
        }
        private void button_Click(object sender, EventArgs e)
        {
            string textButton = ((Button)sender).Text;
            if (pressedButtons != 37 && int.TryParse(textButton, out int buttonValue) && buttonValue == pressedButtons)
            {
                ((Button)sender).Enabled = false;
                progressBar.Value++;
                if (pressedButtons == 36)
                {
                    buttonStop_Click(sender, null!);
                    MessageBox.Show($"your winnnnnnnnnnnnn :D", "Into");
                }
                pressedButtons++;
            }
        }


    }
   
}
