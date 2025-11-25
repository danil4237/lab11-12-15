
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace GameWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int TotalPairs = 10;

        private readonly List<string> _fruitEmoji = new List<string>()
                         {
                            "🍒","🍒",
                            "🍓","🍓",
                            "🍓","🍓",
                            "🍍","🍍",
                            "🍎","🍎",
                            "🍑","🍑",
                            "🥝","🥝",
                            "🥥","🥥",
                            "🍇","🍇",
                            "🌶","🌶",
                         };

        DispatcherTimer _timer = new DispatcherTimer();
        int _tenthOfSecondsElapsed;
        int _matchesFound;

        private Random _random = new Random();
        TextBlock _lastTextBlockClicked;
        bool _findingMatch = false;
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
            SetUpGame();
        }
        private void InitializeTimer() 
        {
            _timer.Interval = TimeSpan.FromSeconds(.1);
            _timer.Tick += Timer_Tick;
        }
        private void AssignRandomEmojis() 
        {
            var emojis = new List<string>(_fruitEmoji);
            foreach (TextBlock textBlock in mainGrid.Children.OfType<TextBlock>()) 
            {
                if (textBlock.Name != "timerTextBlock") 
                {
                    textBlock.Visibility = Visibility.Visible;
                    int index = _random.Next(emojis.Count);
                    textBlock.Text = emojis[index];
                    emojis.RemoveAt(index);
                }
            }
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            _tenthOfSecondsElapsed++;
            timeTextBlock.Text = $"{_tenthOfSecondsElapsed / 10F:0.0s}";
            if(_matchesFound == 10)
            {
                _timer.Stop();
                timeTextBlock.Text += " - Play again?";
            }
        }

        private void SetUpGame()
        {
            //List<string> fruitEmoji = new List<string>()
            //{
            //    "🍒","🍒",
            //    "🍓","🍓",
            //    "🍓","🍓",
            //    "🍍","🍍",
            //    "🍎","🍎",
            //    "🍑","🍑",
            //    "🥝","🥝",
            //    "🥥","🥥",
            //    "🍇","🍇",
            //    "🌶","🌶",
            //};
            //foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())
            //{
            //    if (textBlock.Name != "timeTextBlock") 
            //    {
            //        textBlock.Visibility = Visibility.Visible;
            //        int index = _random.Next(_fruitEmoji.Count);
            //        string nextEmoji = _fruitEmoji[index];
            //        textBlock.Text = nextEmoji;
            //        _fruitEmoji.RemoveAt(index);
            //    }
            //}
            AssignRandomEmojis();
            _timer.Start();
            _tenthOfSecondsElapsed = 0;
            _matchesFound = 0;
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e) {
            if (!(sender is TextBlock clickedTextBlock && clickedTextBlock.Visibility == Visibility.Visible))
                return;
            if (!_findingMatch) {
                clickedTextBlock.Visibility = Visibility.Hidden;
                _lastTextBlockClicked = clickedTextBlock;
                _findingMatch = true;
                return;
                if (clickedTextBlock == _lastTextBlockClicked)
                    return;
                if (clickedTextBlock.Text == _lastTextBlockClicked.Text) {
                    clickedTextBlock.Visibility = Visibility.Hidden;
                    _matchesFound++;
                }
                else {
                    _lastTextBlockClicked.Visibility = Visibility.Visible;
                    _findingMatch = false;
                }
                //TextBlock textBlock = sender as TextBlock;
                //if (_matchesFound == TotalPairs)
                //{
                //    textBlock.Visibility = Visibility.Hidden;
                //    _lastTextBlockClicked = textBlock;
                //    _findingMatch = true;
                //}
                //else if (textBlock.Text == _lastTextBlockClicked.Text)
                //{
                //    _matchesFound++;
                //    textBlock.Visibility = Visibility.Hidden;
                //    _findingMatch = false;
                //}
                //else
                //{
                //    _lastTextBlockClicked.Visibility = Visibility.Visible;
                //    _findingMatch = false;
                //}
            }
        }
        private void TimeTextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (_matchesFound == TotalPairs)
                SetUpGame();
        }
    }
}