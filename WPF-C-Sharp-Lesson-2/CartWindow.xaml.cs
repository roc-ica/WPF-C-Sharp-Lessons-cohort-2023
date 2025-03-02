using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_C_Sharp_Lesson_2
{
    /// <summary>
    /// Interaction logic for CartWindow.xaml
    /// </summary>
    public partial class CartWindow : Window, INotifyPropertyChanged
    {
        private Item _selectedItem;
        public ObservableCollection<Item> ItemList { get; set; }
        public ObservableCollection<Item> CartItems { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Item SelectedItem
        {
            get => _selectedItem;
            set { _selectedItem = value; OnPropertyChanged("SelectedItem"); }
        }
        private decimal _totalPrice;
        public decimal TotalPrice
        {
            get => _totalPrice;
            set { _totalPrice = value; OnPropertyChanged("TotalPrice"); }
        }

        public CartWindow()
        {
            InitializeComponent();
            ItemList = new ObservableCollection<Item>
            {
                new Item("Laptop", 999.99m),
                new Item("Smartphone", 599.99m),
                new Item("Headphones", 199.99m),
                new Item("Keyboard", 49.99m),
                new Item("Mouse", 29.99m)
            };
            CartItems = new ObservableCollection<Item>();
            SelectedItem = ItemList[0];
            TotalPrice = 0;
            DataContext = this;
        }

        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedItem != null)
            {
                CartItems.Add(SelectedItem);
                TotalPrice = CartItems.Sum(item => item.Price);
            }
        }

        private void RemoveFromCart_Click(object sender, RoutedEventArgs e)
        {
            if (CartListBox.SelectedItem is Item selectedItem)
            {
                CartItems.Remove(selectedItem);
                TotalPrice = CartItems.Sum(item => item.Price);
                CartListBox.SelectedItem = null;
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
