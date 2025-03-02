using System.ComponentModel;
using System.Windows;

namespace WPF_C_Sharp_Lesson_2
{
    public partial class SimpleBindingWindow : Window, INotifyPropertyChanged
    {
        private string _boundText;
        public string BoundText
        {
            get => _boundText;
            set { _boundText = value; OnPropertyChanged("BoundText"); }
        }

        public SimpleBindingWindow()
        {
            InitializeComponent();
            BoundText = "Hello, WPF!";
            DataContext = this;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}