using System.ComponentModel;
using System.Windows;
using System.Windows.Threading;

namespace WPF_C_Sharp_Lesson_2
{
    public partial class RealTimeCounterWindow : Window, INotifyPropertyChanged
    {
        private int _counter;
        public int Counter
        {
            get => _counter;
            set { _counter = value; OnPropertyChanged(nameof(Counter)); }
        }

        private DispatcherTimer _timer;

        public RealTimeCounterWindow()
        {
            InitializeComponent();
            DataContext = this;
            Counter = 0;

            _timer = new DispatcherTimer();
            _timer.Interval = System.TimeSpan.FromSeconds(1);
            _timer.Tick += (s, e) => {
                Counter++;
                CounterBlock.Text = _counter.ToString();
                    } ;
            _timer.Start();
        }

        private void IncrementButton_Click(object sender, RoutedEventArgs e)
        {
            Counter++;
            CounterBlock.Text = _counter.ToString();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
