using System.Windows;
using System.Windows.Threading;

namespace Timer
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private int _remainingSeconds;
        private bool _isRunning = false;

        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = System.TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            ResetTimer();
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            _remainingSeconds--;

            if (_remainingSeconds <= 0)
            {
                _timer.Stop();
                _isRunning = false;
                StartButton.Content = "Старт";
                MessageBox.Show("Время вышло!", "Таймер");
                ResetTimer();
            }
            UpdateTimeDisplay();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            if (!_isRunning)
            {
                _timer.Start();
                _isRunning = true;
                StartButton.Content = "Пауза";
            }
            else
            {
                _timer.Stop();
                _isRunning = false;
                StartButton.Content = "Старт";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _isRunning = false;
            StartButton.Content = "Старт";
            ResetTimer();
        }

        private void ResetTimer()
        {
            if (DurationComboBox.SelectedItem is System.Windows.Controls.ComboBoxItem item)
            {
                int minutes = int.Parse(item.Content.ToString());
                _remainingSeconds = minutes * 60;
                UpdateTimeDisplay();
            }
        }

        private void UpdateTimeDisplay()
        {
            int minutes = _remainingSeconds / 60;
            int seconds = _remainingSeconds % 60;
            TimeBlock.Text = $"{minutes:00}:{seconds:00}";
        }
    }
}